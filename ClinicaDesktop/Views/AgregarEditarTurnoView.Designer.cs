namespace ClinicaDesktop.Views
{
    partial class AgregarEditarTurnoView
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
            btnCancelar = new Button();
            label9 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            label1 = new Label();
            label4 = new Label();
            dtpFechaTurno = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            cboTecnicas = new ComboBox();
            cboPracticas = new ComboBox();
            cboMedicos = new ComboBox();
            cboPacientes = new ComboBox();
            cboHorarios = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightBlue;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(211, 304);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 34);
            btnCancelar.TabIndex = 61;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(65, 221);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 60;
            label9.Text = "Técnica";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(63, 186);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 57;
            label2.Text = "Médico";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(91, 304);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 34);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(63, 82);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 63;
            label1.Text = "Paciente";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(60, 256);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 66;
            label4.Text = "Práctica";
            // 
            // dtpFechaTurno
            // 
            dtpFechaTurno.Anchor = AnchorStyles.None;
            dtpFechaTurno.Font = new Font("Segoe UI", 12F);
            dtpFechaTurno.Format = DateTimePickerFormat.Short;
            dtpFechaTurno.Location = new Point(141, 108);
            dtpFechaTurno.Name = "dtpFechaTurno";
            dtpFechaTurno.Size = new Size(184, 29);
            dtpFechaTurno.TabIndex = 67;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(74, 114);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 68;
            label6.Text = "Fecha";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(57, 83);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 69;
            label7.Text = "Paciente";
            // 
            // cboTecnicas
            // 
            cboTecnicas.Anchor = AnchorStyles.None;
            cboTecnicas.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTecnicas.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTecnicas.Font = new Font("Segoe UI", 12F);
            cboTecnicas.FormattingEnabled = true;
            cboTecnicas.Location = new Point(141, 213);
            cboTecnicas.Name = "cboTecnicas";
            cboTecnicas.Size = new Size(184, 29);
            cboTecnicas.TabIndex = 70;
            // 
            // cboPracticas
            // 
            cboPracticas.Anchor = AnchorStyles.None;
            cboPracticas.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPracticas.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboPracticas.Font = new Font("Segoe UI", 12F);
            cboPracticas.FormattingEnabled = true;
            cboPracticas.Location = new Point(141, 248);
            cboPracticas.Name = "cboPracticas";
            cboPracticas.Size = new Size(184, 29);
            cboPracticas.TabIndex = 71;
            // 
            // cboMedicos
            // 
            cboMedicos.Anchor = AnchorStyles.None;
            cboMedicos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMedicos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMedicos.Font = new Font("Segoe UI", 12F);
            cboMedicos.FormattingEnabled = true;
            cboMedicos.Location = new Point(141, 178);
            cboMedicos.Name = "cboMedicos";
            cboMedicos.Size = new Size(184, 29);
            cboMedicos.TabIndex = 72;
            // 
            // cboPacientes
            // 
            cboPacientes.Anchor = AnchorStyles.None;
            cboPacientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboPacientes.Font = new Font("Segoe UI", 12F);
            cboPacientes.FormattingEnabled = true;
            cboPacientes.Location = new Point(141, 73);
            cboPacientes.Name = "cboPacientes";
            cboPacientes.Size = new Size(184, 29);
            cboPacientes.TabIndex = 73;
            // 
            // cboHorarios
            // 
            cboHorarios.Anchor = AnchorStyles.None;
            cboHorarios.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboHorarios.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboHorarios.Font = new Font("Segoe UI", 12F);
            cboHorarios.FormattingEnabled = true;
            cboHorarios.Location = new Point(141, 143);
            cboHorarios.Name = "cboHorarios";
            cboHorarios.Size = new Size(184, 29);
            cboHorarios.TabIndex = 75;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(61, 151);
            label8.Name = "label8";
            label8.Size = new Size(63, 21);
            label8.TabIndex = 74;
            label8.Text = "Horario";
            // 
            // AgregarEditarTurnoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(389, 411);
            Controls.Add(cboHorarios);
            Controls.Add(label8);
            Controls.Add(cboPacientes);
            Controls.Add(cboMedicos);
            Controls.Add(cboPracticas);
            Controls.Add(cboTecnicas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpFechaTurno);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Name = "AgregarEditarTurnoView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/Editar Turno";
            Load += AgregarEditarTurnoView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label9;
        private Label label5;
        private Label label3;
        private ComboBox cboTecnicas;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private Label label2;
        private Button btnGuardar;
        private ComboBox cboPracticas;
        private Label label1;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private DateTimePicker dtpFechaTurno;
        private Label label6;
        private Label label7;
        private ComboBox cboMedicos;
        private ComboBox cboPacientes;
        private ComboBox cboHorarios;
        private Label label8;
    }
}