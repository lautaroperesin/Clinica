using ClinicaApp.ViewModels;

namespace ClinicaApp.Views;

public partial class NuevoTurnoView : ContentPage
{
	public NuevoTurnoView()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is NuevoTurnoViewModel viewModel)
        {
            viewModel.CargarPacientesCommand.Execute(null);
        }
    }
}