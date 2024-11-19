namespace ClinicaDesktop.Views
{
    partial class AgregarPacienteView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cboLocalidades = new ComboBox();
            cboMutuales = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(118, 215);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 39;
            label10.Text = "Localidad";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(134, 318);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 38;
            label9.Text = "Mutual";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(115, 284);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 37;
            label8.Text = "Fecha nac.";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(119, 248);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 36;
            label7.Text = "Dirección";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(125, 181);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 35;
            label5.Text = "Teléfono";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(152, 148);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 34;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(126, 115);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 33;
            label3.Text = "Apellido";
            // 
            // cboLocalidades
            // 
            cboLocalidades.Anchor = AnchorStyles.None;
            cboLocalidades.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLocalidades.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboLocalidades.Font = new Font("Segoe UI", 11F);
            cboLocalidades.FormattingEnabled = true;
            cboLocalidades.Location = new Point(203, 208);
            cboLocalidades.Name = "cboLocalidades";
            cboLocalidades.Size = new Size(174, 28);
            cboLocalidades.TabIndex = 4;
            // 
            // cboMutuales
            // 
            cboMutuales.Anchor = AnchorStyles.None;
            cboMutuales.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMutuales.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMutuales.Font = new Font("Segoe UI", 11F);
            cboMutuales.FormattingEnabled = true;
            cboMutuales.Location = new Point(203, 311);
            cboMutuales.Name = "cboMutuales";
            cboMutuales.Size = new Size(174, 28);
            cboMutuales.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.None;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 11F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(203, 278);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(174, 27);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Font = new Font("Segoe UI", 11F);
            txtDireccion.Location = new Point(203, 242);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(174, 27);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(203, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(174, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Font = new Font("Segoe UI", 11F);
            txtDni.Location = new Point(203, 142);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(174, 27);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(203, 108);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(174, 27);
            txtApellido.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(125, 76);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 25;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(203, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(134, 368);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 35);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightBlue;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(259, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 35);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarPacienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(494, 466);
            Controls.Add(btnCancelar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboLocalidades);
            Controls.Add(cboMutuales);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Name = "AgregarPacienteView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboLocalidades;
        private ComboBox cboMutuales;
        private DateTimePicker dtpFechaNacimiento;
        public TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}