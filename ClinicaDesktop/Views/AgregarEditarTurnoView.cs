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
    public partial class AgregarEditarTurnoView : Form
    {
        GenericService<Medico> medicoService = new GenericService<Medico>();
        GenericService<Paciente> pacienteService = new GenericService<Paciente>();
        GenericService<Practica> practicaService = new GenericService<Practica>();

        public Turno turnoActual;

        public AgregarEditarTurnoView(int? medicoId, DateTime? fecha)
        {
            InitializeComponent();
            cboMedicos.SelectedValue = medicoId;
            dtpFechaTurno.Value = fecha.Value;
        }

        public AgregarEditarTurnoView(Turno turno)
        {
            InitializeComponent();
            this.turnoActual = turno;
            //CargarDatos();
        }

        private void CargarDatos(Turno turno)
        {
            if(turno != null)
            {
                dtpFechaTurno.Value = turno.FechaTurno.Value;
                cboMedicos.SelectedValue = turno.MedicoEfectorId;
                cboPacientes.SelectedValue = turno.PacienteId;
                cboPracticas.SelectedValue = turno.PracticaId;
                cboTecnicas.SelectedValue = turno.Tecnica;
            }
            else
            {
                dtpFechaTurno.Value = DateTime.Now;
                cboMedicos.SelectedIndex = -1;
                cboPacientes.SelectedIndex = -1;
                cboPracticas.SelectedIndex = -1;
                cboTecnicas.SelectedIndex = -1;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (turnoActual != null)
            {
                turnoActual.PacienteId = (int)cboPacientes.SelectedValue;
                turnoActual.PracticaId = (int)cboPracticas.SelectedValue;
                turnoActual.Tecnica = (TecnicaEnum)cboTecnicas.SelectedValue;
                turnoActual.MedicoEfectorId = (int)cboMedicos.SelectedValue;
                turnoActual.FechaTurno = dtpFechaTurno.Value;
            }
            else
            {
                turnoActual = new Turno
                {
                    PacienteId = (int)cboPacientes.SelectedValue,
                    PracticaId = (int)cboPracticas.SelectedValue,
                    Tecnica = (TecnicaEnum)cboTecnicas.SelectedValue,
                    MedicoEfectorId = (int)cboMedicos.SelectedValue,
                    FechaTurno = dtpFechaTurno.Value
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AgregarEditarTurnoView_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private async void CargarCombos()
        {
            cboMedicos.DataSource = await medicoService.GetAllAsync();
            cboMedicos.DisplayMember = "NombreCompleto";
            cboMedicos.ValueMember = "Id";

            cboPacientes.DataSource = await pacienteService.GetAllAsync();
            cboPacientes.DisplayMember = "NombreCompleto";
            cboPacientes.ValueMember = "Id";


            cboPracticas.DataSource = await practicaService.GetAllAsync();
            cboPracticas.DisplayMember = "Nombre";
            cboPracticas.ValueMember = "Id";

            cboTecnicas.DataSource = Enum.GetValues(typeof(TecnicaEnum));
        }
    }
}
