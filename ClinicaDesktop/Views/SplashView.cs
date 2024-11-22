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

namespace ClinicaDesktop.Views
{
    public partial class SplashView : Form
    {
        bool dataReady = false;
        bool printReady = false;

        public SplashView()
        {
            InitializeComponent();
        }

        private async void SplashView_Activated(object sender, EventArgs e)
        {
            var conectarDbTask = ConectarConDb();
            //var imprimirReporteTask = ImprimirReporte();
            await Task.WhenAll(conectarDbTask); //, imprimirReporteTask
        }

        private async Task ImprimirReporte()
        {
            await Task.Run(() =>
            {
                ReportViewer reporte = new ReportViewer();
                reporte.LocalReport.ReportEmbeddedResource = "ClinicaDesktop.Reports.PacientesReport.rdlc";
                var pacientes = new List<Paciente> { new Paciente() { Id = 1, Nombre = "Lautaro", Apellido = "Gimenez", Direccion = "ds", Documento = "1234567", Telefono = "1234567", FechaNacimiento = DateTime.Now, LocalidadId = 1, MutualId = 1 } };
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSPacientes", pacientes));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.RefreshReport();
                printReady = true;
            });

        }

        private async Task ConectarConDb()
        {
            await Task.Run(async () =>
            {
                GenericService<Paciente> pacienteService = new GenericService<Paciente>();
                var pacientes = await pacienteService.GetAllAsync();
                dataReady = true;
            });
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 98)
                progressBar.Value += 2;
            if (dataReady) //&& printReady
            {
                timer.Enabled = false;
                this.Visible = false;
                var menuPrincipalView = new MenuPrincipalView();
                menuPrincipalView.ShowDialog();
                this.Close();
            }
        }
    }
}
