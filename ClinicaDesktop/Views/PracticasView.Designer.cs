namespace ClinicaDesktop.Views
{
    partial class PracticasView
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
            txtPrecio = new TextBox();
            label3 = new Label();
            cboTecnicas = new ComboBox();
            label1 = new Label();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            label4 = new Label();
            dataGridPracticas = new DataGridView();
            label6 = new Label();
            txtBuscar = new TextBox();
            errorProvider = new ErrorProvider(components);
            lblNoResultados = new Label();
            panelAgregar = new Panel();
            txtNuevoPrecio = new TextBox();
            label8 = new Label();
            cboNuevaTecnica = new ComboBox();
            label7 = new Label();
            txtNombreNuevaPrac = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnNuevaPractica = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPracticas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panelAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboTecnicas);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 454);
            panel1.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(94, 149);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(174, 29);
            txtPrecio.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(35, 153);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 22;
            label3.Text = "Precio";
            // 
            // cboTecnicas
            // 
            cboTecnicas.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTecnicas.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTecnicas.Font = new Font("Segoe UI", 12F);
            cboTecnicas.FormattingEnabled = true;
            cboTecnicas.Location = new Point(94, 101);
            cboTecnicas.Name = "cboTecnicas";
            cboTecnicas.Size = new Size(174, 29);
            cboTecnicas.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(29, 106);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 20;
            label1.Text = "Técnica";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightBlue;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(71, 377);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(178, 35);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(71, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 35);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.MediumAquamarine;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(71, 293);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(178, 35);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(94, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 29);
            txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 66);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(94, 188);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 35);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(496, 9);
            label4.Name = "label4";
            label4.Size = new Size(164, 37);
            label4.TabIndex = 9;
            label4.Text = "PRÁCTICAS";
            // 
            // dataGridPracticas
            // 
            dataGridPracticas.AllowUserToAddRows = false;
            dataGridPracticas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridPracticas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPracticas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPracticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPracticas.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPracticas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPracticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPracticas.Location = new Point(300, 110);
            dataGridPracticas.MultiSelect = false;
            dataGridPracticas.Name = "dataGridPracticas";
            dataGridPracticas.ReadOnly = true;
            dataGridPracticas.RowHeadersVisible = false;
            dataGridPracticas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPracticas.Size = new Size(504, 344);
            dataGridPracticas.TabIndex = 10;
            dataGridPracticas.SelectionChanged += dataGridPracticas_SelectionChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(594, 83);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 21;
            label6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(306, 75);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(282, 29);
            txtBuscar.TabIndex = 20;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
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
            lblNoResultados.Location = new Point(486, 198);
            lblNoResultados.Name = "lblNoResultados";
            lblNoResultados.Size = new Size(190, 19);
            lblNoResultados.TabIndex = 22;
            lblNoResultados.Text = "No se encontraron resultados";
            lblNoResultados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAgregar
            // 
            panelAgregar.Anchor = AnchorStyles.None;
            panelAgregar.BorderStyle = BorderStyle.Fixed3D;
            panelAgregar.Controls.Add(txtNuevoPrecio);
            panelAgregar.Controls.Add(label8);
            panelAgregar.Controls.Add(cboNuevaTecnica);
            panelAgregar.Controls.Add(label7);
            panelAgregar.Controls.Add(txtNombreNuevaPrac);
            panelAgregar.Controls.Add(label5);
            panelAgregar.Controls.Add(btnCancelar);
            panelAgregar.Controls.Add(btnNuevaPractica);
            panelAgregar.Location = new Point(252, 85);
            panelAgregar.Name = "panelAgregar";
            panelAgregar.Size = new Size(297, 280);
            panelAgregar.TabIndex = 23;
            panelAgregar.Visible = false;
            // 
            // txtNuevoPrecio
            // 
            txtNuevoPrecio.Anchor = AnchorStyles.Left;
            txtNuevoPrecio.Font = new Font("Segoe UI", 11F);
            txtNuevoPrecio.Location = new Point(88, 111);
            txtNuevoPrecio.Name = "txtNuevoPrecio";
            txtNuevoPrecio.Size = new Size(174, 27);
            txtNuevoPrecio.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(29, 113);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 25;
            label8.Text = "Precio";
            // 
            // cboNuevaTecnica
            // 
            cboNuevaTecnica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNuevaTecnica.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboNuevaTecnica.Font = new Font("Segoe UI", 12F);
            cboNuevaTecnica.FormattingEnabled = true;
            cboNuevaTecnica.Location = new Point(88, 63);
            cboNuevaTecnica.Name = "cboNuevaTecnica";
            cboNuevaTecnica.Size = new Size(174, 29);
            cboNuevaTecnica.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(23, 71);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 22;
            label7.Text = "Técnica";
            // 
            // txtNombreNuevaPrac
            // 
            txtNombreNuevaPrac.Anchor = AnchorStyles.Left;
            txtNombreNuevaPrac.Font = new Font("Segoe UI", 11F);
            txtNombreNuevaPrac.Location = new Point(88, 23);
            txtNombreNuevaPrac.Name = "txtNombreNuevaPrac";
            txtNombreNuevaPrac.Size = new Size(174, 27);
            txtNombreNuevaPrac.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(14, 29);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 16;
            label5.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightBlue;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(160, 185);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 35);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevaPractica
            // 
            btnNuevaPractica.Anchor = AnchorStyles.None;
            btnNuevaPractica.BackColor = Color.LightBlue;
            btnNuevaPractica.Font = new Font("Segoe UI", 12F);
            btnNuevaPractica.Location = new Point(46, 185);
            btnNuevaPractica.Name = "btnNuevaPractica";
            btnNuevaPractica.Size = new Size(108, 35);
            btnNuevaPractica.TabIndex = 3;
            btnNuevaPractica.Text = "Guardar";
            btnNuevaPractica.UseVisualStyleBackColor = false;
            btnNuevaPractica.Click += btnNuevaPractica_Click;
            // 
            // PracticasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAgregar);
            Controls.Add(lblNoResultados);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridPracticas);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "PracticasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Practicas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPracticas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panelAgregar.ResumeLayout(false);
            panelAgregar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Button btnEliminar;
        private Label label3;
        private ComboBox cboTecnicas;
        private Label label1;
        private Button btnVolver;
        private Label label4;
        private DataGridView dataGridPracticas;
        private Label label6;
        private TextBox txtBuscar;
        private ErrorProvider errorProvider;
        private Label lblNoResultados;
        private Panel panelAgregar;
        private Label label8;
        private ComboBox cboNuevaTecnica;
        private Label label7;
        private TextBox txtNombreNuevaPrac;
        private Label label5;
        private Button btnCancelar;
        private Button btnNuevaPractica;
        private TextBox txtPrecio;
        private TextBox txtNuevoPrecio;
    }
}