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
    }
}
