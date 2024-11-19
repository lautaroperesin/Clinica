using ClinicaServices.Enums;
using ClinicaServices.Models;
using ClinicaServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDesktop.Views
{
    public partial class MedicosView : Form
    {
        GenericService<Medico> medicoService = new GenericService<Medico>();
        BindingSource bsMedicos = new BindingSource();
        List<Medico> listaMedicos = new List<Medico>();
        Medico? medicoActual;

        public MedicosView()
        {
            InitializeComponent();
            dataGridMedicos.DataSource = bsMedicos;
            cboTecnica.DataSource = Enum.GetValues(typeof(TecnicaEnum));
            cboTecnica.SelectedIndex = -1;
        }

        private async Task CargarGrilla()
        {
            try
            {
                bsMedicos.DataSource = await medicoService.GetAllAsync();
                listaMedicos = (List<Medico>)bsMedicos.DataSource;
                AjustarGrilla();
                VerificarElementosEnDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar médicos: " + ex.Message);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMedicoView agregarMedicoView = new AgregarMedicoView();
            agregarMedicoView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido, "El apellido es obligatorio.");
                return;
            }
            if (cboTecnica.SelectedIndex == -1)
            {
                errorProvider.SetError(cboTecnica, "Debe seleccionar una técnica.");
                return;
            }

            if (medicoActual == null)
            {
                MessageBox.Show("Debe seleccionar un médico para poder editarlo.");
                return;
            }
            else
            {
                medicoActual.Nombre = txtNombre.Text;
                medicoActual.Apellido = txtApellido.Text;
                medicoActual.Telefono = txtTelefono.Text;
                medicoActual.Tecnica = (TecnicaEnum?)cboTecnica.SelectedItem;
            }

            try
            {
                await medicoService.UpdateAsync(medicoActual);
                MessageBox.Show("Médico actualizado con éxito.");
                await CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar médico: " + ex.Message);
                return;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            medicoActual = (Medico)bsMedicos.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar el médico {medicoActual.NombreCompleto}?",
                                   "Eliminar médico",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    await medicoService.DeleteAsync(medicoActual.Id);
                    MessageBox.Show("Médico eliminado con éxito.");
                    medicoActual = null;
                    await CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar médico: " + ex.Message);
                }
            }
        }

        private void dataGridMedicos_SelectionChanged(object sender, EventArgs e)
        {
            medicoActual = (Medico)bsMedicos.Current;

            if (medicoActual != null)
            {
                txtNombre.Text = medicoActual.Nombre;
                txtApellido.Text = medicoActual.Apellido;
                txtTelefono.Text = medicoActual.Telefono;
                cboTecnica.SelectedItem = medicoActual.Tecnica;
            }
            else
            {
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                cboTecnica.SelectedIndex = -1;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            var medicosFiltrados = listaMedicos
                .Where(m => m.NombreCompleto.ToLower().Contains(filtro)).ToList();
            bsMedicos.DataSource = medicosFiltrados;
            VerificarElementosEnDataGrid();
        }

        private void VerificarElementosEnDataGrid()
        {
            if (dataGridMedicos.Rows.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }


        private void AjustarGrilla()
        {
            dataGridMedicos.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridMedicos.Columns["Tecnica"].HeaderText = "Técnica";

            dataGridMedicos.Columns["Id"].Visible = false;
            dataGridMedicos.Columns["TurnosAtendidos"].Visible = false;
            dataGridMedicos.Columns["NombreCompleto"].Visible = false;
            dataGridMedicos.Columns["Eliminado"].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void MedicosView_Load(object sender, EventArgs e)
        {
            await CargarGrilla();
        }
    }
}
