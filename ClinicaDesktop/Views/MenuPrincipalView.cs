using ClinicaDesktop.ViewReports;
using ClinicaDesktop.Views;

namespace ClinicaDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void iconMenuPacientes_Click(object sender, EventArgs e)
        {
            PacientesView pacientesView = new PacientesView();
            pacientesView.ShowDialog();
        }

        private void iconMenuMedicos_Click(object sender, EventArgs e)
        {
            MedicosView medicosView = new MedicosView();
            medicosView.ShowDialog();
        }

        private void iconMenuTurnos_Click(object sender, EventArgs e)
        {
            TurnosView turnosView = new TurnosView();
            turnosView.ShowDialog();
        }

        private void iconMenuMutuales_Click(object sender, EventArgs e)
        {
            MutualesView mutualesView = new MutualesView();
            mutualesView.ShowDialog();
        }

        private void iconMenuLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesView localidadesView = new LocalidadesView();
            localidadesView.ShowDialog();
        }

        private void iconMenuPracticas_Click(object sender, EventArgs e)
        {
            PracticasView practicasView = new PracticasView();
            practicasView.ShowDialog();
        }

        private void iconMenuCaja_Click(object sender, EventArgs e)
        {
            CajaView cajaView = new CajaView();
            cajaView.ShowDialog();
        }

        private void iconMenuListadoPacientes_Click(object sender, EventArgs e)
        {
            PacientesViewReport pacientesViewReport = new PacientesViewReport();
            pacientesViewReport.ShowDialog();
        }

        private void iconMenuSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que quiere cerrar el sistema?",
                                       "Confirmar cierre",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconToolHistoricoTurnos_Click(object sender, EventArgs e)
        {
            HistoricoTurnosView historicoTurnosView = new HistoricoTurnosView();
            historicoTurnosView.ShowDialog();
        }
    }
}
