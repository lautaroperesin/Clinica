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
    public partial class AgregarMedicoView : Form
    {
        GenericService<Medico> medicoService = new GenericService<Medico>();
        public AgregarMedicoView()
        {
            InitializeComponent();
            cboTecnica.DataSource = Enum.GetValues(typeof(TecnicaEnum));
            cboTecnica.SelectedIndex = -1;
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
            if (cboTecnica.SelectedItem == null)
            {
                errorProvider.SetError(cboTecnica, "Debe seleccionar una técnica.");
                return;
            }

            var nuevoMedico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Tecnica = (TecnicaEnum?)cboTecnica.SelectedItem
            };

            try
            {
                await medicoService.AddAsync(nuevoMedico);
                MessageBox.Show("Médico agregado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el médico: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
