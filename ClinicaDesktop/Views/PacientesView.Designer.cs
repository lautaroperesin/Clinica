namespace ClinicaDesktop.Views
{
    partial class PacientesView
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
            panel1 = new Panel();
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
            btnVolver = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            dataGridPacientes = new DataGridView();
            txtBuscar = new TextBox();
            errorProvider = new ErrorProvider(components);
            label6 = new Label();
            lblNoResultados = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboLocalidades);
            panel1.Controls.Add(cboMutuales);
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 540);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(2, 171);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 22;
            label10.Text = "Localidad";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(18, 274);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 21;
            label9.Text = "Mutual";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(-1, 240);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 20;
            label8.Text = "Fecha nac.";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 204);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 19;
            label7.Text = "Dirección";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(9, 137);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 17;
            label5.Text = "Teléfono";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(36, 104);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 16;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(10, 71);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 15;
            label3.Text = "Apellido";
            // 
            // cboLocalidades
            // 
            cboLocalidades.Anchor = AnchorStyles.None;
            cboLocalidades.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLocalidades.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboLocalidades.Font = new Font("Segoe UI", 11F);
            cboLocalidades.FormattingEnabled = true;
            cboLocalidades.Location = new Point(87, 164);
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
            cboMutuales.Location = new Point(87, 267);
            cboMutuales.Name = "cboMutuales";
            cboMutuales.Size = new Size(174, 28);
            cboMutuales.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.None;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 11F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(87, 234);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(174, 27);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Font = new Font("Segoe UI", 11F);
            txtDireccion.Location = new Point(87, 198);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(174, 27);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(87, 131);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(174, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Font = new Font("Segoe UI", 11F);
            txtDni.Location = new Point(87, 98);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(174, 27);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(87, 64);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(174, 27);
            txtApellido.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 32);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(87, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(87, 305);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 35);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightBlue;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(59, 475);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(178, 35);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightBlue;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(59, 431);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 35);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(59, 389);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(178, 35);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(591, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 1;
            label1.Text = "PACIENTES";
            // 
            // dataGridPacientes
            // 
            dataGridPacientes.AllowUserToAddRows = false;
            dataGridPacientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPacientes.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPacientes.Location = new Point(281, 100);
            dataGridPacientes.MultiSelect = false;
            dataGridPacientes.Name = "dataGridPacientes";
            dataGridPacientes.ReadOnly = true;
            dataGridPacientes.RowHeadersVisible = false;
            dataGridPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPacientes.Size = new Size(700, 440);
            dataGridPacientes.TabIndex = 2;
            dataGridPacientes.SelectionChanged += dataGridPacientes_SelectionChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(285, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(369, 29);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(660, 73);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 7;
            label6.Text = "Buscar";
            // 
            // lblNoResultados
            // 
            lblNoResultados.Anchor = AnchorStyles.None;
            lblNoResultados.AutoSize = true;
            lblNoResultados.BackColor = Color.White;
            lblNoResultados.Font = new Font("Segoe UI", 10F);
            lblNoResultados.Location = new Point(572, 207);
            lblNoResultados.Name = "lblNoResultados";
            lblNoResultados.Size = new Size(190, 19);
            lblNoResultados.TabIndex = 19;
            lblNoResultados.Text = "No se encontraron resultados";
            lblNoResultados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PacientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(983, 541);
            Controls.Add(lblNoResultados);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridPacientes);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "PacientesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pacientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridPacientes;
        private TextBox txtBuscar;
        private Button btnGuardar;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnAgregar;
        private TextBox txtNombre;
        private TextBox txtDni;
        private TextBox txtApellido;
        private Label label2;
        private ComboBox cboLocalidades;
        private ComboBox cboMutuales;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox textBox6;
        private TextBox txtTelefono;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        public TextBox txtDireccion;
        private ErrorProvider errorProvider;
        private Label label6;
        private Label lblNoResultados;
    }
}