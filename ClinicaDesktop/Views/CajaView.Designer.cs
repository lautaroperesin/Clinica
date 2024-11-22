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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridCaja = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtTotal = new TextBox();
            btnQuitar = new Button();
            lblFecha = new Label();
            dtpDiaActual = new DateTimePicker();
            lblNoTurnos = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridCaja).BeginInit();
            SuspendLayout();
            // 
            // dataGridCaja
            // 
            dataGridCaja.AllowUserToAddRows = false;
            dataGridCaja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCaja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCaja.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 12F);
            txtTotal.Location = new Point(807, 531);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 29);
            txtTotal.TabIndex = 6;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuitar.BackColor = Color.LightBlue;
            btnQuitar.Font = new Font("Segoe UI", 12F);
            btnQuitar.Location = new Point(12, 525);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(178, 35);
            btnQuitar.TabIndex = 7;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
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
            // CajaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1038, 588);
            Controls.Add(lblNoTurnos);
            Controls.Add(dtpDiaActual);
            Controls.Add(lblFecha);
            Controls.Add(btnQuitar);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridCaja);
            Name = "CajaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Caja";
            ((System.ComponentModel.ISupportInitialize)dataGridCaja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCaja;
        private Label label1;
        private Label label2;
        private TextBox txtTotal;
        private Button btnQuitar;
        private Label lblFecha;
        private DateTimePicker dtpDiaActual;
        private Label lblNoTurnos;
    }
}