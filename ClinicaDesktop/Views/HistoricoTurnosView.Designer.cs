namespace ClinicaDesktop.Views
{
    partial class HistoricoTurnosView
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
            label1 = new Label();
            dataGridTurnos = new DataGridView();
            checkFiltrado = new CheckBox();
            panelFiltrado = new Panel();
            btnFiltrar = new Button();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            lblNoResultados = new Label();
            label4 = new Label();
            numericTotal = new NumericUpDown();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTurnos).BeginInit();
            panelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(377, 20);
            label1.Name = "label1";
            label1.Size = new Size(278, 37);
            label1.TabIndex = 5;
            label1.Text = "HISTÓRICO TURNOS";
            // 
            // dataGridTurnos
            // 
            dataGridTurnos.AllowUserToAddRows = false;
            dataGridTurnos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTurnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTurnos.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTurnos.Location = new Point(-1, 136);
            dataGridTurnos.MultiSelect = false;
            dataGridTurnos.Name = "dataGridTurnos";
            dataGridTurnos.ReadOnly = true;
            dataGridTurnos.RowHeadersVisible = false;
            dataGridTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTurnos.Size = new Size(964, 308);
            dataGridTurnos.TabIndex = 6;
            // 
            // checkFiltrado
            // 
            checkFiltrado.AutoSize = true;
            checkFiltrado.Font = new Font("Segoe UI", 12F);
            checkFiltrado.Location = new Point(12, 74);
            checkFiltrado.Name = "checkFiltrado";
            checkFiltrado.Size = new Size(82, 25);
            checkFiltrado.TabIndex = 7;
            checkFiltrado.Text = "Filtrado";
            checkFiltrado.UseVisualStyleBackColor = true;
            checkFiltrado.CheckedChanged += checkFiltrado_CheckedChanged;
            // 
            // panelFiltrado
            // 
            panelFiltrado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltrado.BorderStyle = BorderStyle.Fixed3D;
            panelFiltrado.Controls.Add(btnFiltrar);
            panelFiltrado.Controls.Add(dtpHasta);
            panelFiltrado.Controls.Add(dtpDesde);
            panelFiltrado.Controls.Add(label3);
            panelFiltrado.Controls.Add(label2);
            panelFiltrado.Enabled = false;
            panelFiltrado.Location = new Point(100, 74);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(863, 56);
            panelFiltrado.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.LightBlue;
            btnFiltrar.Font = new Font("Segoe UI", 12F);
            btnFiltrar.Location = new Point(633, 13);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(141, 31);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 12F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(408, 13);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(200, 29);
            dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 12F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(111, 11);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(200, 29);
            dtpDesde.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(350, 21);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 1;
            label3.Text = "Hasta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(49, 19);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 0;
            label2.Text = "Desde:";
            // 
            // lblNoResultados
            // 
            lblNoResultados.Anchor = AnchorStyles.None;
            lblNoResultados.AutoSize = true;
            lblNoResultados.BackColor = Color.White;
            lblNoResultados.Font = new Font("Segoe UI", 12F);
            lblNoResultados.Location = new Point(382, 250);
            lblNoResultados.Name = "lblNoResultados";
            lblNoResultados.Size = new Size(273, 21);
            lblNoResultados.TabIndex = 5;
            lblNoResultados.Text = "NO SE ENCONTRARON RESULTADOS";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(745, 470);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 9;
            label4.Text = "TOTAL:";
            // 
            // numericTotal
            // 
            numericTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericTotal.Enabled = false;
            numericTotal.Font = new Font("Segoe UI", 12F);
            numericTotal.Location = new Point(807, 464);
            numericTotal.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.ReadOnly = true;
            numericTotal.Size = new Size(120, 29);
            numericTotal.TabIndex = 10;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.LightBlue;
            btnImprimir.Font = new Font("Segoe UI", 12F);
            btnImprimir.Location = new Point(585, 455);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(141, 43);
            btnImprimir.TabIndex = 5;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // HistoricoTurnosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(963, 505);
            Controls.Add(btnImprimir);
            Controls.Add(numericTotal);
            Controls.Add(label4);
            Controls.Add(lblNoResultados);
            Controls.Add(panelFiltrado);
            Controls.Add(checkFiltrado);
            Controls.Add(dataGridTurnos);
            Controls.Add(label1);
            Name = "HistoricoTurnosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Historico Turnos";
            ((System.ComponentModel.ISupportInitialize)dataGridTurnos).EndInit();
            panelFiltrado.ResumeLayout(false);
            panelFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridTurnos;
        private CheckBox checkFiltrado;
        private Panel panelFiltrado;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnFiltrar;
        private Label lblNoResultados;
        private Label label4;
        private NumericUpDown numericTotal;
        private Button btnImprimir;
    }
}