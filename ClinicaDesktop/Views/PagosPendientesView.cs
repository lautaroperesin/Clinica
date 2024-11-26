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
    public partial class PagosPendientesView : Form
    {
        TurnoService turnoService = new TurnoService();
        BindingSource bsPagosPendientes = new BindingSource();
        List<Turno> turnosPendientes = new List<Turno>();
        Turno? turnoSeleccionado;

        public PagosPendientesView()
        {
            InitializeComponent();
            dataGridPagosPendientes.DataSource = bsPagosPendientes;
            cboFormaPago.DataSource = Enum.GetValues(typeof(FormaPagoEnum));
            cboFormaPago.SelectedIndex = -1;
        }

        private async void PagosPendientesView_Load(object sender, EventArgs e)
        {
            await CargarGrilla();
            turnosPendientes = (List<Turno>)bsPagosPendientes.DataSource;
        }

        private async Task CargarGrilla()
        {
            bsPagosPendientes.DataSource = await turnoService.GetTurnosConFormaPagoDebe();
            AjustarGrilla();
        }

        private async void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            turnoSeleccionado = (Turno)bsPagosPendientes.Current;

            if (cboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una forma de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (turnoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar una consulta para confirmar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var confirmacion = MessageBox.Show("¿Está seguro que desea confirmar el pago del turno seleccionado?", "Confirmar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    turnoSeleccionado.FormaPago = (FormaPagoEnum)cboFormaPago.SelectedItem;
                    turnoSeleccionado.FechaTurno = DateTime.Now;

                    try
                    {
                        await turnoService.UpdateAsync(turnoSeleccionado);
                        MessageBox.Show("Pago confirmado correctamente.");

                        cboFormaPago.SelectedIndex = -1;
                        turnoSeleccionado = null;
                        txtBuscar.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al confirmar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    await CargarGrilla();
                }
            }
        }

        private void AjustarGrilla()
        {
            dataGridPagosPendientes.Columns["Id"].Visible = false;
            dataGridPagosPendientes.Columns["PacienteId"].Visible = false;
            dataGridPagosPendientes.Columns["MedicoEfectorId"].Visible = false;
            dataGridPagosPendientes.Columns["PracticaId"].Visible = false;
            dataGridPagosPendientes.Columns["Tecnica"].Visible = false;
            dataGridPagosPendientes.Columns["FechaTurno"].HeaderText = "Fecha";
            dataGridPagosPendientes.Columns["Coseguro"].HeaderText = "Total a pagar";
            dataGridPagosPendientes.Columns["MedicoEfector"].HeaderText = "Médico efector";
            dataGridPagosPendientes.Columns["FormaPago"].Visible = false;
            dataGridPagosPendientes.Columns["Atendido"].Visible = false;
            dataGridPagosPendientes.Columns["Eliminado"].Visible = false;

            if (dataGridPagosPendientes.Rows.Count == 0)
            {
                lblNoPagos.Visible = true;
            }
            else
            {
                lblNoPagos.Visible = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToUpper();
            var turnosFiltrados = turnosPendientes.Where(c => c.Paciente.NombreCompleto.ToUpper().Contains(filtro)).ToList();
            bsPagosPendientes.DataSource = turnosFiltrados;
        }
    }
}
