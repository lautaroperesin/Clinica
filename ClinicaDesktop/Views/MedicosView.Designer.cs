namespace ClinicaDesktop.Views
{
    partial class MedicosView
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
            errorProvider = new ErrorProvider(components);
            label6 = new Label();
            txtBuscar = new TextBox();
            dataGridMedicos = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            cboTecnica = new ComboBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblNoResultados = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMedicos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            label6.Location = new Point(619, 73);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 11;
            label6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(316, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(297, 29);
            txtBuscar.TabIndex = 10;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dataGridMedicos
            // 
            dataGridMedicos.AllowUserToAddRows = false;
            dataGridMedicos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridMedicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMedicos.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMedicos.Location = new Point(310, 100);
            dataGridMedicos.MultiSelect = false;
            dataGridMedicos.Name = "dataGridMedicos";
            dataGridMedicos.ReadOnly = true;
            dataGridMedicos.RowHeadersVisible = false;
            dataGridMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMedicos.Size = new Size(624, 481);
            dataGridMedicos.TabIndex = 9;
            dataGridMedicos.SelectionChanged += dataGridMedicos_SelectionChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(544, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 37);
            label1.TabIndex = 8;
            label1.Text = "MÉDICOS";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboTecnica);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 577);
            panel1.TabIndex = 12;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(24, 217);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 41;
            label9.Text = "Técnica";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(15, 183);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 38;
            label5.Text = "Teléfono";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 151);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 36;
            label3.Text = "Apellido";
            // 
            // cboTecnica
            // 
            cboTecnica.Anchor = AnchorStyles.None;
            cboTecnica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTecnica.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTecnica.Font = new Font("Segoe UI", 11F);
            cboTecnica.FormattingEnabled = true;
            cboTecnica.Location = new Point(93, 210);
            cboTecnica.Name = "cboTecnica";
            cboTecnica.Size = new Size(184, 28);
            cboTecnica.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(93, 177);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(184, 27);
            txtTelefono.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(93, 144);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(184, 27);
            txtApellido.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 116);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 28;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(93, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(93, 256);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(184, 35);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightBlue;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(49, 459);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(197, 35);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightBlue;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(49, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(197, 35);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(49, 373);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(197, 35);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNoResultados
            // 
            lblNoResultados.Anchor = AnchorStyles.None;
            lblNoResultados.AutoSize = true;
            lblNoResultados.BackColor = Color.White;
            lblNoResultados.Font = new Font("Segoe UI", 10F);
            lblNoResultados.Location = new Point(544, 261);
            lblNoResultados.Name = "lblNoResultados";
            lblNoResultados.Size = new Size(190, 19);
            lblNoResultados.TabIndex = 23;
            lblNoResultados.Text = "No se encontraron resultados";
            lblNoResultados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MedicosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(936, 580);
            Controls.Add(lblNoResultados);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridMedicos);
            Controls.Add(label1);
            Name = "MedicosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Medicos";
            Load += MedicosView_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMedicos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider;
        private Label label6;
        private TextBox txtBuscar;
        private DataGridView dataGridMedicos;
        private Label label1;
        private Panel panel1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label label9;
        private Label label5;
        private Label label3;
        private ComboBox cboTecnica;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Label lblNoResultados;
    }
}