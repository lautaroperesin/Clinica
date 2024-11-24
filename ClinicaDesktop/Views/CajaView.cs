using ClinicaServices.Enums;
using ClinicaServices.Models;
using ClinicaServices.Services;
using System.Data;

namespace ClinicaDesktop.Views
{
    public partial class CajaView : Form
    {
        TurnoService turnoService = new TurnoService();
        BindingSource bsTurnos = new BindingSource();
        List<Turno> listaTurnosAtendidos = new List<Turno>();

        Turno turnoSeleccioando;
        public CajaView()
        {
            InitializeComponent();
            dataGridCaja.DataSource = bsTurnos;
            CargarGrilla();
        }

        public async Task CargarGrilla()
        {
            try
            {
                listaTurnosAtendidos = await turnoService.GetTurnosAtendidos();

                var turnosAtendidosDelDia = listaTurnosAtendidos.Where(t => t.FechaTurno.Value.Date == DateTime.Today);

                if (turnosAtendidosDelDia.Any())
                {
                    lblNoTurnos.Visible = false;
                    bsTurnos.DataSource = turnosAtendidosDelDia;
                }
                else
                {
                    lblNoTurnos.Visible = true;
                    bsTurnos.DataSource = new List<Turno>();
                }

                AjustarGrilla();
                CalcularTotalCoseguro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los turnos atendidos: " + ex.Message);
            }
        }

        private void AjustarGrilla()
        {
            dataGridCaja.Columns["MedicoEfector"].HeaderText = "Médico Efector";
            dataGridCaja.Columns["FechaTurno"].HeaderText = "Fecha";
            dataGridCaja.Columns["FormaPago"].HeaderText = "Forma de Pago";
            dataGridCaja.Columns["Coseguro"].HeaderText = "Coseguro";

            dataGridCaja.Columns["Id"].Visible = false;
            dataGridCaja.Columns["MedicoEfectorId"].Visible = false;
            dataGridCaja.Columns["PacienteId"].Visible = false;
            dataGridCaja.Columns["PracticaId"].Visible = false;
            dataGridCaja.Columns["Eliminado"].Visible = false;
            dataGridCaja.Columns["Atendido"].Visible = false;
        }

        private void CalcularTotalCoseguro()
        {
            numericTotal.Value = (decimal)listaTurnosAtendidos.Where(t => t.FormaPago != FormaPagoEnum.Debe).Sum(t => t.Coseguro);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
