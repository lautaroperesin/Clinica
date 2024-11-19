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
            dataGridTurnos = new DataGridView();
            cboMedicos = new ComboBox();
            label1 = new Label();
            dtpFechaTurno = new DateTimePicker();
            label2 = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAtender = new Button();
            lblNoTurnos = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridTurnos).BeginInit();
            SuspendLayout();
            // 
            // dataGridTurnos
            // 
            dataGridTurnos.AllowUserToAddRows = false;
            dataGridTurnos.AllowUserToDeleteRows = false;
            dataGridTurnos.BackgroundColor = SystemColors.ActiveBorder;
            dataGridTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTurnos.Location = new Point(215, 102);
            dataGridTurnos.Name = "dataGridTurnos";
            dataGridTurnos.ReadOnly = true;
            dataGridTurnos.Size = new Size(592, 358);
            dataGridTurnos.TabIndex = 0;
            // 
            // cboMedicos
            // 
            cboMedicos.Font = new Font("Segoe UI", 12F);
            cboMedicos.FormattingEnabled = true;
            cboMedicos.Location = new Point(215, 58);
            cboMedicos.Name = "cboMedicos";
            cboMedicos.Size = new Size(219, 29);
            cboMedicos.TabIndex = 1;
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
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(12, 256);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(197, 35);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.LightBlue;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(12, 297);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(197, 35);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightBlue;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(12, 338);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(197, 35);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAtender
            // 
            btnAtender.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtender.BackColor = Color.LightBlue;
            btnAtender.Font = new Font("Segoe UI", 12F);
            btnAtender.Location = new Point(12, 155);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(197, 55);
            btnAtender.TabIndex = 27;
            btnAtender.Text = "Marcar como atendido";
            btnAtender.UseVisualStyleBackColor = false;
            // 
            // lblNoTurnos
            // 
            lblNoTurnos.AutoSize = true;
            lblNoTurnos.BackColor = Color.White;
            lblNoTurnos.Font = new Font("Segoe UI", 12F);
            lblNoTurnos.Location = new Point(472, 155);
            lblNoTurnos.Name = "lblNoTurnos";
            lblNoTurnos.Size = new Size(255, 21);
            lblNoTurnos.TabIndex = 28;
            lblNoTurnos.Text = "NO HAY TURNOS PROGRAMADOS";
            // 
            // TurnosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(808, 460);
            Controls.Add(lblNoTurnos);
            Controls.Add(btnAtender);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(dtpFechaTurno);
            Controls.Add(label1);
            Controls.Add(cboMedicos);
            Controls.Add(dataGridTurnos);
            Name = "TurnosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Turnos";
            Load += TurnosView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridTurnos;
        private ComboBox cboMedicos;
        private Label label1;
        private DateTimePicker dtpFechaTurno;
        private Label label2;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAtender;
        private Label lblNoTurnos;
    }
}