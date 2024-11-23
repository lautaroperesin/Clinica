using ClinicaServices.Enums;
using ClinicaServices.Models;
using ClinicaServices.Services;
using System.Data;

namespace ClinicaDesktop.Views
{
    public partial class TurnosView : Form
    {
        TurnoService turnoService = new TurnoService();
        GenericService<Medico> medicoService = new GenericService<Medico>();

        BindingSource bsTurnos = new BindingSource();
        List<Turno> listaTurnos = new List<Turno>();

        List<Medico> listaMedicos = new List<Medico>();

        Turno turnoSeleccionado;

        public TurnosView()
        {
            InitializeComponent();
            dataGridTurnos.DataSource = bsTurnos;
            ObtenerListas();
            dtpFechaTurno.ValueChanged -= dtpFechaTurno_ValueChanged;
            dtpFechaTurno.Value = DateTime.Today;
            dtpFechaTurno.ValueChanged += dtpFechaTurno_ValueChanged;   
        }

        private async void ObtenerListas()
        {
            try
            {
                listaTurnos = await turnoService.GetAllAsync();
                listaMedicos = await medicoService.GetAllAsync();

                CargarCombo();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show($"Error al obtener listas: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }

        private async Task CargarGrilla()
        {
            try
            {
                listaTurnos = await turnoService.GetAllAsync();

                int medicoId = (int)cboMedicos.SelectedValue;
                DateTime fechaSeleccionada = dtpFechaTurno.Value.Date;

                var turnosFiltrados = listaTurnos.Where(t => t.MedicoEfectorId == medicoId && t.FechaTurno.Value.Date == fechaSeleccionada).ToList();

                bsTurnos.DataSource = turnosFiltrados;

                AjustarGrilla();
                VerificarTurnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar turnos: " + ex.Message);
            }
        }

        private void CargarCombo()
        {
            cboMedicos.SelectedIndexChanged -= cboMedicos_SelectedIndexChanged;

            cboMedicos.DataSource = listaMedicos;
            cboMedicos.DisplayMember = "NombreCompleto";
            cboMedicos.ValueMember = "Id";
            cboMedicos.SelectedIndex = -1;

            cboMedicos.SelectedIndexChanged += cboMedicos_SelectedIndexChanged;
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            turnoSeleccionado = (Turno)bsTurnos.Current;
            var medico = (Medico)cboMedicos.SelectedItem;
            var fecha = dtpFechaTurno.Value;

            using (var agregarEditarTurnoView = new AgregarEditarTurnoView(turnoSeleccionado, medico, fecha))
            {
                if (agregarEditarTurnoView.ShowDialog() == DialogResult.OK)
                {
                    await turnoService.UpdateAsync(agregarEditarTurnoView.turnoActual);
                    await CargarGrilla();
                }
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var medico = (Medico)cboMedicos.SelectedItem;
            var fecha = dtpFechaTurno.Value;

            AgregarEditarTurnoView agregarEditarTurnoView = new AgregarEditarTurnoView(medico, fecha);
            if (agregarEditarTurnoView.ShowDialog() == DialogResult.OK)
            {
                await turnoService.AddAsync(agregarEditarTurnoView.turnoActual);
                await CargarGrilla();
            }
        }

        private void VerificarTurnos()
        {
            if (dataGridTurnos.Rows.Count == 0)
            {
                lblNoTurnos.Visible = true;
                lblSelecMedico.Visible = false;
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                btnAtender.Enabled = false;
                btnAgregar.Enabled = true;
            }
            else
            {
                lblNoTurnos.Visible = false;
                lblSelecMedico.Visible = false;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                btnAtender.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }

        private void AjustarGrilla()
        {
            dataGridTurnos.Columns["MedicoEfector"].HeaderText = "Médico Efector";
            dataGridTurnos.Columns["FechaTurno"].HeaderText = "Horario";
            dataGridTurnos.Columns["FechaTurno"].DefaultCellStyle.Format = "HH:mm";

            dataGridTurnos.Columns["Id"].Visible = false;
            dataGridTurnos.Columns["MedicoEfectorId"].Visible = false;
            dataGridTurnos.Columns["PacienteId"].Visible = false;
            dataGridTurnos.Columns["PracticaId"].Visible = false;
            dataGridTurnos.Columns["Coseguro"].Visible = false;
            dataGridTurnos.Columns["FormaPago"].Visible = false;
            dataGridTurnos.Columns["Eliminado"].Visible = false;
            dataGridTurnos.Columns["Atendido"].Visible = false;

            //colorear de verde los turnos atendidos
            foreach (DataGridViewRow fila in dataGridTurnos.Rows)
            {
                Turno turno = (Turno)fila.DataBoundItem;
                if (turno.Atendido)
                {
                    fila.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
            }
        }

        private void cboMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = CargarGrilla();
        }

        private void dtpFechaTurno_ValueChanged(object sender, EventArgs e)
        {
            _ = CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            turnoSeleccionado = (Turno)bsTurnos.Current;
            var confirmacion = MessageBox.Show("¿Estás seguro de que deseas cancelar este turno?",
                                                 "Confirmar cancelación",
                                                 MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    await turnoService.DeleteAsync(turnoSeleccionado.Id);
                    MessageBox.Show("Turno cancelado correctamente");
                    turnoSeleccionado = null;
                    await CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cancelar el turno: " + ex.Message);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            turnoSeleccionado = (Turno)bsTurnos.Current;
            panelAtenderTurno.Visible = true;
            txtPacienteAtendido.Text = turnoSeleccionado.Paciente.NombreCompleto;
            cboFormaPago.DataSource = Enum.GetValues(typeof(FormaPagoEnum));
            cboFormaPago.SelectedIndex = -1;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtCoseguro.Text))
            {
                errorProvider.SetError(txtCoseguro, "El coseguro es obligatorio.");
                return;
            }
            if (cboFormaPago.SelectedIndex == -1)
            {
                errorProvider.SetError(cboFormaPago, "Debes asignar una forma de pago.");
            }

            try
            {
                turnoSeleccionado.Coseguro = decimal.Parse(txtCoseguro.Text);
                turnoSeleccionado.FormaPago = (FormaPagoEnum)cboFormaPago?.SelectedItem;
                turnoSeleccionado.Atendido = true;

                await turnoService.UpdateAsync(turnoSeleccionado);
                MessageBox.Show("El turno ha sido atendido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await CargarGrilla();
                panelAtenderTurno.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al atender el turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelAtenderTurno.Visible = false;
            txtPacienteAtendido.Clear();
            txtCoseguro.Text = string.Empty;
            cboFormaPago.SelectedIndex = -1;
        }
    }
}
