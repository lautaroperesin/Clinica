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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalView));
            menuStrip1 = new MenuStrip();
            iconMenuPrincipal = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuCaja = new FontAwesome.Sharp.IconMenuItem();
            iconMenuPagosPendientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuGestionTurnos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuTurnos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuHistoricoTurnos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuAdministracion = new FontAwesome.Sharp.IconMenuItem();
            iconMenuPacientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuMedicos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuPracticas = new FontAwesome.Sharp.IconMenuItem();
            iconMenuMutuales = new FontAwesome.Sharp.IconMenuItem();
            iconMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            iconMenuListados = new FontAwesome.Sharp.IconMenuItem();
            iconMenuListadoPacientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuSalir = new FontAwesome.Sharp.IconMenuItem();
            pictureBoxLogoIsp = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoIsp).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightBlue;
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuPrincipal, iconMenuItem2, iconMenuGestionTurnos, iconMenuAdministracion, iconMenuListados, iconMenuSalir });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1294, 53);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuPrincipal
            // 
            iconMenuPrincipal.Font = new Font("Segoe UI", 10F);
            iconMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconMenuPrincipal.IconColor = Color.Black;
            iconMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuPrincipal.IconSize = 45;
            iconMenuPrincipal.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuPrincipal.Name = "iconMenuPrincipal";
            iconMenuPrincipal.Size = new Size(117, 49);
            iconMenuPrincipal.Text = "Principal";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { iconMenuCaja, iconMenuPagosPendientes });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.IconSize = 45;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(127, 49);
            iconMenuItem2.Text = "Finanzas";
            // 
            // iconMenuCaja
            // 
            iconMenuCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            iconMenuCaja.IconColor = Color.Black;
            iconMenuCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuCaja.IconSize = 30;
            iconMenuCaja.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuCaja.Name = "iconMenuCaja";
            iconMenuCaja.Size = new Size(215, 36);
            iconMenuCaja.Text = "Caja";
            iconMenuCaja.Click += iconMenuCaja_Click;
            // 
            // iconMenuPagosPendientes
            // 
            iconMenuPagosPendientes.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            iconMenuPagosPendientes.IconColor = Color.Black;
            iconMenuPagosPendientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuPagosPendientes.IconSize = 30;
            iconMenuPagosPendientes.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuPagosPendientes.Name = "iconMenuPagosPendientes";
            iconMenuPagosPendientes.Size = new Size(215, 36);
            iconMenuPagosPendientes.Text = "Pagos pendientes";
            iconMenuPagosPendientes.Click += iconMenuPagosPendientes_Click;
            // 
            // iconMenuGestionTurnos
            // 
            iconMenuGestionTurnos.DropDownItems.AddRange(new ToolStripItem[] { iconMenuTurnos, iconMenuHistoricoTurnos });
            iconMenuGestionTurnos.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            iconMenuGestionTurnos.IconColor = Color.Black;
            iconMenuGestionTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuGestionTurnos.IconSize = 45;
            iconMenuGestionTurnos.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuGestionTurnos.Name = "iconMenuGestionTurnos";
            iconMenuGestionTurnos.Size = new Size(190, 49);
            iconMenuGestionTurnos.Text = "Gestión de turnos";
            // 
            // iconMenuTurnos
            // 
            iconMenuTurnos.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            iconMenuTurnos.IconColor = Color.Black;
            iconMenuTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuTurnos.IconSize = 30;
            iconMenuTurnos.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuTurnos.Name = "iconMenuTurnos";
            iconMenuTurnos.Size = new Size(194, 36);
            iconMenuTurnos.Text = "Ver turnos";
            iconMenuTurnos.Click += iconMenuTurnos_Click;
            // 
            // iconMenuHistoricoTurnos
            // 
            iconMenuHistoricoTurnos.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            iconMenuHistoricoTurnos.IconColor = Color.Black;
            iconMenuHistoricoTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuHistoricoTurnos.IconSize = 30;
            iconMenuHistoricoTurnos.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuHistoricoTurnos.Name = "iconMenuHistoricoTurnos";
            iconMenuHistoricoTurnos.Size = new Size(194, 36);
            iconMenuHistoricoTurnos.Text = "Histórico";
            iconMenuHistoricoTurnos.Click += iconMenuHistoricoTurnos_Click;
            // 
            // iconMenuAdministracion
            // 
            iconMenuAdministracion.DropDownItems.AddRange(new ToolStripItem[] { iconMenuPacientes, iconMenuMedicos, iconMenuPracticas, iconMenuMutuales, iconMenuLocalidades });
            iconMenuAdministracion.IconChar = FontAwesome.Sharp.IconChar.LaptopMedical;
            iconMenuAdministracion.IconColor = Color.Black;
            iconMenuAdministracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuAdministracion.IconSize = 45;
            iconMenuAdministracion.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuAdministracion.Name = "iconMenuAdministracion";
            iconMenuAdministracion.Size = new Size(172, 49);
            iconMenuAdministracion.Text = "Administración";
            // 
            // iconMenuPacientes
            // 
            iconMenuPacientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconMenuPacientes.IconColor = Color.Black;
            iconMenuPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuPacientes.IconSize = 30;
            iconMenuPacientes.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuPacientes.Name = "iconMenuPacientes";
            iconMenuPacientes.Size = new Size(194, 36);
            iconMenuPacientes.Text = "Pacientes";
            iconMenuPacientes.Click += iconMenuPacientes_Click;
            // 
            // iconMenuMedicos
            // 
            iconMenuMedicos.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            iconMenuMedicos.IconColor = Color.Black;
            iconMenuMedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuMedicos.IconSize = 30;
            iconMenuMedicos.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuMedicos.Name = "iconMenuMedicos";
            iconMenuMedicos.Size = new Size(194, 36);
            iconMenuMedicos.Text = "Médicos";
            iconMenuMedicos.Click += iconMenuMedicos_Click;
            // 
            // iconMenuPracticas
            // 
            iconMenuPracticas.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            iconMenuPracticas.IconColor = Color.Black;
            iconMenuPracticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuPracticas.IconSize = 30;
            iconMenuPracticas.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuPracticas.Name = "iconMenuPracticas";
            iconMenuPracticas.Size = new Size(194, 36);
            iconMenuPracticas.Text = "Prácticas";
            iconMenuPracticas.Click += iconMenuPracticas_Click;
            // 
            // iconMenuMutuales
            // 
            iconMenuMutuales.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            iconMenuMutuales.IconColor = Color.Black;
            iconMenuMutuales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuMutuales.IconSize = 30;
            iconMenuMutuales.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuMutuales.Name = "iconMenuMutuales";
            iconMenuMutuales.Size = new Size(194, 36);
            iconMenuMutuales.Text = "Mutuales";
            iconMenuMutuales.Click += iconMenuMutuales_Click;
            // 
            // iconMenuLocalidades
            // 
            iconMenuLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            iconMenuLocalidades.IconColor = Color.Black;
            iconMenuLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuLocalidades.IconSize = 30;
            iconMenuLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuLocalidades.Name = "iconMenuLocalidades";
            iconMenuLocalidades.Size = new Size(194, 36);
            iconMenuLocalidades.Text = "Localidades";
            iconMenuLocalidades.Click += iconMenuLocalidades_Click;
            // 
            // iconMenuListados
            // 
            iconMenuListados.DropDownItems.AddRange(new ToolStripItem[] { iconMenuListadoPacientes });
            iconMenuListados.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconMenuListados.IconColor = Color.Black;
            iconMenuListados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuListados.IconSize = 45;
            iconMenuListados.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuListados.Name = "iconMenuListados";
            iconMenuListados.Size = new Size(124, 49);
            iconMenuListados.Text = "Listados";
            // 
            // iconMenuListadoPacientes
            // 
            iconMenuListadoPacientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconMenuListadoPacientes.IconColor = Color.Black;
            iconMenuListadoPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuListadoPacientes.IconSize = 30;
            iconMenuListadoPacientes.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuListadoPacientes.Name = "iconMenuListadoPacientes";
            iconMenuListadoPacientes.Size = new Size(194, 36);
            iconMenuListadoPacientes.Text = "Pacientes";
            iconMenuListadoPacientes.Click += iconMenuListadoPacientes_Click;
            // 
            // iconMenuSalir
            // 
            iconMenuSalir.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconMenuSalir.IconColor = Color.Black;
            iconMenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuSalir.IconSize = 45;
            iconMenuSalir.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuSalir.Name = "iconMenuSalir";
            iconMenuSalir.Size = new Size(98, 49);
            iconMenuSalir.Text = "Salir";
            iconMenuSalir.Click += iconMenuSalir_Click;
            // 
            // pictureBoxLogoIsp
            // 
            pictureBoxLogoIsp.Anchor = AnchorStyles.None;
            pictureBoxLogoIsp.Image = (Image)resources.GetObject("pictureBoxLogoIsp.Image");
            pictureBoxLogoIsp.Location = new Point(494, 148);
            pictureBoxLogoIsp.Name = "pictureBoxLogoIsp";
            pictureBoxLogoIsp.Size = new Size(332, 336);
            pictureBoxLogoIsp.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogoIsp.TabIndex = 1;
            pictureBoxLogoIsp.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 33F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 581);
            label1.Name = "label1";
            label1.Size = new Size(331, 60);
            label1.TabIndex = 2;
            label1.Text = "Programación I";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 33F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 502);
            label2.Name = "label2";
            label2.Size = new Size(962, 60);
            label2.TabIndex = 3;
            label2.Text = "Tecnicatura Superior en Desarrollo de Software";
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1294, 737);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxLogoIsp);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoIsp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuPacientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuMedicos;
        private FontAwesome.Sharp.IconMenuItem iconMenuLocalidades;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuCaja;
        private FontAwesome.Sharp.IconMenuItem iconMenuPagosPendientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuPracticas;
        private FontAwesome.Sharp.IconMenuItem iconMenuListados;
        private FontAwesome.Sharp.IconMenuItem iconMenuListadoPacientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuSalir;
        private FontAwesome.Sharp.IconMenuItem iconMenuGestionTurnos;
        private FontAwesome.Sharp.IconMenuItem iconMenuTurnos;
        private FontAwesome.Sharp.IconMenuItem iconMenuHistoricoTurnos;
        private FontAwesome.Sharp.IconMenuItem iconMenuAdministracion;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuMutuales;
        private PictureBox pictureBoxLogoIsp;
        private Label label1;
        private Label label2;
    }
}
