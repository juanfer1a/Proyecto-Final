namespace Proyecto_Final
{
    partial class Menu
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
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnPromociones = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(79, 50);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(89, 24);
            this.btnVentas.TabIndex = 7;
            this.btnVentas.Text = "&Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Location = new System.Drawing.Point(238, 183);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(89, 24);
            this.btnCaja.TabIndex = 8;
            this.btnCaja.Text = "&Caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnPromociones
            // 
            this.btnPromociones.Location = new System.Drawing.Point(238, 118);
            this.btnPromociones.Name = "btnPromociones";
            this.btnPromociones.Size = new System.Drawing.Size(89, 24);
            this.btnPromociones.TabIndex = 9;
            this.btnPromociones.Text = "&Promociones";
            this.btnPromociones.UseVisualStyleBackColor = true;
            this.btnPromociones.Click += new System.EventHandler(this.btnPromociones_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(238, 50);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(89, 24);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "&Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(79, 265);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(89, 24);
            this.btnInventario.TabIndex = 11;
            this.btnInventario.Text = "&Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(79, 183);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(89, 24);
            this.btnFacturacion.TabIndex = 12;
            this.btnFacturacion.Text = "&Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(79, 118);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(89, 24);
            this.btnUsuarios.TabIndex = 13;
            this.btnUsuarios.Text = "&Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnPromociones);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnVentas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnPromociones;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnUsuarios;
    }
}