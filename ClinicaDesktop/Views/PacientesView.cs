﻿using ClinicaServices.Models;
using ClinicaServices.Services;
using System.Data;

namespace ClinicaDesktop.Views
{
    public partial class PacientesView : Form
    {
        GenericService<Paciente> pacienteService = new GenericService<Paciente>();
        GenericService<Mutual> mutualService = new GenericService<Mutual>();
        GenericService<Localidad> localidadService = new GenericService<Localidad>();

        List<Paciente> listaPacientes = new List<Paciente>();
        List<Mutual> listaMutuales = new List<Mutual>();
        List<Localidad> listaLocalidades = new List<Localidad>();

        BindingSource bsPacientes = new BindingSource();

        Paciente? pacienteActual;

        public PacientesView()
        {
            InitializeComponent();
            dataGridPacientes.DataSource = bsPacientes;
            ObtenerListas();
        }

        private async void ObtenerListas()
        {
            var tareas = new List<Task>
            {
                Task.Run(async () => listaPacientes = await pacienteService.GetAllAsync()),
                Task.Run(async () => listaMutuales = await mutualService.GetAllAsync()),
                Task.Run(async () => listaLocalidades = await localidadService.GetAllAsync())
            };

            await Task.WhenAll(tareas);

            CargarCombos();
            await CargarGrilla();
        }


        private async Task CargarGrilla()
        {
            try
            {
                bsPacientes.DataSource = listaPacientes;

                AjustarGrilla();
                VerificarElementosEnDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message);
            }
        }

        private void CargarCombos()
        {
            // Combo mutuales
            cboMutuales.DataSource = listaMutuales;
            cboMutuales.DisplayMember = "Nombre";
            cboMutuales.ValueMember = "Id";

            // Combo localidades
            cboLocalidades.DataSource = listaLocalidades;
            cboLocalidades.DisplayMember = "Nombre";
            cboLocalidades.ValueMember = "Id";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToUpper();
            var pacientesFiltrados = listaPacientes.Where(p => p.NombreCompleto.ToUpper().Contains(filtro) ||
                                                                    p.Documento.ToUpper().Contains(filtro))
                                                        .ToList();
            bsPacientes.DataSource = pacientesFiltrados;

            VerificarElementosEnDataGrid();
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
            if (string.IsNullOrWhiteSpace(txtDni.Text) && txtDni.Text.Length < 7 || txtDni.Text.Length > 8 && !long.TryParse(txtDni.Text, out _))
            {
                errorProvider.SetError(txtDni, "El DNI debe tener entre 7 y 8 dígitos y solo contener números.");
                return;
            }
            if (cboMutuales.SelectedIndex == -1)
            {
                errorProvider.SetError(cboMutuales, "Debe seleccionar una mutual.");
                return;
            }

            if (pacienteActual != null)
            {
                pacienteActual.Nombre = txtNombre.Text;
                pacienteActual.Apellido = txtApellido.Text;
                pacienteActual.Direccion = txtDireccion.Text;
                pacienteActual.Telefono = txtTelefono.Text;
                pacienteActual.Documento = txtDni.Text;
                pacienteActual.FechaNacimiento = dtpFechaNacimiento.Value;
                pacienteActual.MutualId = (int)cboMutuales.SelectedValue;
                pacienteActual.LocalidadId = (int?)cboLocalidades.SelectedValue;
            }

            try
            {
                await pacienteService.UpdateAsync(pacienteActual);
                MessageBox.Show("Paciente actualizado con éxito.");
                await ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar paciente: " + ex.Message);
                return;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            pacienteActual = (Paciente)bsPacientes.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar el paciente {pacienteActual.NombreCompleto}?",
                                   "Eliminar paciente",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    await pacienteService.DeleteAsync(pacienteActual.Id);
                    MessageBox.Show("Paciente eliminado con éxito.");
                    pacienteActual = null;
                    //await CargarGrilla();
                    await ActualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar paciente: " + ex.Message);
                }
            }
        }

        private void dataGridPacientes_SelectionChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            pacienteActual = (Paciente)bsPacientes.Current;

            if (pacienteActual != null)
            {
                txtNombre.Text = pacienteActual.Nombre;
                txtApellido.Text = pacienteActual.Apellido;
                txtDireccion.Text = pacienteActual.Direccion;
                dtpFechaNacimiento.Value = pacienteActual.FechaNacimiento.Value;
                txtTelefono.Text = pacienteActual.Telefono;
                txtDni.Text = pacienteActual.Documento;
                cboMutuales.SelectedValue = pacienteActual.MutualId;
                cboLocalidades.SelectedValue = pacienteActual.LocalidadId;
            }
            else
            {
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                dtpFechaNacimiento.Value = DateTime.Now;
                txtTelefono.Text = string.Empty;
                txtDni.Text = string.Empty;
                cboMutuales.SelectedIndex = -1;
                cboLocalidades.SelectedIndex = -1;
            }
        }


        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPacienteView agregarPacienteView = new AgregarPacienteView();
            agregarPacienteView.ShowDialog();
            //await CargarGrilla();
            await ActualizarLista();
        }

        private void AjustarGrilla()
        {
            dataGridPacientes.Columns["Documento"].HeaderText = "DNI";
            dataGridPacientes.Columns["Telefono"].HeaderText = "Teléfono";
            dataGridPacientes.Columns["Direccion"].HeaderText = "Dirección";
            dataGridPacientes.Columns["FechaNacimiento"].HeaderText = "Fecha de nacimiento";

            dataGridPacientes.Columns["Id"].Visible = false;
            dataGridPacientes.Columns["MutualId"].Visible = false;
            dataGridPacientes.Columns["LocalidadId"].Visible = false;
            dataGridPacientes.Columns["NombreCompleto"].Visible = false;
            dataGridPacientes.Columns["TurnosAtendidos"].Visible = false;
            dataGridPacientes.Columns["Eliminado"].Visible = false;
        }

        private void VerificarElementosEnDataGrid()
        {
            if (dataGridPacientes.Rows.Count == 0)
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

        private async Task ActualizarLista()
        {
            listaPacientes = await pacienteService.GetAllAsync();
            await CargarGrilla();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
