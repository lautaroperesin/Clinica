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
    public partial class MutualesView : Form
    {
        GenericService<Mutual> mutualService = new GenericService<Mutual>();
        BindingSource bsMutuales = new BindingSource();
        List<Mutual> listaMutuales = new List<Mutual>();
        Mutual? mutualActual;

        public MutualesView()
        {
            InitializeComponent();
            dataGridMutuales.DataSource = bsMutuales;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            try
            {
                bsMutuales.DataSource = await mutualService.GetAllAsync();
                listaMutuales = (List<Mutual>)bsMutuales.DataSource;

                dataGridMutuales.Columns["Id"].Visible = false;
                dataGridMutuales.Columns["Eliminado"].Visible = false;
                VerificarElementosEnDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar mutuales: " + ex.Message);
            }
        }

        private void dataGridMutuales_SelectionChanged(object sender, EventArgs e)
        {
            mutualActual = (Mutual)bsMutuales.Current;

            if (mutualActual != null)
            {
                txtNombre.Text = mutualActual.Nombre;
            }
            else
            {
                txtNombre.Clear();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToUpper();
            var mutualesFiltradas = listaMutuales.Where(m => m.Nombre.ToUpper().Contains(filtro)).ToList();
            bsMutuales.DataSource = mutualesFiltradas;
            VerificarElementosEnDataGrid();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Debes asignar un nombre.");
                return;
            }

            if (mutualActual != null)
            {
                mutualActual.Nombre = txtNombre.Text;
            }

            try
            {
                await mutualService.UpdateAsync(mutualActual);
                MessageBox.Show("Mutual actualizada con éxito.");
                await CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            mutualActual = (Mutual)bsMutuales.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar la mutual {mutualActual.Nombre}?",
                                   "Eliminar mutual",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    await mutualService.DeleteAsync(mutualActual.Id);
                    MessageBox.Show("Mutual eliminada con éxito.");
                    mutualActual = null;
                    await CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la mutual: " + ex.Message);
                }
            }
        }

        private void VerificarElementosEnDataGrid()
        {
            if (dataGridMutuales.Rows.Count == 0)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = true;
        }

        private async void btnGuardarNuevaMut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreNuevaMut.Text))
            {
                errorProvider1.SetError(txtNombreNuevaMut, "El nombre es obligatorio.");
                return;
            }

            var nuevaMutual = new Mutual()
            {
                Nombre = txtNombreNuevaMut.Text
            };

            try
            {
                await mutualService.AddAsync(nuevaMutual);
                MessageBox.Show("Mutual agregada correctamente.");
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
            txtNombreNuevaMut.Clear();
        }
    }
}
