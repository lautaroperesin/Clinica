namespace ClinicaDesktop.Views
{
    partial class PagosPendientesView
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
            lblNoPagos = new Label();
            label1 = new Label();
            dataGridPagosPendientes = new DataGridView();
            btnConfirmarPago = new Button();
            label6 = new Label();
            txtBuscar = new TextBox();
            cboFormaPago = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPagosPendientes).BeginInit();
            SuspendLayout();
            // 
            // lblNoPagos
            // 
            lblNoPagos.Anchor = AnchorStyles.None;
            lblNoPagos.AutoSize = true;
            lblNoPagos.BackColor = Color.White;
            lblNoPagos.Font = new Font("Segoe UI", 12F);
            lblNoPagos.Location = new Point(434, 234);
            lblNoPagos.Name = "lblNoPagos";
            lblNoPagos.Size = new Size(214, 21);
            lblNoPagos.TabIndex = 13;
            lblNoPagos.Text = "NO HAY PAGOS PENDIENTES";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 12;
            label1.Text = "PAGOS PENDIENTES";
            // 
            // dataGridPagosPendientes
            // 
            dataGridPagosPendientes.AllowUserToAddRows = false;
            dataGridPagosPendientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridPagosPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPagosPendientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPagosPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPagosPendientes.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPagosPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPagosPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPagosPendientes.Location = new Point(0, 102);
            dataGridPagosPendientes.MultiSelect = false;
            dataGridPagosPendientes.Name = "dataGridPagosPendientes";
            dataGridPagosPendientes.ReadOnly = true;
            dataGridPagosPendientes.RowHeadersVisible = false;
            dataGridPagosPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPagosPendientes.Size = new Size(1022, 339);
            dataGridPagosPendientes.TabIndex = 11;
            // 
            // btnConfirmarPago
            // 
            btnConfirmarPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmarPago.BackColor = Color.LightBlue;
            btnConfirmarPago.Font = new Font("Segoe UI", 12F);
            btnConfirmarPago.Location = new Point(800, 456);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(209, 50);
            btnConfirmarPago.TabIndex = 14;
            btnConfirmarPago.Text = "Confirmar pago";
            btnConfirmarPago.UseVisualStyleBackColor = false;
            btnConfirmarPago.Click += btnConfirmarPago_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(17, 75);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 16;
            label6.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(79, 67);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(369, 29);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cboFormaPago
            // 
            cboFormaPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cboFormaPago.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboFormaPago.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboFormaPago.Font = new Font("Segoe UI", 12F);
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(528, 472);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(266, 29);
            cboFormaPago.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(409, 480);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 18;
            label2.Text = "Forma de Pago";
            // 
            // PagosPendientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1021, 518);
            Controls.Add(label2);
            Controls.Add(cboFormaPago);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(btnConfirmarPago);
            Controls.Add(lblNoPagos);
            Controls.Add(label1);
            Controls.Add(dataGridPagosPendientes);
            Name = "PagosPendientesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PagosPendientesView";
            Load += PagosPendientesView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPagosPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNoPagos;
        private Label label1;
        private DataGridView dataGridPagosPendientes;
        private Button btnConfirmarPago;
        private Label label6;
        private TextBox txtBuscar;
        private ComboBox cboFormaPago;
        private Label label2;
    }
}