namespace ClinicaDesktop.Views
{
    partial class AgregarMedicoView
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
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            cboTecnica = new ComboBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(56, 229);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 50;
            label9.Text = "Técnica";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(47, 195);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 49;
            label5.Text = "Teléfono";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(48, 163);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 48;
            label3.Text = "Apellido";
            // 
            // cboTecnica
            // 
            cboTecnica.Anchor = AnchorStyles.None;
            cboTecnica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTecnica.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTecnica.Font = new Font("Segoe UI", 11F);
            cboTecnica.FormattingEnabled = true;
            cboTecnica.Location = new Point(125, 222);
            cboTecnica.Name = "cboTecnica";
            cboTecnica.Size = new Size(184, 28);
            cboTecnica.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(125, 189);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(184, 27);
            txtTelefono.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(125, 156);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(184, 27);
            txtApellido.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(47, 128);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 44;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(125, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(75, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightBlue;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(195, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 34);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AgregarMedicoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(357, 424);
            Controls.Add(btnCancelar);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(cboTecnica);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Name = "AgregarMedicoView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Medico";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label5;
        private Label label3;
        private ComboBox cboTecnica;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}