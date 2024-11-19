using ClinicaServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDesktop.Views
{
    public partial class AgregarEditarTurnoView : Form
    {
        Turno? turno = new Turno();
        public AgregarEditarTurnoView()
        {
            InitializeComponent();
        }

        public AgregarEditarTurnoView(Turno turno)
        {
            InitializeComponent();
            this.turno = turno;
            CargarDatos();
        }

        private void CargarDatos()
        {
            
        }

    }
}
