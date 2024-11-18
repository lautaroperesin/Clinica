using ClinicaApp.ViewModels;
using ClinicaServices.Models;

namespace ClinicaApp.Views;

[QueryProperty(nameof(Paciente), "PacienteAEditar")]
public partial class AgregarEditarPacienteView : ContentPage
{
    public Paciente Paciente
    {
        set
        {
            var paciente = value;
            var viewModel = this.BindingContext as AgregarEditarPacienteViewModel;
            viewModel.EditarPaciente = paciente;
        }
    }

    public AgregarEditarPacienteView()
	{
		InitializeComponent();
	}

    public AgregarEditarPacienteView(Paciente pacienteAEditar)
    {
        InitializeComponent();
        var viewModel = this.BindingContext as AgregarEditarPacienteViewModel;
        viewModel.EditarPaciente = pacienteAEditar;
    }
}