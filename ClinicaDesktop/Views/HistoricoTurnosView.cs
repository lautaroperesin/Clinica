using ClinicaDesktop.ViewReports;
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
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (checkFiltrado.Checked)
            {
                numericTotal.Value = (decimal)turnos.Where(t => t.FechaTurno >= dtpDesde.Value && t.FechaTurno <= dtpHasta.Value).Sum(t => t.Coseguro);
            }
            else
            {
                numericTotal.Value = (decimal)turnos.Sum(t => t.Coseguro);
            }
        }

        private void DisplayDataGrid()
        {
            dataGridTurnos.DataSource = turnos;
            AjustarGrilla();
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

        private void AjustarGrilla()
        {
            dataGridTurnos.Columns["FechaTurno"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridTurnos.Columns["FechaTurno"].HeaderText = "Fecha";
            dataGridTurnos.Columns["MedicoEfector"].HeaderText = "Médico Efector";
            dataGridTurnos.Columns["Practica"].HeaderText = "Práctica";
            dataGridTurnos.Columns["Tecnica"].HeaderText = "Técnica";
            dataGridTurnos.Columns["FormaPago"].HeaderText = "Forma de Pago";

            dataGridTurnos.Columns["Id"].Visible = false;
            dataGridTurnos.Columns["PacienteId"].Visible = false;
            dataGridTurnos.Columns["PracticaId"].Visible = false;
            dataGridTurnos.Columns["MedicoEfectorId"].Visible = false;
            dataGridTurnos.Columns["Eliminado"].Visible = false;
            dataGridTurnos.Columns["Atendido"].Visible = false;

            if (dataGridTurnos.Rows.Count == 0)
            {
                lblNoResultados.Visible = true;
            }
            else
            {
                lblNoResultados.Visible = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var tituloReporte = "Listado de turnos";
            var turnosAImprimir = turnos;
            if(checkFiltrado.Checked)
            {
                turnosAImprimir = turnos.Where(turnos => turnos.FechaTurno >= dtpDesde.Value && turnos.FechaTurno <= dtpHasta.Value).ToList();
                tituloReporte = $"Listado de turnos desde {dtpDesde.Value.ToShortDateString()} hasta {dtpHasta.Value.ToShortDateString()}";
            }

            var reporteHistoricoTurnos = new HistoricoTurnosViewReport(turnos, tituloReporte);
            reporteHistoricoTurnos.ShowDialog();
        } 
    }
}
