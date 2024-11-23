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
    public partial class LocalidadesView : Form
    {
        GenericService<Localidad> localidadService = new GenericService<Localidad>();
        List<Localidad> listaLocalidades = new List<Localidad>();
        BindingSource bsLocalidades = new BindingSource();

        Localidad localidadActual;

        public LocalidadesView()
        {
            InitializeComponent();
            dataGridLocalidades.DataSource = bsLocalidades;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            bsLocalidades.DataSource = await localidadService.GetAllAsync();
            listaLocalidades = (List<Localidad>)bsLocalidades.DataSource;

            dataGridLocalidades.Columns["Id"].Visible = false;
            dataGridLocalidades.Columns["Eliminado"].Visible = false;
            VerificarElementosEnDataGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = true;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            localidadActual = (Localidad)bsLocalidades.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar la localidad {localidadActual.Nombre}?",
                                   "Eliminar localidad",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await localidadService.DeleteAsync(localidadActual.Id);
                localidadActual = null;
                await CargarGrilla();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToUpper();
            var localidadesFiltradas = listaLocalidades.Where(p => p.Nombre.ToUpper().Contains(filtro)).ToList();
            bsLocalidades.DataSource = localidadesFiltradas;

            VerificarElementosEnDataGrid();
        }

        private void VerificarElementosEnDataGrid()
        {
            if (dataGridLocalidades.Rows.Count == 0)
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

        private void dataGridLocalidades_SelectionChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            localidadActual = (Localidad)bsLocalidades.Current;

            if (localidadActual != null)
            {
                txtNombre.Text = localidadActual.Nombre;
            }
            else
            {
                txtNombre.Text = string.Empty;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                return;
            }

            if (localidadActual != null)
            {
                localidadActual.Nombre = txtNombre.Text;
            }

            try
            {
                await localidadService.UpdateAsync(localidadActual);
                MessageBox.Show("Localidad actualizada con éxito.");
                await CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar localidad: " + ex.Message);
                return;
            }
        }

        private async void btnGuardarLocalidad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreNuevLoc.Text))
            {
                errorProvider.SetError(txtNombreNuevLoc, "El nombre es obligatorio.");
                return;
            }

            var nuevaLocalidad = new Localidad()
            {
                Nombre = txtNombreNuevLoc.Text
            };

            try
            {
                await localidadService.AddAsync(nuevaLocalidad);
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
            txtNombreNuevLoc.Clear();
        }
    }
}
