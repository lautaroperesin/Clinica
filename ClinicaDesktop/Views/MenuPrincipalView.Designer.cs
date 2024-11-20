namespace ClinicaDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuPrincipal = new FontAwesome.Sharp.IconMenuItem();
            iconMenuPacientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuMedicos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuTurnos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuPracticas = new FontAwesome.Sharp.IconMenuItem();
            iconMenuMutuales = new FontAwesome.Sharp.IconMenuItem();
            iconMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            iconMenuCaja = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightBlue;
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuPrincipal, iconMenuPacientes, iconMenuMedicos, iconMenuTurnos, iconMenuPracticas, iconMenuMutuales, iconMenuLocalidades, iconMenuCaja });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuPrincipal
            // 
            iconMenuPrincipal.Font = new Font("Segoe UI", 10F);
            iconMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconMenuPrincipal.IconColor = Color.Black;
            iconMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuPrincipal.IconSize = 25;
            iconMenuPrincipal.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuPrincipal.Name = "iconMenuPrincipal";
            iconMenuPrincipal.Size = new Size(97, 29);
            iconMenuPrincipal.Text = "Principal";
            iconMenuPrincipal.Click += iconMenuPrincipal_Click;
            // 
            // iconMenuPacientes
            // 
            iconMenuPacientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconMenuPacientes.IconColor = Color.Black;
            iconMenuPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuPacientes.IconSize = 25;
            iconMenuPacientes.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuPacientes.Name = "iconMenuPacientes";
            iconMenuPacientes.Size = new Size(111, 29);
            iconMenuPacientes.Text = "Pacientes";
            iconMenuPacientes.Click += iconMenuPacientes_Click;
            // 
            // iconMenuMedicos
            // 
            iconMenuMedicos.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            iconMenuMedicos.IconColor = Color.Black;
            iconMenuMedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuMedicos.IconSize = 25;
            iconMenuMedicos.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuMedicos.Name = "iconMenuMedicos";
            iconMenuMedicos.Size = new Size(105, 29);
            iconMenuMedicos.Text = "Médicos";
            iconMenuMedicos.Click += iconMenuMedicos_Click;
            // 
            // iconMenuTurnos
            // 
            iconMenuTurnos.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            iconMenuTurnos.IconColor = Color.Black;
            iconMenuTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuTurnos.IconSize = 25;
            iconMenuTurnos.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuTurnos.Name = "iconMenuTurnos";
            iconMenuTurnos.Size = new Size(95, 29);
            iconMenuTurnos.Text = "Turnos";
            iconMenuTurnos.Click += iconMenuTurnos_Click;
            // 
            // iconMenuPracticas
            // 
            iconMenuPracticas.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            iconMenuPracticas.IconColor = Color.Black;
            iconMenuPracticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuPracticas.IconSize = 25;
            iconMenuPracticas.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuPracticas.Name = "iconMenuPracticas";
            iconMenuPracticas.Size = new Size(108, 29);
            iconMenuPracticas.Text = "Prácticas";
            iconMenuPracticas.Click += iconMenuPracticas_Click;
            // 
            // iconMenuMutuales
            // 
            iconMenuMutuales.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            iconMenuMutuales.IconColor = Color.Black;
            iconMenuMutuales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuMutuales.IconSize = 25;
            iconMenuMutuales.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuMutuales.Name = "iconMenuMutuales";
            iconMenuMutuales.Size = new Size(111, 29);
            iconMenuMutuales.Text = "Mutuales";
            iconMenuMutuales.Click += iconMenuMutuales_Click;
            // 
            // iconMenuLocalidades
            // 
            iconMenuLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            iconMenuLocalidades.IconColor = Color.Black;
            iconMenuLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuLocalidades.IconSize = 25;
            iconMenuLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuLocalidades.Name = "iconMenuLocalidades";
            iconMenuLocalidades.Size = new Size(128, 29);
            iconMenuLocalidades.Text = "Localidades";
            iconMenuLocalidades.Click += iconMenuLocalidades_Click;
            // 
            // iconMenuCaja
            // 
            iconMenuCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            iconMenuCaja.IconColor = Color.Black;
            iconMenuCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuCaja.IconSize = 25;
            iconMenuCaja.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuCaja.Name = "iconMenuCaja";
            iconMenuCaja.Size = new Size(77, 29);
            iconMenuCaja.Text = "Caja";
            iconMenuCaja.Click += iconMenuCaja_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(920, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuPacientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuMedicos;
        private FontAwesome.Sharp.IconMenuItem iconMenuTurnos;
        private FontAwesome.Sharp.IconMenuItem iconMenuMutuales;
        private FontAwesome.Sharp.IconMenuItem iconMenuLocalidades;
        private FontAwesome.Sharp.IconMenuItem iconMenuPracticas;
        private FontAwesome.Sharp.IconMenuItem iconMenuCaja;
    }
}
