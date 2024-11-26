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
    public partial class PacientesViewReport : Form
    {
        ReportViewer reporte;
        GenericService<Paciente> pacienteService = new GenericService<Paciente>();
        public PacientesViewReport()
        {
            InitializeComponent();

            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        private async void PacientesViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "ClinicaDesktop.Reports.PacientesReport.rdlc";
            var pacientes = await pacienteService.GetAllAsync();
            var listaPacientes = pacientes.Select(p => new
            {
                Id = p.Id,
                NombreCompleto = p.NombreCompleto,
                Telefono = p.Telefono,
                Direccion = p.Direccion,
                Documento = p.Documento,
                Mutual = p.Mutual.Nombre,
                Localidad = p.Localidad.Nombre,
            }).ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSPacientes", listaPacientes));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.RefreshReport();
        }
    }
}
