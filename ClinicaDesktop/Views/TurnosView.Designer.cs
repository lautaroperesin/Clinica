namespace ClinicaDesktop.Views
{
    partial class TurnosView
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cboMedicos = new ComboBox();
            label1 = new Label();
            dtpFechaTurno = new DateTimePicker();
            label2 = new Label();
            lblNoTurnos = new Label();
            dataGridTurnos = new DataGridView();
            panel1 = new Panel();
            btnVolver = new Button();
            label3 = new Label();
            btnAtender = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            lblSelecMedico = new Label();
            panelAtenderTurno = new Panel();
            label6 = new Label();
            cboFormaPago = new ComboBox();
            txtCoseguro = new TextBox();
            label5 = new Label();
            txtPacienteAtendido = new TextBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridTurnos).BeginInit();
            panel1.SuspendLayout();
            panelAtenderTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // cboMedicos
            // 
            cboMedicos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMedicos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMedicos.Font = new Font("Segoe UI", 12F);
            cboMedicos.FormattingEnabled = true;
            cboMedicos.Location = new Point(215, 58);
            cboMedicos.Name = "cboMedicos";
            cboMedicos.Size = new Size(219, 29);
            cboMedicos.TabIndex = 1;
            cboMedicos.SelectedIndexChanged += cboMedicos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 40);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione un médico";
            // 
            // dtpFechaTurno
            // 
            dtpFechaTurno.Font = new Font("Segoe UI", 12F);
            dtpFechaTurno.Format = DateTimePickerFormat.Short;
            dtpFechaTurno.Location = new Point(459, 58);
            dtpFechaTurno.Name = "dtpFechaTurno";
            dtpFechaTurno.Size = new Size(170, 29);
            dtpFechaTurno.TabIndex = 3;
            dtpFechaTurno.ValueChanged += dtpFechaTurno_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 40);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 4;
            label2.Text = "Seleccione una fecha";
            // 
            // lblNoTurnos
            // 
            lblNoTurnos.Anchor = AnchorStyles.None;
            lblNoTurnos.AutoSize = true;
            lblNoTurnos.BackColor = Color.White;
            lblNoTurnos.Font = new Font("Segoe UI", 12F);
            lblNoTurnos.Location = new Point(603, 294);
            lblNoTurnos.Name = "lblNoTurnos";
            lblNoTurnos.Size = new Size(255, 21);
            lblNoTurnos.TabIndex = 28;
            lblNoTurnos.Text = "NO HAY TURNOS PROGRAMADOS";
            lblNoTurnos.Visible = false;
            // 
            // dataGridTurnos
            // 
            dataGridTurnos.AllowUserToAddRows = false;
            dataGridTurnos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTurnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTurnos.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTurnos.Location = new Point(206, 112);
            dataGridTurnos.MultiSelect = false;
            dataGridTurnos.Name = "dataGridTurnos";
            dataGridTurnos.ReadOnly = true;
            dataGridTurnos.RowHeadersVisible = false;
            dataGridTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTurnos.Size = new Size(989, 458);
            dataGridTurnos.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAtender);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 570);
            panel1.TabIndex = 30;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightBlue;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(3, 469);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(197, 35);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(30, 57);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 32;
            label3.Text = "TURNOS";
            // 
            // btnAtender
            // 
            btnAtender.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtender.BackColor = Color.LightBlue;
            btnAtender.Enabled = false;
            btnAtender.Font = new Font("Segoe UI", 12F);
            btnAtender.Location = new Point(3, 305);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(197, 33);
            btnAtender.TabIndex = 31;
            btnAtender.Text = " Atender";
            btnAtender.UseVisualStyleBackColor = false;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightBlue;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(3, 428);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(197, 35);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.LightBlue;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(3, 387);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(197, 35);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.Enabled = false;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(3, 346);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(197, 35);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblSelecMedico
            // 
            lblSelecMedico.Anchor = AnchorStyles.None;
            lblSelecMedico.AutoSize = true;
            lblSelecMedico.BackColor = Color.White;
            lblSelecMedico.Font = new Font("Segoe UI", 12F);
            lblSelecMedico.Location = new Point(603, 327);
            lblSelecMedico.Name = "lblSelecMedico";
            lblSelecMedico.Size = new Size(189, 21);
            lblSelecMedico.TabIndex = 31;
            lblSelecMedico.Text = "SELECCIONE UN MÉDICO";
            // 
            // panelAtenderTurno
            // 
            panelAtenderTurno.BorderStyle = BorderStyle.Fixed3D;
            panelAtenderTurno.Controls.Add(label6);
            panelAtenderTurno.Controls.Add(cboFormaPago);
            panelAtenderTurno.Controls.Add(txtCoseguro);
            panelAtenderTurno.Controls.Add(label5);
            panelAtenderTurno.Controls.Add(txtPacienteAtendido);
            panelAtenderTurno.Controls.Add(label4);
            panelAtenderTurno.Controls.Add(btnCancelar);
            panelAtenderTurno.Controls.Add(btnConfirmar);
            panelAtenderTurno.Location = new Point(340, 192);
            panelAtenderTurno.Name = "panelAtenderTurno";
            panelAtenderTurno.Size = new Size(550, 272);
            panelAtenderTurno.TabIndex = 32;
            panelAtenderTurno.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(31, 147);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 36;
            label6.Text = "Forma de pago";
            // 
            // cboFormaPago
            // 
            cboFormaPago.Font = new Font("Segoe UI", 12F);
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(185, 139);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(284, 29);
            cboFormaPago.TabIndex = 35;
            // 
            // txtCoseguro
            // 
            txtCoseguro.Font = new Font("Segoe UI", 12F);
            txtCoseguro.Location = new Point(184, 81);
            txtCoseguro.Name = "txtCoseguro";
            txtCoseguro.Size = new Size(100, 29);
            txtCoseguro.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(69, 84);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 33;
            label5.Text = "Coseguro";
            // 
            // txtPacienteAtendido
            // 
            txtPacienteAtendido.Enabled = false;
            txtPacienteAtendido.Font = new Font("Segoe UI", 12F);
            txtPacienteAtendido.Location = new Point(184, 23);
            txtPacienteAtendido.Name = "txtPacienteAtendido";
            txtPacienteAtendido.ReadOnly = true;
            txtPacienteAtendido.Size = new Size(285, 29);
            txtPacienteAtendido.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(79, 31);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 31;
            label4.Text = "Paciente";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.LightBlue;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(280, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(197, 35);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirmar.BackColor = Color.LightBlue;
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.Location = new Point(57, 207);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(197, 35);
            btnConfirmar.TabIndex = 29;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // TurnosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1191, 566);
            Controls.Add(panelAtenderTurno);
            Controls.Add(lblSelecMedico);
            Controls.Add(panel1);
            Controls.Add(lblNoTurnos);
            Controls.Add(label2);
            Controls.Add(dtpFechaTurno);
            Controls.Add(label1);
            Controls.Add(cboMedicos);
            Controls.Add(dataGridTurnos);
            Name = "TurnosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Turnos";
            ((System.ComponentModel.ISupportInitialize)dataGridTurnos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelAtenderTurno.ResumeLayout(false);
            panelAtenderTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboMedicos;
        private Label label1;
        private DateTimePicker dtpFechaTurno;
        private Label label2;
        private Label lblNoTurnos;
        private DataGridView dataGridTurnos;
        private Panel panel1;
        private Button btnAtender;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Label label3;
        private Button btnVolver;
        private Label lblSelecMedico;
        private Panel panelAtenderTurno;
        private Button btnConfirmar;
        private Label label6;
        private ComboBox cboFormaPago;
        private TextBox txtCoseguro;
        private Label label5;
        private TextBox txtPacienteAtendido;
        private Label label4;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}