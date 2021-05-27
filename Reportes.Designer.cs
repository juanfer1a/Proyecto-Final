namespace Proyecto_Final
{
    partial class frm_Reportes
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGBalance = new System.Windows.Forms.Button();
            this.btnHMovimientos = new System.Windows.Forms.Button();
            this.btnReporVentas = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCerrarVenta = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pnlMovimientos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnCerrarMove = new System.Windows.Forms.Button();
            this.btnGenerarMovimiento = new System.Windows.Forms.Button();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.datBalance = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrarBalance = new System.Windows.Forms.Button();
            this.btnGenerarBalance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlVentas.SuspendLayout();
            this.pnlMovimientos.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(705, 396);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(83, 42);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 423);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnGBalance
            // 
            this.btnGBalance.Location = new System.Drawing.Point(705, 137);
            this.btnGBalance.Name = "btnGBalance";
            this.btnGBalance.Size = new System.Drawing.Size(83, 42);
            this.btnGBalance.TabIndex = 3;
            this.btnGBalance.Text = "&Generar balance";
            this.btnGBalance.UseVisualStyleBackColor = true;
            this.btnGBalance.Click += new System.EventHandler(this.btnGBalance_Click);
            // 
            // btnHMovimientos
            // 
            this.btnHMovimientos.Location = new System.Drawing.Point(705, 12);
            this.btnHMovimientos.Name = "btnHMovimientos";
            this.btnHMovimientos.Size = new System.Drawing.Size(83, 42);
            this.btnHMovimientos.TabIndex = 5;
            this.btnHMovimientos.Text = "&Historial Movimientos";
            this.btnHMovimientos.UseVisualStyleBackColor = true;
            this.btnHMovimientos.Click += new System.EventHandler(this.btnHMovimientos_Click);
            // 
            // btnReporVentas
            // 
            this.btnReporVentas.Location = new System.Drawing.Point(705, 69);
            this.btnReporVentas.Name = "btnReporVentas";
            this.btnReporVentas.Size = new System.Drawing.Size(83, 42);
            this.btnReporVentas.TabIndex = 6;
            this.btnReporVentas.Text = "Reporte &Ventas";
            this.btnReporVentas.UseVisualStyleBackColor = true;
            this.btnReporVentas.Click += new System.EventHandler(this.btnReporVentas_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(578, 396);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(83, 42);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // pnlVentas
            // 
            this.pnlVentas.Controls.Add(this.label1);
            this.pnlVentas.Controls.Add(this.comboBox1);
            this.pnlVentas.Controls.Add(this.btnCerrarVenta);
            this.pnlVentas.Controls.Add(this.btnGenerar);
            this.pnlVentas.Location = new System.Drawing.Point(304, 92);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(200, 100);
            this.pnlVentas.TabIndex = 8;
            this.pnlVentas.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo Reporte";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Categoria",
            "Producto"});
            this.comboBox1.Location = new System.Drawing.Point(18, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.Location = new System.Drawing.Point(133, 65);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(49, 28);
            this.btnCerrarVenta.TabIndex = 1;
            this.btnCerrarVenta.Text = "Cerrar";
            this.btnCerrarVenta.UseVisualStyleBackColor = true;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(18, 65);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(64, 28);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // pnlMovimientos
            // 
            this.pnlMovimientos.Controls.Add(this.label2);
            this.pnlMovimientos.Controls.Add(this.comboBox2);
            this.pnlMovimientos.Controls.Add(this.btnCerrarMove);
            this.pnlMovimientos.Controls.Add(this.btnGenerarMovimiento);
            this.pnlMovimientos.Location = new System.Drawing.Point(575, 196);
            this.pnlMovimientos.Name = "pnlMovimientos";
            this.pnlMovimientos.Size = new System.Drawing.Size(200, 100);
            this.pnlMovimientos.TabIndex = 9;
            this.pnlMovimientos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Reporte";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Andres",
            "Jaiber",
            "Walther",
            "Juan",
            "Todos"});
            this.comboBox2.Location = new System.Drawing.Point(18, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // btnCerrarMove
            // 
            this.btnCerrarMove.Location = new System.Drawing.Point(133, 65);
            this.btnCerrarMove.Name = "btnCerrarMove";
            this.btnCerrarMove.Size = new System.Drawing.Size(49, 28);
            this.btnCerrarMove.TabIndex = 1;
            this.btnCerrarMove.Text = "Cerrar";
            this.btnCerrarMove.UseVisualStyleBackColor = true;
            this.btnCerrarMove.Click += new System.EventHandler(this.btnCerrarMove_Click);
            // 
            // btnGenerarMovimiento
            // 
            this.btnGenerarMovimiento.Location = new System.Drawing.Point(18, 65);
            this.btnGenerarMovimiento.Name = "btnGenerarMovimiento";
            this.btnGenerarMovimiento.Size = new System.Drawing.Size(64, 28);
            this.btnGenerarMovimiento.TabIndex = 0;
            this.btnGenerarMovimiento.Text = "Generar";
            this.btnGenerarMovimiento.UseVisualStyleBackColor = true;
            // 
            // pnlBalance
            // 
            this.pnlBalance.Controls.Add(this.datBalance);
            this.pnlBalance.Controls.Add(this.label3);
            this.pnlBalance.Controls.Add(this.btnCerrarBalance);
            this.pnlBalance.Controls.Add(this.btnGenerarBalance);
            this.pnlBalance.Location = new System.Drawing.Point(304, 207);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(200, 113);
            this.pnlBalance.TabIndex = 10;
            this.pnlBalance.Visible = false;
            // 
            // datBalance
            // 
            this.datBalance.Location = new System.Drawing.Point(19, 40);
            this.datBalance.Name = "datBalance";
            this.datBalance.Size = new System.Drawing.Size(151, 20);
            this.datBalance.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Reporte";
            // 
            // btnCerrarBalance
            // 
            this.btnCerrarBalance.Location = new System.Drawing.Point(127, 71);
            this.btnCerrarBalance.Name = "btnCerrarBalance";
            this.btnCerrarBalance.Size = new System.Drawing.Size(49, 28);
            this.btnCerrarBalance.TabIndex = 1;
            this.btnCerrarBalance.Text = "Cerrar";
            this.btnCerrarBalance.UseVisualStyleBackColor = true;
            this.btnCerrarBalance.Click += new System.EventHandler(this.btnCerrarBalance_Click);
            // 
            // btnGenerarBalance
            // 
            this.btnGenerarBalance.Location = new System.Drawing.Point(19, 71);
            this.btnGenerarBalance.Name = "btnGenerarBalance";
            this.btnGenerarBalance.Size = new System.Drawing.Size(64, 28);
            this.btnGenerarBalance.TabIndex = 0;
            this.btnGenerarBalance.Text = "Generar";
            this.btnGenerarBalance.UseVisualStyleBackColor = true;
            // 
            // frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlMovimientos);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReporVentas);
            this.Controls.Add(this.btnHMovimientos);
            this.Controls.Add(this.btnGBalance);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMenu);
            this.Name = "frm_Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.pnlMovimientos.ResumeLayout(false);
            this.pnlMovimientos.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGBalance;
        private System.Windows.Forms.Button btnReporFinan;
        private System.Windows.Forms.Button btnHMovimientos;
        private System.Windows.Forms.Button btnReporVentas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Button btnCerrarVenta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMovimientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnCerrarMove;
        private System.Windows.Forms.Button btnGenerarMovimiento;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrarBalance;
        private System.Windows.Forms.Button btnGenerarBalance;
        private System.Windows.Forms.DateTimePicker datBalance;
    }
}