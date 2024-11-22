using ClinicaApp.Class;
using ClinicaServices.Enums;
using ClinicaServices.Interfaces;
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
    public class NuevoTurnoViewModel : ObjectNotification
    {
        TurnoService turnoService = new TurnoService();
        PracticaService practicaService = new PracticaService();
        GenericService<Medico> medicoService = new GenericService<Medico>();
        GenericService<Paciente> pacienteService = new GenericService<Paciente>();

        #region Propiedades
        private Paciente pacienteSeleccionado;
        public Paciente PacienteSeleccionado
        {
            get => pacienteSeleccionado;
            set
            {
                pacienteSeleccionado = value;
                OnPropertyChanged();

                if (pacienteSeleccionado != null)
                {
                    PacienteId = pacienteSeleccionado.Id;
                }
            }
        }

        private Medico medicoSeleccionado;
        public Medico MedicoSeleccionado
        {
            get => medicoSeleccionado;
            set
            {
                medicoSeleccionado = value;
                OnPropertyChanged();

                if (medicoSeleccionado != null)
                {
                    MedicoId = medicoSeleccionado.Id;
                }
            }
        }

        private Practica practicaSeleccionada;
        public Practica PracticaSeleccionada
        {
            get => practicaSeleccionada;
            set
            {
                practicaSeleccionada = value;
                OnPropertyChanged();

                if (practicaSeleccionada != null)
                {
                    PracticaId = practicaSeleccionada.Id;
                }
            }
        }

        private string nombreCompleto;
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set 
            {
                nombreCompleto = value;
                OnPropertyChanged();
            }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        private int? pacienteId;
        public int? PacienteId
        {
            get => pacienteId;
            set 
            {
                pacienteId = value;
                OnPropertyChanged();
            }
        }

        private int? medicoId;
        public int? MedicoId
        {
            get => medicoId;
            set
            {
                medicoId = value;
                OnPropertyChanged();
                CargarHorariosDisponibles();
            }
        }

        private int? practicaId;
        public int? PracticaId
        {
            get => practicaId;
            set 
            {
                practicaId = value;
                OnPropertyChanged();
            }
        }

        private TecnicaEnum? tecnica;
        public TecnicaEnum? Tecnica
        {
            get => tecnica;
            set
            {
                tecnica = value;
                OnPropertyChanged();
                CargarPracticasPorTecnica();
            }
        }

        private DateTime fechaTurno = DateTime.Today;
        public DateTime FechaTurno
        {
            get => fechaTurno;
            set
            {
                fechaTurno = value;
                OnPropertyChanged();
                CargarHorariosDisponibles();
            }
        }

        private DateTime? horarioSeleccionado;
        public DateTime? HorarioSeleccionado
        {
            get => horarioSeleccionado;
            set 
            {
                horarioSeleccionado = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Paciente> listaPacientes;
        public ObservableCollection<Paciente> ListaPacientes
        {
            get => listaPacientes;
            set
            {
                listaPacientes = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Medico> listaMedicos;
        public ObservableCollection<Medico> ListaMedicos
        {
            get => listaMedicos;
            set
            {
                listaMedicos = value;
                OnPropertyChanged();
            }
        }

        public List<TecnicaEnum> Tecnicas => Enum.GetValues(typeof(TecnicaEnum)).Cast<TecnicaEnum>().ToList();

        private ObservableCollection<Practica> listaPracticas;
        public ObservableCollection<Practica> ListaPracticas
        {
            get => listaPracticas;
            set
            {
                listaPracticas = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<DateTime> horariosDisponibles;
        public ObservableCollection<DateTime> HorariosDisponibles
        {
            get => horariosDisponibles;
            set
            {
                horariosDisponibles = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public Command CargarPacientesCommand { get; }
        public Command GuardarTurnoCommand { get; }
        public Command VolverCommand { get; }

        public NuevoTurnoViewModel()
        {
            CargarPacientesCommand = new Command(async () => await CargarListasAsync());
            GuardarTurnoCommand = new Command(async () => await GuardarTurno());
            VolverCommand = new Command(async () => await VolverAInicio());
            CargarListasAsync();
        }

        private async void CargarHorariosDisponibles()
        {
            if (MedicoId != null && FechaTurno != default)
            {
                var horarios = await turnoService.GetHorariosDisponibles(MedicoSeleccionado, FechaTurno);
                HorariosDisponibles = new ObservableCollection<DateTime>(horarios);
            }
        }

        public async Task GuardarTurno()
        {
            if (PacienteId == null || MedicoId == null || PracticaId == null || HorarioSeleccionado == null || Tecnica == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, complete todos los campos", "OK");
                return;
            }

            var nuevoTurno = new Turno
            {
                PacienteId = PacienteId,
                MedicoEfectorId = MedicoId,
                PracticaId = PracticaId,
                Tecnica = Tecnica,
                FechaTurno = HorarioSeleccionado
            };

            await turnoService.AddAsync(nuevoTurno);
            await Application.Current.MainPage.DisplayAlert("Éxito", "El turno fue registrado correctamente", "OK");
            await VolverAInicio();
        }

        private async Task CargarListasAsync()
        {
            try
            {
                var pacientes = await pacienteService.GetAllAsync();
                ListaPacientes = new ObservableCollection<Paciente>(pacientes);

                var medicos = await medicoService.GetAllAsync();
                ListaMedicos = new ObservableCollection<Medico>(medicos);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"No se pudieron cargar los datos: {ex.Message}", "OK");
            }
        }

        private async void CargarPracticasPorTecnica()
        {
            if (Tecnica != null)
            {
                var practicas = await practicaService.GetPracticasPorTecnicaAsync((TecnicaEnum)Tecnica);
                ListaPracticas = new ObservableCollection<Practica>(practicas);
            }
        }

        private async Task VolverAInicio()
        {
            PacienteSeleccionado = null;
            MedicoSeleccionado = null;
            PracticaSeleccionada = null;
            Tecnica = null;
            FechaTurno = DateTime.Today;
            HorarioSeleccionado = null;

            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
