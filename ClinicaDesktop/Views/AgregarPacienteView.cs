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
    public partial class AgregarPacienteView : Form
    {
        GenericService<Paciente> pacienteService = new GenericService<Paciente>();
        GenericService<Mutual> mutualService = new GenericService<Mutual>();
        GenericService<Localidad> localidadService = new GenericService<Localidad>();
        Paciente nuevoPaciente = new Paciente();

        public AgregarPacienteView()
        {
            InitializeComponent();
            CargarCombos();
        }

        private async void CargarCombos()
        {
            // Combo mutuales
            cboMutuales.DataSource = await mutualService.GetAllAsync();
            cboMutuales.DisplayMember = "Nombre";
            cboMutuales.ValueMember = "Id";
            cboMutuales.SelectedIndex = -1;

            // Combo localidades
            cboLocalidades.DataSource = await localidadService.GetAllAsync();
            cboLocalidades.DisplayMember = "Nombre";
            cboLocalidades.ValueMember = "Id";
            cboLocalidades.SelectedIndex = -1;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            nuevoPaciente = new Paciente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Documento = txtDni.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                MutualId = (int)cboMutuales.SelectedValue,
                LocalidadId = (int?)cboLocalidades.SelectedValue
            };

            try
            {
                await pacienteService.AddAsync(nuevoPaciente);
                MessageBox.Show("Paciente agregado correctamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
