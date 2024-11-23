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
    public partial class PracticasView : Form
    {
        GenericService<Practica> practicaService = new GenericService<Practica>();
        BindingSource bsPracticas = new BindingSource();
        List<Practica> listaPracticas = new List<Practica>();
        Practica? practicaActual;

        public PracticasView()
        {
            InitializeComponent();
            dataGridPracticas.DataSource = bsPracticas;
            CargarCombos();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            try
            {
                bsPracticas.DataSource = await practicaService.GetAllAsync();
                listaPracticas = (List<Practica>)bsPracticas.DataSource;

                dataGridPracticas.Columns["Id"].Visible = false;
                dataGridPracticas.Columns["Eliminado"].Visible = false;

                VerificarElementosEnDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar prácticas: " + ex.Message);
            }
        }

        private void dataGridPracticas_SelectionChanged(object sender, EventArgs e)
        {
            practicaActual = (Practica)bsPracticas.Current;

            if (practicaActual != null)
            {
                txtNombre.Text = practicaActual.Nombre;
                cboTecnicas.SelectedItem = practicaActual.Tecnica;
                txtPrecio.Text = practicaActual.Precio.ToString();
            }
            else
            {
                txtNombre.Clear();
                txtPrecio.Text = string.Empty;
                cboTecnicas.SelectedIndex = -1;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToUpper();
            var practicasFiltradas = listaPracticas.Where(s => s.Nombre.ToUpper().Contains(filtro)).ToList();
            bsPracticas.DataSource = practicasFiltradas;
            VerificarElementosEnDataGrid();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "Debes asignar un nombre a la práctica.");
                return;
            }

            if (practicaActual != null)
            {
                practicaActual.Nombre = txtNombre.Text;
                if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    practicaActual.Precio = decimal.Zero;
                }
                else
                {
                    practicaActual.Precio = decimal.Parse(txtPrecio.Text);
                }
                practicaActual.Tecnica = (TecnicaEnum?)cboTecnicas.SelectedItem;
            }

            try
            {
                await practicaService.UpdateAsync(practicaActual);
                MessageBox.Show("Práctica actualizada con éxito.");
                await CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            practicaActual = (Practica)bsPracticas.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar la práctica {practicaActual.Nombre}?",
                                   "Eliminar práctica",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    await practicaService.DeleteAsync(practicaActual.Id);
                    MessageBox.Show("Práctica eliminada con éxito.");
                    practicaActual = null;
                    await CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar práctica: " + ex.Message);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerificarElementosEnDataGrid()
        {
            if (dataGridPracticas.Rows.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                lblNoResultados.Visible = true;
            }
            else
            {
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;
                lblNoResultados.Visible = false;
            }
        }

        private void CargarCombos()
        {
            cboTecnicas.DataSource = Enum.GetValues(typeof(TecnicaEnum));
            cboTecnicas.SelectedIndex = -1;

            cboNuevaTecnica.DataSource = Enum.GetValues(typeof(TecnicaEnum));
            cboNuevaTecnica.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = true;
        }

        private async void btnNuevaPractica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreNuevaPrac.Text))
            {
                errorProvider.SetError(txtNombreNuevaPrac, "El nombre es obligatorio.");
                return;
            }

            var nuevaPractica = new Practica()
            {
                Nombre = txtNombreNuevaPrac.Text,
                Precio = string.IsNullOrWhiteSpace(txtNuevoPrecio.Text) ? (decimal?)decimal.Zero : Convert.ToDecimal(txtNuevoPrecio.Text),
                Tecnica = (TecnicaEnum?)cboNuevaTecnica.SelectedItem
            };

            try
            {
                await practicaService.AddAsync(nuevaPractica);
                MessageBox.Show("Localidad agregada correctamente.");
                panelAgregar.Visible = false;
                await CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
            txtNombreNuevaPrac.Clear();
            txtNuevoPrecio.Text = string.Empty;
            cboNuevaTecnica.SelectedIndex = -1;
        }
    }
}
