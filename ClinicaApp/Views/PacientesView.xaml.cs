using ClinicaApp.ViewModels;

namespace ClinicaApp.Views;

public partial class PacientesView : ContentPage
{
	public PacientesView()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as PacientesViewModel;

        viewmodel.ObtenerPacientes();
        viewmodel.PacienteSeleccionado = null;
    }
}