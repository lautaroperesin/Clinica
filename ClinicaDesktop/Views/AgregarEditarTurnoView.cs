using ClinicaDesktop.Class;
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
        PracticaService practicaService = new PracticaService();
        TurnoService turnoService = new TurnoService();

        public Turno turnoActual;
        Medico medicoActual;
        DateTime fecha;

        public AgregarEditarTurnoView(Medico medico, DateTime fecha)
        {
            InitializeComponent();
            this.medicoActual = medico;
            this.fecha = fecha;
            dtpFechaTurno.Value = fecha;
            txtMedico.Text = medico.NombreCompleto;
        }

        public AgregarEditarTurnoView(Turno turno, Medico medico, DateTime fecha)
        {
            InitializeComponent();
            this.medicoActual = medico;
            this.fecha = fecha;
            this.turnoActual = turno;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (turnoActual != null)
            {
                turnoActual.PacienteId = (int)cboPacientes.SelectedValue;
                turnoActual.PracticaId = (int)cboPracticas.SelectedValue;
                turnoActual.Tecnica = (TecnicaEnum)cboTecnicas.SelectedValue;
                //turnoActual.MedicoEfectorId = (int)cboMedicos.SelectedValue;
                turnoActual.FechaTurno = dtpFechaTurno.Value;
            }
            else
            {
                turnoActual = new Turno
                {
                    PacienteId = (int)cboPacientes.SelectedValue,
                    PracticaId = (int)cboPracticas.SelectedValue,
                    Tecnica = (TecnicaEnum)cboTecnicas.SelectedValue,
                    //MedicoEfectorId = (int)cboMedicos.SelectedValue,
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
            CargarCombos(turnoActual, medicoActual, fecha);
        }

        private async void CargarCombos(Turno? turno, Medico medico, DateTime fecha)
        {
            cboTecnicas.DataSource = Enum.GetValues(typeof(TecnicaEnum));

            cboPacientes.DataSource = await pacienteService.GetAllAsync();
            cboPacientes.DisplayMember = "NombreCompleto";
            cboPacientes.ValueMember = "Id";

            //cboPracticas.DataSource = await practicaService.GetAllAsync();
            //cboPracticas.DisplayMember = "Nombre";
            //cboPracticas.ValueMember = "Id";
             
            var horariosDisponibles = await turnoService.GetHorariosDisponibles(medico, fecha);
            cboHorarios.DataSource = horariosDisponibles;


            if (turno == null)
            {
                cboTecnicas.SelectedIndex = -1;
                cboPacientes.SelectedIndex = -1;
                cboPracticas.SelectedIndex = -1;
                cboHorarios.SelectedIndex = -1;
            }
            else
            {
                cboTecnicas.SelectedItem = turno.Tecnica;
                cboPacientes.SelectedValue = turno.PacienteId;
                cboPracticas.SelectedValue = turno.PracticaId;
                cboHorarios.SelectedValue = turno.FechaTurno.Value;
            }
        }

        private async void cboTecnicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTecnicas.SelectedIndex != -1)
            {
                cboPracticas.Enabled = true;
                TecnicaEnum tecnicaSeleccionada = (TecnicaEnum)cboTecnicas.SelectedItem;
                cboPracticas.DataSource = await practicaService.GetPracticasPorTecnicaAsync(tecnicaSeleccionada);
                cboPracticas.DisplayMember = "Nombre";
                cboPracticas.ValueMember = "Id";
            }
            else
            {
                cboPracticas.Enabled = true;
            }
        }
    }
}
