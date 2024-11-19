namespace ClinicaDesktop.Views
{
    partial class MutualesView
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
            btnVolver = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            label4 = new Label();
            label6 = new Label();
            txtBuscar = new TextBox();
            dataGridMutuales = new DataGridView();
            lblNoResultados = new Label();
            errorProvider1 = new ErrorProvider(components);
            panelAgregar = new Panel();
            txtNombreNuevaMut = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardarNuevaMut = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMutuales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panelAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 451);
            panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightBlue;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(85, 365);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(178, 35);
            btnVolver.TabIndex = 29;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightBlue;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(85, 324);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 35);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(85, 281);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(178, 35);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(108, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 29);
            txtNombre.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(29, 130);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 24;
            label2.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(108, 169);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 35);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(513, 9);
            label4.Name = "label4";
            label4.Size = new Size(160, 37);
            label4.TabIndex = 10;
            label4.Text = "MUTUALES";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(637, 80);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 23;
            label6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(324, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(307, 29);
            txtBuscar.TabIndex = 22;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dataGridMutuales
            // 
            dataGridMutuales.AllowUserToAddRows = false;
            dataGridMutuales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridMutuales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridMutuales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridMutuales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMutuales.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridMutuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridMutuales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMutuales.Location = new Point(306, 108);
            dataGridMutuales.MultiSelect = false;
            dataGridMutuales.Name = "dataGridMutuales";
            dataGridMutuales.ReadOnly = true;
            dataGridMutuales.RowHeadersVisible = false;
            dataGridMutuales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMutuales.Size = new Size(519, 347);
            dataGridMutuales.TabIndex = 24;
            dataGridMutuales.SelectionChanged += dataGridMutuales_SelectionChanged;
            // 
            // lblNoResultados
            // 
            lblNoResultados.Anchor = AnchorStyles.None;
            lblNoResultados.AutoSize = true;
            lblNoResultados.BackColor = Color.White;
            lblNoResultados.Font = new Font("Segoe UI", 10F);
            lblNoResultados.Location = new Point(503, 138);
            lblNoResultados.Name = "lblNoResultados";
            lblNoResultados.Size = new Size(190, 19);
            lblNoResultados.TabIndex = 25;
            lblNoResultados.Text = "No se encontraron resultados";
            lblNoResultados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panelAgregar
            // 
            panelAgregar.Anchor = AnchorStyles.None;
            panelAgregar.BorderStyle = BorderStyle.Fixed3D;
            panelAgregar.Controls.Add(txtNombreNuevaMut);
            panelAgregar.Controls.Add(label3);
            panelAgregar.Controls.Add(btnCancelar);
            panelAgregar.Controls.Add(btnGuardarNuevaMut);
            panelAgregar.Location = new Point(264, 86);
            panelAgregar.Name = "panelAgregar";
            panelAgregar.Size = new Size(297, 280);
            panelAgregar.TabIndex = 26;
            panelAgregar.Visible = false;
            // 
            // txtNombreNuevaMut
            // 
            txtNombreNuevaMut.Anchor = AnchorStyles.Left;
            txtNombreNuevaMut.Font = new Font("Segoe UI", 11F);
            txtNombreNuevaMut.Location = new Point(98, 102);
            txtNombreNuevaMut.Name = "txtNombreNuevaMut";
            txtNombreNuevaMut.Size = new Size(174, 27);
            txtNombreNuevaMut.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 106);
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
            btnCancelar.Location = new Point(154, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 35);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarNuevaMut
            // 
            btnGuardarNuevaMut.Anchor = AnchorStyles.None;
            btnGuardarNuevaMut.BackColor = Color.LightBlue;
            btnGuardarNuevaMut.Font = new Font("Segoe UI", 12F);
            btnGuardarNuevaMut.Location = new Point(40, 184);
            btnGuardarNuevaMut.Name = "btnGuardarNuevaMut";
            btnGuardarNuevaMut.Size = new Size(108, 35);
            btnGuardarNuevaMut.TabIndex = 14;
            btnGuardarNuevaMut.Text = "Guardar";
            btnGuardarNuevaMut.UseVisualStyleBackColor = false;
            btnGuardarNuevaMut.Click += btnGuardarNuevaMut_Click;
            // 
            // MutualesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(825, 453);
            Controls.Add(panelAgregar);
            Controls.Add(lblNoResultados);
            Controls.Add(dataGridMutuales);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "MutualesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mutuales";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMutuales).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panelAgregar.ResumeLayout(false);
            panelAgregar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnAgregar;
        private TextBox txtNombre;
        private Label label2;
        private Button btnGuardar;
        private Label label4;
        private Label label6;
        private TextBox txtBuscar;
        private DataGridView dataGridMutuales;
        private Label lblNoResultados;
        private ErrorProvider errorProvider1;
        private Panel panelAgregar;
        private TextBox txtNombreNuevaMut;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardarNuevaMut;
    }
}