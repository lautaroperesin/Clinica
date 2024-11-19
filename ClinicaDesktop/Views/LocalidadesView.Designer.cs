namespace ClinicaDesktop.Views
{
    partial class LocalidadesView
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
            dataGridLocalidades = new DataGridView();
            label6 = new Label();
            txtBuscar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            panel1 = new Panel();
            errorProvider = new ErrorProvider(components);
            lblNoResultados = new Label();
            panelAgregar = new Panel();
            txtNombreNuevLoc = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardarLocalidad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panelAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridLocalidades
            // 
            dataGridLocalidades.AllowUserToAddRows = false;
            dataGridLocalidades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridLocalidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridLocalidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLocalidades.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridLocalidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocalidades.Location = new Point(258, 85);
            dataGridLocalidades.MultiSelect = false;
            dataGridLocalidades.Name = "dataGridLocalidades";
            dataGridLocalidades.ReadOnly = true;
            dataGridLocalidades.RowHeadersVisible = false;
            dataGridLocalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLocalidades.Size = new Size(486, 317);
            dataGridLocalidades.TabIndex = 3;
            dataGridLocalidades.SelectionChanged += dataGridLocalidades_SelectionChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(578, 58);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 10;
            label6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(290, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(282, 29);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(401, -2);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 8;
            label1.Text = "LOCALIDADES";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(78, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(79, 147);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 35);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightBlue;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(39, 327);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(178, 35);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightBlue;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(39, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 35);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(39, 241);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(178, 35);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 404);
            panel1.TabIndex = 17;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblNoResultados
            // 
            lblNoResultados.Anchor = AnchorStyles.None;
            lblNoResultados.AutoSize = true;
            lblNoResultados.BackColor = Color.White;
            lblNoResultados.Font = new Font("Segoe UI", 10F);
            lblNoResultados.Location = new Point(444, 205);
            lblNoResultados.Name = "lblNoResultados";
            lblNoResultados.Size = new Size(190, 19);
            lblNoResultados.TabIndex = 18;
            lblNoResultados.Text = "No se encontraron resultados";
            lblNoResultados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAgregar
            // 
            panelAgregar.Anchor = AnchorStyles.None;
            panelAgregar.BorderStyle = BorderStyle.Fixed3D;
            panelAgregar.Controls.Add(txtNombreNuevLoc);
            panelAgregar.Controls.Add(label3);
            panelAgregar.Controls.Add(btnCancelar);
            panelAgregar.Controls.Add(btnGuardarLocalidad);
            panelAgregar.Location = new Point(260, 12);
            panelAgregar.Name = "panelAgregar";
            panelAgregar.Size = new Size(297, 280);
            panelAgregar.TabIndex = 19;
            panelAgregar.Visible = false;
            // 
            // txtNombreNuevLoc
            // 
            txtNombreNuevLoc.Anchor = AnchorStyles.Left;
            txtNombreNuevLoc.Font = new Font("Segoe UI", 11F);
            txtNombreNuevLoc.Location = new Point(91, 83);
            txtNombreNuevLoc.Name = "txtNombreNuevLoc";
            txtNombreNuevLoc.Size = new Size(174, 27);
            txtNombreNuevLoc.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightBlue;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(157, 166);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 35);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarLocalidad
            // 
            btnGuardarLocalidad.Anchor = AnchorStyles.None;
            btnGuardarLocalidad.BackColor = Color.LightBlue;
            btnGuardarLocalidad.Font = new Font("Segoe UI", 12F);
            btnGuardarLocalidad.Location = new Point(33, 166);
            btnGuardarLocalidad.Name = "btnGuardarLocalidad";
            btnGuardarLocalidad.Size = new Size(108, 35);
            btnGuardarLocalidad.TabIndex = 1;
            btnGuardarLocalidad.Text = "Guardar";
            btnGuardarLocalidad.UseVisualStyleBackColor = false;
            btnGuardarLocalidad.Click += btnGuardarLocalidad_Click;
            // 
            // LocalidadesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(740, 398);
            Controls.Add(panelAgregar);
            Controls.Add(lblNoResultados);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(dataGridLocalidades);
            Controls.Add(panel1);
            Name = "LocalidadesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Localidades";
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panelAgregar.ResumeLayout(false);
            panelAgregar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridLocalidades;
        private Label label6;
        private TextBox txtBuscar;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnAgregar;
        private Panel panel1;
        private ErrorProvider errorProvider;
        private Label lblNoResultados;
        private Panel panelAgregar;
        private TextBox txtNombreNuevLoc;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardarLocalidad;
    }
}