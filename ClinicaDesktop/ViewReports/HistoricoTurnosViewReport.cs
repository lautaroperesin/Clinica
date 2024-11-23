using ClinicaServices.Models;
using ClinicaServices.Services;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDesktop.ViewReports
{
    public partial class HistoricoTurnosViewReport : Form
    {
        ReportViewer reporte;
        TurnoService turnoService = new TurnoService();
        List<Turno> listaTurnos = new List<Turno>();
        string tituloReporte;

        public HistoricoTurnosViewReport(List<Turno> turnos, string tituloReporte)
        {
            InitializeComponent();
            listaTurnos = turnos;
            this.tituloReporte = tituloReporte;
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void HistoricoTurnosViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ClinicaDesktop.Reports.HistoricoTurnosReport.rdlc";

            var turnos = listaTurnos
                .OrderBy(t => t.FormaPago)
                .Select(turno => new
                {
                    Fecha = turno.FechaTurno,
                    Paciente = turno.Paciente.NombreCompleto,
                    Medico = turno.MedicoEfector.NombreCompleto,
                    Practica = turno.Practica.Nombre,
                    Coseguro = turno.Coseguro,
                    FormaDePago = turno.FormaPago.ToString()
                })
                .ToList();

            reporte.LocalReport.SetParameters(new ReportParameter("TituloReporte", tituloReporte));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSTurnos", turnos));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
