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
    public partial class HistoricoTurnosView : Form
    {
        TurnoService turnoService = new TurnoService();
        List<Turno> turnos = new List<Turno>();

        public HistoricoTurnosView()
        {
            InitializeComponent();
            CargarDatos();
        }

        private async void CargarDatos()
        {
            turnos = await turnoService.GetTurnosAtendidos();
            DisplayDataGrid();
            //CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (checkFiltrado.Checked)
            {
                //numericTotalFacturado.Value = turnos.Where(t => t.FechaTurno >= dtpDesde.Value && t.FechaTurno <= dtpHasta.Value).Sum(t => t.Coseguro);
            }
            else
            {
                //numericTotalFacturado.Value = ventas.Sum(venta => venta.Total);
            }
        }

        private void DisplayDataGrid()
        {
            dataGridTurnos.DataSource = turnos;
            AjustarGrilla();
        }

        private void AjustarGrilla()
        {
            dataGridTurnos.Columns["Id"].Visible = false;
            dataGridTurnos.Columns["PacienteId"].Visible = false;
            dataGridTurnos.Columns["MedicoId"].Visible = false;
            dataGridTurnos.Columns["Eliminado"].Visible = false;
            dataGridTurnos.Columns["Atendido"].Visible = false;
            dataGridTurnos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void checkFiltrado_CheckedChanged(object sender, EventArgs e)
        {
            panelFiltrado.Enabled = checkFiltrado.Checked;
            if (checkFiltrado.Checked)
            {
                dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                DisplayFilterData();
                CalcularTotal();
            }
            else
            {
                DisplayDataGrid();
                CalcularTotal();
            }
        }

        private void DisplayFilterData()
        {
            dataGridTurnos.DataSource = turnos.Where(t => t.FechaTurno >= dtpDesde.Value && t.FechaTurno <= dtpHasta.Value).ToList();
            AjustarGrilla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DisplayFilterData();
            CalcularTotal();
        }
    }
}
