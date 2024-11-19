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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            cboMedicos = new ComboBox();
            label1 = new Label();
            dtpFechaTurno = new DateTimePicker();
            label2 = new Label();
            lblNoTurnos = new Label();
            dataGridTurnos = new DataGridView();
            panel1 = new Panel();
            btnAtender = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridTurnos).BeginInit();
            panel1.SuspendLayout();
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
            // 
            // dataGridTurnos
            // 
            dataGridTurnos.AllowUserToAddRows = false;
            dataGridTurnos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.Silver;
            dataGridTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridTurnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTurnos.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // btnAtender
            // 
            btnAtender.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtender.BackColor = Color.LightBlue;
            btnAtender.Font = new Font("Segoe UI", 12F);
            btnAtender.Location = new Point(3, 305);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(197, 33);
            btnAtender.TabIndex = 31;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightBlue;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(3, 428);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(197, 35);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.LightBlue;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(3, 387);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(197, 35);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(3, 346);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(197, 35);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
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
            // TurnosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1191, 566);
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
            Load += TurnosView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTurnos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}