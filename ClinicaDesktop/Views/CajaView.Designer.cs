namespace ClinicaDesktop.Views
{
    partial class CajaView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridCaja = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblFecha = new Label();
            dtpDiaActual = new DateTimePicker();
            lblNoTurnos = new Label();
            btnVolver = new Button();
            numericTotal = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridCaja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // dataGridCaja
            // 
            dataGridCaja.AllowUserToAddRows = false;
            dataGridCaja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCaja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCaja.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCaja.Location = new Point(0, 97);
            dataGridCaja.MultiSelect = false;
            dataGridCaja.Name = "dataGridCaja";
            dataGridCaja.ReadOnly = true;
            dataGridCaja.RowHeadersVisible = false;
            dataGridCaja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCaja.Size = new Size(1040, 409);
            dataGridCaja.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(370, 23);
            label1.Name = "label1";
            label1.Size = new Size(378, 37);
            label1.TabIndex = 4;
            label1.Text = "CAJA - TURNOS ATENDIDOS";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(745, 539);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 5;
            label2.Text = "TOTAL:";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.Location = new Point(847, 70);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(60, 21);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "FECHA:";
            // 
            // dtpDiaActual
            // 
            dtpDiaActual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDiaActual.Enabled = false;
            dtpDiaActual.Font = new Font("Segoe UI", 12F);
            dtpDiaActual.Format = DateTimePickerFormat.Short;
            dtpDiaActual.Location = new Point(913, 62);
            dtpDiaActual.Name = "dtpDiaActual";
            dtpDiaActual.Size = new Size(113, 29);
            dtpDiaActual.TabIndex = 9;
            // 
            // lblNoTurnos
            // 
            lblNoTurnos.Anchor = AnchorStyles.None;
            lblNoTurnos.AutoSize = true;
            lblNoTurnos.BackColor = Color.White;
            lblNoTurnos.Font = new Font("Segoe UI", 12F);
            lblNoTurnos.Location = new Point(370, 245);
            lblNoTurnos.Name = "lblNoTurnos";
            lblNoTurnos.Size = new Size(329, 21);
            lblNoTurnos.TabIndex = 10;
            lblNoTurnos.Text = "NO HAY TURNOS ATENDIDOS EL DIA DE HOY";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.LightBlue;
            btnVolver.Font = new Font("Segoe UI", 12F);
            btnVolver.Location = new Point(12, 527);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(178, 35);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // numericTotal
            // 
            numericTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericTotal.Enabled = false;
            numericTotal.Font = new Font("Segoe UI", 12F);
            numericTotal.Location = new Point(807, 531);
            numericTotal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.ReadOnly = true;
            numericTotal.Size = new Size(120, 29);
            numericTotal.TabIndex = 12;
            // 
            // CajaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1038, 588);
            Controls.Add(numericTotal);
            Controls.Add(btnVolver);
            Controls.Add(lblNoTurnos);
            Controls.Add(dtpDiaActual);
            Controls.Add(lblFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridCaja);
            Name = "CajaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Caja";
            ((System.ComponentModel.ISupportInitialize)dataGridCaja).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCaja;
        private Label label1;
        private Label label2;
        private Label lblFecha;
        private DateTimePicker dtpDiaActual;
        private Label lblNoTurnos;
        private Button btnVolver;
        private NumericUpDown numericTotal;
    }
}