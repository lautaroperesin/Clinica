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
    public partial class TurnosView : Form
    {
        GenericService<Turno> turnoService = new GenericService<Turno>();
        GenericService<Medico> medicoService = new GenericService<Medico>();

        BindingSource bsTurnos = new BindingSource();

        List<Medico> listaMedicos = new List<Medico>();

        Turno turnoSeleccionado;

        public TurnosView()
        {
            InitializeComponent();
            dataGridTurnos.DataSource = bsTurnos;
        }

        private void TurnosView_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        //private async Task CargarGrilla()
        //{
        //    try
        //    {
        //        DateTime fechaSeleccionada = dtpFechaTurno.Value.Date;
        //        int medicoId = (int)cboMedicos.SelectedValue;

        //        bsTurnos.DataSource = await turnoService.ObtenerTurnosPorMedicoYFechaAsync(medicoId, fechaSeleccionada);

        //        AjustarGrilla();
        //        VerificarTurnos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar turnos: " + ex.Message);
        //    }
        //}

        private async void CargarCombo()
        {
            cboMedicos.DataSource = await medicoService.GetAllAsync();
            cboMedicos.DisplayMember = "NombreCompleto";
            cboMedicos.ValueMember = "Id";
            cboMedicos.SelectedIndex = -1;
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            turnoSeleccionado = (Turno)bsTurnos.Current;
            AgregarEditarTurnoView agregarEditarTurnoView = new AgregarEditarTurnoView(turnoSeleccionado);
            agregarEditarTurnoView.ShowDialog();
            //await CargarGrilla();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            int medicoId = (int)cboMedicos.SelectedValue;
            DateTime fechaSeleccionada = dtpFechaTurno.Value;

            //AgregarEditarTurnoView nuevoTurnoView = new AgregarEditarTurnoView(medicoId, fechaSeleccionada);
            //nuevoTurnoView.ShowDialog();
            //await CargarGrilla();
        }

        private void VerificarTurnos()
        {
            if (dataGridTurnos.Rows.Count == 0)
            {
                lblNoTurnos.Visible = true;
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                btnAgregar.Enabled = true;
                dtpFechaTurno.Enabled = true;
                btnAtender.Enabled = false;
            }
            else
            {
                lblNoTurnos.Visible = false;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                btnAgregar.Enabled = true;
                dtpFechaTurno.Enabled = true;
                btnAtender.Enabled = true;
            }
        }
    }
}
