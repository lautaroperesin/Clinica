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

        private decimal CalcularTotalCoseguro()
        {
            decimal total = 0;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow row in dataGridCaja.Rows)
            {
                // Verifica que la fila no sea nueva
                if (!row.IsNewRow)
                {
                    // Verifica si el valor de "FormaPago" es null antes de convertir
                    if (row.Cells["FormaPago"].Value != null)
                    {
                        FormaPagoEnum formaPago = (FormaPagoEnum)row.Cells["FormaPago"].Value;

                        // Solo suma el coseguro si la forma de pago es distinta a "debe"
                        if (formaPago != FormaPagoEnum.Debe)
                        {
                            decimal coseguro = Convert.ToDecimal(row.Cells["Coseguro"].Value);
                            total += coseguro;
                        }
                    }
                }
            }

            txtTotal.Text = total.ToString("C2");
            return total;
        }

        private async void btnQuitar_Click(object sender, EventArgs e)
        {
            turnoSeleccioando = (Turno)bsTurnos.Current;

            if (turnoSeleccioando == null)
            {
                MessageBox.Show("Debe seleccionar un turno para eliminar.", "Error al eliminar el turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await turnoService.DeleteAsync(turnoSeleccioando.Id);
                MessageBox.Show("Turno eliminado con éxito.");

                turnoSeleccioando = null;
                await CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar el turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
