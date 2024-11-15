using ClinicaApp.ViewModels;
using ClinicaApp.Views;

namespace ClinicaApp
{
    public partial class ClinicaShell : Shell
    {
        public ClinicaShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false; ;  // Oculta el menú lateral
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("Registrarse", typeof(RegistrarseView));
        }

        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as ClinicaShellViewModel;
            viewmodel.IsUserLogout = false;
        }
        public void DisableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
    }
}