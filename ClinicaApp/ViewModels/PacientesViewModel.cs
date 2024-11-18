using ClinicaApp.Class;
using ClinicaServices.Models;
using ClinicaServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.ViewModels
{
    public class PacientesViewModel : ObjectNotification
    {
        GenericService<Paciente> pacienteService = new GenericService<Paciente>();

        private string filtroPacientes;
        public string FiltroPacientes
        {
            get { return filtroPacientes; }
            set
            {
                filtroPacientes = value;
                OnPropertyChanged();
                FiltrarPacientes();
            }
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Paciente> pacientes;

        public ObservableCollection<Paciente> Pacientes
        {
            get { return pacientes; }
            set
            {
                pacientes = value;
                OnPropertyChanged();
            }
        }

        private List<Paciente>? listaPacientesAFiltrar;

        private Paciente pacienteSeleccionado;
        public Paciente PacienteSeleccionado
        {
            get { return pacienteSeleccionado; }
            set
            {
                pacienteSeleccionado = value;
                OnPropertyChanged();
                EditarPacienteCommand.ChangeCanExecute();
            }
        }

        public Command ObtenerPacientesCommand { get; }
        public Command FiltrarPacientesCommand { get; }
        public Command AgregarPacienteCommand { get; }
        public Command EditarPacienteCommand { get; }

        public PacientesViewModel()
        {
            ObtenerPacientesCommand = new Command(async () => await ObtenerPacientes());
            FiltrarPacientesCommand = new Command(async () => await FiltrarPacientes());
            AgregarPacienteCommand = new Command(async () => await AgregarPaciente());
            EditarPacienteCommand = new Command(async (obj) => await EditarPaciente(), HabilitarEdicion);
            ObtenerPacientes();
        }

        private bool HabilitarEdicion(object arg)
        {
            return PacienteSeleccionado != null;
        }

        private async Task EditarPaciente()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "PacienteAEditar", PacienteSeleccionado }
            };
            await Shell.Current.GoToAsync($"//AgregarEditarPaciente", navigationParameter);
        }

        private async Task AgregarPaciente()
        {
            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "PacienteAEditar", null }
            };
            await Shell.Current.GoToAsync($"//AgregarEditarPaciente", navigationParameter);
        }

        private async Task FiltrarPacientes()
        {
            var pacientesFiltrados = listaPacientesAFiltrar.Where(p => p.NombreCompleto.ToLower().Contains(filtroPacientes.ToLower())).ToList();
            Pacientes = new ObservableCollection<Paciente>(pacientesFiltrados);
        }

        public async Task ObtenerPacientes()
        {
            FiltroPacientes = string.Empty;
            IsRefreshing = true;
            listaPacientesAFiltrar = await pacienteService.GetAllAsync();
            Pacientes = new ObservableCollection<Paciente>(listaPacientesAFiltrar);
            IsRefreshing = false;
        }
    }
}