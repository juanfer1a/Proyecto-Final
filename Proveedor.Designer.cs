namespace Proyecto_Final
{
    partial class Proveedor
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
            this.lblNit = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCta = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresarUsuario = new System.Windows.Forms.Button();
            this.dtgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(251, 87);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(28, 17);
            this.lblNit.TabIndex = 22;
            this.lblNit.Text = "Nit";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(251, 126);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 17);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCta
            // 
            this.lblCta.AutoSize = true;
            this.lblCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCta.Location = new System.Drawing.Point(251, 173);
            this.lblCta.Name = "lblCta";
            this.lblCta.Size = new System.Drawing.Size(106, 17);
            this.lblCta.TabIndex = 20;
            this.lblCta.Text = "Cta. Bancaria";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(251, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 17);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCta
            // 
            this.txtCta.Location = new System.Drawing.Point(36, 172);
            this.txtCta.Name = "txtCta";
            this.txtCta.Size = new System.Drawing.Size(132, 20);
            this.txtCta.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(36, 126);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 20);
            this.txtTel.TabIndex = 3;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(36, 86);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(132, 20);
            this.txtNit.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(36, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(36, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 26);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarUsuario
            // 
            this.btnRegresarUsuario.Location = new System.Drawing.Point(15, 398);
            this.btnRegresarUsuario.Name = "btnRegresarUsuario";
            this.btnRegresarUsuario.Size = new System.Drawing.Size(153, 31);
            this.btnRegresarUsuario.TabIndex = 23;
            this.btnRegresarUsuario.Text = "Regresar Usuario";
            this.btnRegresarUsuario.UseVisualStyleBackColor = true;
            this.btnRegresarUsuario.Click += new System.EventHandler(this.btnRegresarUsuario_Click);
            // 
            // dtgvMostrar
            // 
            this.dtgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMostrar.Location = new System.Drawing.Point(388, 28);
            this.dtgvMostrar.Name = "dtgvMostrar";
            this.dtgvMostrar.Size = new System.Drawing.Size(400, 349);
            this.dtgvMostrar.TabIndex = 24;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(215, 260);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 26);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(215, 325);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 26);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtgvMostrar);
            this.Controls.Add(this.btnRegresarUsuario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCta);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtNombre);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCta;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresarUsuario;
        private System.Windows.Forms.DataGridView dtgvMostrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}