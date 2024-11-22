using ClinicaApp.Class;
using ClinicaServices.Models;
using ClinicaServices.Services;
using System.Collections.ObjectModel;

namespace ClinicaApp.ViewModels
{
    public class AgregarEditarPacienteViewModel : ObjectNotification
    {
        GenericService<Paciente> pacienteService = new GenericService<Paciente>();
        private readonly GenericService<Mutual> mutualService = new GenericService<Mutual>();
        private readonly GenericService<Localidad> localidadService = new GenericService<Localidad>();

        #region Propiedades
        private Paciente editarPaciente;
        public Paciente EditarPaciente
        {
            get { return editarPaciente; }
            set
            {
                editarPaciente = value;
                OnPropertyChanged();
                // Si las listas ya están cargadas, llama a SettingData.
                if (ListaMutuales != null && ListaMutuales.Any() && ListaLocalidades != null && ListaLocalidades.Any())
                {
                    SettingData();
                }
            }
        }

        private void SettingData()
        {
            if (editarPaciente != null)
            {
                Nombre = editarPaciente.Nombre;
                Apellido = editarPaciente.Apellido;
                Direccion = editarPaciente.Direccion;
                Telefono = editarPaciente.Telefono;
                FechaNacimiento = (DateTime)editarPaciente.FechaNacimiento;
                Documento = editarPaciente.Documento;
                MutualId = editarPaciente.MutualId;
                LocalidadId = (int)editarPaciente.LocalidadId;

                MutualSeleccionada = ListaMutuales?.FirstOrDefault(m => m.Id == MutualId);
                LocalidadSeleccionada = ListaLocalidades?.FirstOrDefault(l => l.Id == LocalidadId);
            }
            else
            {
                Nombre = string.Empty;
                Apellido = string.Empty;
                Direccion = string.Empty;
                Telefono = string.Empty;
                Email = string.Empty;
                FechaNacimiento = DateTime.Now;
                Documento = string.Empty;
                MutualId = 0;
                LocalidadId = 0;
                MutualSeleccionada = null;
                LocalidadSeleccionada = null;
                return;
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

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                OnPropertyChanged();
            }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set
            {
                direccion = value;
                OnPropertyChanged();
            }
        }

        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value;
                OnPropertyChanged();
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set
            {
                fechaNacimiento = value;
                OnPropertyChanged();
            }
        }

        private string documento;
        public string Documento
        {
            get { return documento; }
            set
            {
                documento = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Mutual> listaMutuales;
        public ObservableCollection<Mutual> ListaMutuales
        {
            get => listaMutuales;
            set
            {
                listaMutuales = value;
                OnPropertyChanged();
            }
        }

        private Mutual mutualSeleccionada;
        public Mutual MutualSeleccionada
        {
            get { return mutualSeleccionada; }
            set
            {
                mutualSeleccionada = value;
                OnPropertyChanged();

                // Asignar el ID de la mutual seleccionada a la propiedad MutualId
                if (mutualSeleccionada != null)
                {
                    MutualId = mutualSeleccionada.Id;
                }
            }
        }

        private int mutualId;
        public int MutualId
        {
            get { return mutualId; }
            set
            {
                mutualId = value;
                OnPropertyChanged();
            }
        }

        private int localidadId;
        public int LocalidadId
        {
            get { return localidadId; }
            set
            {
                localidadId = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Localidad> listaLocalidades;
        public ObservableCollection<Localidad> ListaLocalidades
        {
            get => listaLocalidades;
            set
            {
                listaLocalidades = value;
                OnPropertyChanged();
            }
        }

        private Localidad localidadSeleccionada;
        public Localidad LocalidadSeleccionada
        {
            get { return localidadSeleccionada; }
            set
            {
                localidadSeleccionada = value;
                OnPropertyChanged();

                if (localidadSeleccionada != null)
                {
                    LocalidadId = localidadSeleccionada.Id;
                }
            }
        }
        #endregion

        #region Commands
        public Command GuardarPacienteCommand { get; }
        public Command VolverCommand { get; }
        #endregion

        public AgregarEditarPacienteViewModel()
        {
            GuardarPacienteCommand = new Command(async () => await GuardarPaciente());
            VolverCommand = new Command(async () => await VolverALista());
            CargarListasAsync();
        }

        private async Task CargarListasAsync()
        {
            try
            {
                // Cargar mutuales
                var mutuales = await mutualService.GetAllAsync();
                ListaMutuales = new ObservableCollection<Mutual>(mutuales);

                // Cargar localidades
                var localidades = await localidadService.GetAllAsync();
                ListaLocalidades = new ObservableCollection<Localidad>(localidades);

                if (EditarPaciente != null)
                {
                    SettingData();
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"No se pudieron cargar los datos: {ex.Message}", "OK");
            }
        }

        private async Task GuardarPaciente()
        {
            if (EditarPaciente != null)
            {
                editarPaciente.Nombre = Nombre;
                editarPaciente.Apellido = Apellido;
                editarPaciente.Direccion = Direccion;
                editarPaciente.Telefono = Telefono;
                editarPaciente.FechaNacimiento = FechaNacimiento;
                editarPaciente.Documento = Documento;
                editarPaciente.MutualId = MutualSeleccionada.Id;
                editarPaciente.LocalidadId = LocalidadSeleccionada.Id;

                await pacienteService.UpdateAsync(editarPaciente);
            }
            else
            {
                var paciente = new Paciente()
                {
                    Nombre = Nombre,
                    Apellido = Apellido,
                    Direccion = Direccion,
                    Telefono = Telefono,
                    FechaNacimiento = FechaNacimiento,
                    Documento = Documento,
                    MutualId = MutualId,
                    LocalidadId = LocalidadId,
                };
                await pacienteService.AddAsync(paciente);
            }
            await VolverALista();
        }

        private async Task VolverALista()
        {
            EditarPaciente = null;
            await Shell.Current.GoToAsync("//ListaPacientes");
        }
    }
}
