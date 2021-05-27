namespace Proyecto_Final
{
    partial class Inventario
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
            this.dtgvInventario = new System.Windows.Forms.DataGridView();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlInsumos = new System.Windows.Forms.Panel();
            this.btnRegistrarInsumos = new System.Windows.Forms.Button();
            this.btnCerrarInsumos = new System.Windows.Forms.Button();
            this.btnAceptarInsumos = new System.Windows.Forms.Button();
            this.btnTraerTodo = new System.Windows.Forms.Button();
            this.txtInsumos = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pnlProveedor = new System.Windows.Forms.Panel();
            this.btnCerrarProveedor = new System.Windows.Forms.Button();
            this.btnAceptarProveedor = new System.Windows.Forms.Button();
            this.btnTraerProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblBuscarProveedor = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.dtgvListaInsumos = new System.Windows.Forms.DataGridView();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCrearProducto = new System.Windows.Forms.Label();
            this.lblListaInsumos = new System.Windows.Forms.Label();
            this.dtgvProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCostoProducto = new System.Windows.Forms.TextBox();
            this.pnlRegistrar = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrar = new System.Windows.Forms.Button();
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtRegistrarProducto = new System.Windows.Forms.TextBox();
            this.lblNombreRegistar = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventario)).BeginInit();
            this.pnlInsumos.SuspendLayout();
            this.pnlProveedor.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).BeginInit();
            this.pnlRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(471, 373);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(95, 42);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "&Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dtgvInventario
            // 
            this.dtgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInventario.Location = new System.Drawing.Point(34, 27);
            this.dtgvInventario.Name = "dtgvInventario";
            this.dtgvInventario.Size = new System.Drawing.Size(310, 335);
            this.dtgvInventario.TabIndex = 2;
            // 
            // btnInsumos
            // 
            this.btnInsumos.Location = new System.Drawing.Point(471, 33);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(95, 55);
            this.btnInsumos.TabIndex = 3;
            this.btnInsumos.Text = "Insumos o M. prima";
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(471, 120);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(95, 55);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(471, 209);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(95, 55);
            this.btnCrearProducto.TabIndex = 5;
            this.btnCrearProducto.Text = "Crear Productos";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(209, 383);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(53, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 32);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // pnlInsumos
            // 
            this.pnlInsumos.Controls.Add(this.btnRegistrarInsumos);
            this.pnlInsumos.Controls.Add(this.btnCerrarInsumos);
            this.pnlInsumos.Controls.Add(this.btnAceptarInsumos);
            this.pnlInsumos.Controls.Add(this.btnTraerTodo);
            this.pnlInsumos.Controls.Add(this.txtInsumos);
            this.pnlInsumos.Controls.Add(this.lblBuscar);
            this.pnlInsumos.Location = new System.Drawing.Point(34, 368);
            this.pnlInsumos.Name = "pnlInsumos";
            this.pnlInsumos.Size = new System.Drawing.Size(326, 167);
            this.pnlInsumos.TabIndex = 8;
            this.pnlInsumos.Visible = false;
            // 
            // btnRegistrarInsumos
            // 
            this.btnRegistrarInsumos.Location = new System.Drawing.Point(219, 117);
            this.btnRegistrarInsumos.Name = "btnRegistrarInsumos";
            this.btnRegistrarInsumos.Size = new System.Drawing.Size(104, 27);
            this.btnRegistrarInsumos.TabIndex = 5;
            this.btnRegistrarInsumos.Text = "Registrar";
            this.btnRegistrarInsumos.UseVisualStyleBackColor = true;
            this.btnRegistrarInsumos.Click += new System.EventHandler(this.btnRegistrarInsumos_Click);
            // 
            // btnCerrarInsumos
            // 
            this.btnCerrarInsumos.Location = new System.Drawing.Point(109, 117);
            this.btnCerrarInsumos.Name = "btnCerrarInsumos";
            this.btnCerrarInsumos.Size = new System.Drawing.Size(104, 27);
            this.btnCerrarInsumos.TabIndex = 4;
            this.btnCerrarInsumos.Text = "Cerrar";
            this.btnCerrarInsumos.UseVisualStyleBackColor = true;
            this.btnCerrarInsumos.Click += new System.EventHandler(this.btnCerrarInsumos_Click);
            // 
            // btnAceptarInsumos
            // 
            this.btnAceptarInsumos.Location = new System.Drawing.Point(10, 117);
            this.btnAceptarInsumos.Name = "btnAceptarInsumos";
            this.btnAceptarInsumos.Size = new System.Drawing.Size(88, 27);
            this.btnAceptarInsumos.TabIndex = 3;
            this.btnAceptarInsumos.Text = "Aceptar";
            this.btnAceptarInsumos.UseVisualStyleBackColor = true;
            this.btnAceptarInsumos.Click += new System.EventHandler(this.btnAceptarInsumos_Click);
            // 
            // btnTraerTodo
            // 
            this.btnTraerTodo.Location = new System.Drawing.Point(109, 73);
            this.btnTraerTodo.Name = "btnTraerTodo";
            this.btnTraerTodo.Size = new System.Drawing.Size(104, 22);
            this.btnTraerTodo.TabIndex = 2;
            this.btnTraerTodo.Text = "Traer Todo";
            this.btnTraerTodo.UseVisualStyleBackColor = true;
            this.btnTraerTodo.Click += new System.EventHandler(this.btnTraerTodo_Click);
            // 
            // txtInsumos
            // 
            this.txtInsumos.Location = new System.Drawing.Point(145, 22);
            this.txtInsumos.Name = "txtInsumos";
            this.txtInsumos.Size = new System.Drawing.Size(158, 20);
            this.txtInsumos.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(19, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(113, 15);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar M. Prima";
            // 
            // pnlProveedor
            // 
            this.pnlProveedor.Controls.Add(this.btnCerrarProveedor);
            this.pnlProveedor.Controls.Add(this.btnAceptarProveedor);
            this.pnlProveedor.Controls.Add(this.btnTraerProveedor);
            this.pnlProveedor.Controls.Add(this.txtProveedor);
            this.pnlProveedor.Controls.Add(this.lblBuscarProveedor);
            this.pnlProveedor.Location = new System.Drawing.Point(0, 168);
            this.pnlProveedor.Name = "pnlProveedor";
            this.pnlProveedor.Size = new System.Drawing.Size(326, 167);
            this.pnlProveedor.TabIndex = 9;
            this.pnlProveedor.Visible = false;
            // 
            // btnCerrarProveedor
            // 
            this.btnCerrarProveedor.Location = new System.Drawing.Point(214, 117);
            this.btnCerrarProveedor.Name = "btnCerrarProveedor";
            this.btnCerrarProveedor.Size = new System.Drawing.Size(104, 27);
            this.btnCerrarProveedor.TabIndex = 4;
            this.btnCerrarProveedor.Text = "Cerrar";
            this.btnCerrarProveedor.UseVisualStyleBackColor = true;
            this.btnCerrarProveedor.Click += new System.EventHandler(this.btnCerrarProveedor_Click);
            // 
            // btnAceptarProveedor
            // 
            this.btnAceptarProveedor.Location = new System.Drawing.Point(117, 117);
            this.btnAceptarProveedor.Name = "btnAceptarProveedor";
            this.btnAceptarProveedor.Size = new System.Drawing.Size(88, 27);
            this.btnAceptarProveedor.TabIndex = 3;
            this.btnAceptarProveedor.Text = "Aceptar";
            this.btnAceptarProveedor.UseVisualStyleBackColor = true;
            this.btnAceptarProveedor.Click += new System.EventHandler(this.btnAceptarProveedor_Click);
            // 
            // btnTraerProveedor
            // 
            this.btnTraerProveedor.Location = new System.Drawing.Point(3, 117);
            this.btnTraerProveedor.Name = "btnTraerProveedor";
            this.btnTraerProveedor.Size = new System.Drawing.Size(104, 27);
            this.btnTraerProveedor.TabIndex = 2;
            this.btnTraerProveedor.Text = "Traer Todo";
            this.btnTraerProveedor.UseVisualStyleBackColor = true;
            this.btnTraerProveedor.Click += new System.EventHandler(this.btnTraerProveedor_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(149, 22);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(158, 20);
            this.txtProveedor.TabIndex = 1;
            // 
            // lblBuscarProveedor
            // 
            this.lblBuscarProveedor.AutoSize = true;
            this.lblBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProveedor.Location = new System.Drawing.Point(19, 24);
            this.lblBuscarProveedor.Name = "lblBuscarProveedor";
            this.lblBuscarProveedor.Size = new System.Drawing.Size(120, 15);
            this.lblBuscarProveedor.TabIndex = 0;
            this.lblBuscarProveedor.Text = "Buscar Proveedor";
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.txtCostoProducto);
            this.pnlProducto.Controls.Add(this.lblCosto);
            this.pnlProducto.Controls.Add(this.label1);
            this.pnlProducto.Controls.Add(this.dtgvProducto);
            this.pnlProducto.Controls.Add(this.lblListaInsumos);
            this.pnlProducto.Controls.Add(this.dtgvListaInsumos);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Controls.Add(this.txtNombreProducto);
            this.pnlProducto.Controls.Add(this.btnCerrar);
            this.pnlProducto.Controls.Add(this.btnCancelar);
            this.pnlProducto.Controls.Add(this.btnAgregar);
            this.pnlProducto.Controls.Add(this.lblCrearProducto);
            this.pnlProducto.Location = new System.Drawing.Point(403, 33);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(527, 369);
            this.pnlProducto.TabIndex = 10;
            this.pnlProducto.Visible = false;
            // 
            // dtgvListaInsumos
            // 
            this.dtgvListaInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListaInsumos.Location = new System.Drawing.Point(19, 104);
            this.dtgvListaInsumos.Name = "dtgvListaInsumos";
            this.dtgvListaInsumos.Size = new System.Drawing.Size(246, 225);
            this.dtgvListaInsumos.TabIndex = 6;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblProducto.Location = new System.Drawing.Point(16, 49);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(119, 15);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(167, 44);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(158, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(177, 335);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 27);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(101, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 27);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(8, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 27);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCrearProducto
            // 
            this.lblCrearProducto.AutoSize = true;
            this.lblCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearProducto.Location = new System.Drawing.Point(195, 15);
            this.lblCrearProducto.Name = "lblCrearProducto";
            this.lblCrearProducto.Size = new System.Drawing.Size(103, 15);
            this.lblCrearProducto.TabIndex = 0;
            this.lblCrearProducto.Text = "Crear Producto";
            // 
            // lblListaInsumos
            // 
            this.lblListaInsumos.AutoSize = true;
            this.lblListaInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaInsumos.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblListaInsumos.Location = new System.Drawing.Point(16, 86);
            this.lblListaInsumos.Name = "lblListaInsumos";
            this.lblListaInsumos.Size = new System.Drawing.Size(116, 15);
            this.lblListaInsumos.TabIndex = 7;
            this.lblListaInsumos.Text = "Lista de Insumos";
            // 
            // dtgvProducto
            // 
            this.dtgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducto.Location = new System.Drawing.Point(271, 105);
            this.dtgvProducto.Name = "dtgvProducto";
            this.dtgvProducto.Size = new System.Drawing.Size(244, 223);
            this.dtgvProducto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(441, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Producto";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCosto.Location = new System.Drawing.Point(270, 343);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(43, 15);
            this.lblCosto.TabIndex = 10;
            this.lblCosto.Text = "Costo";
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Location = new System.Drawing.Point(319, 339);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.Size = new System.Drawing.Size(158, 20);
            this.txtCostoProducto.TabIndex = 11;
            // 
            // pnlRegistrar
            // 
            this.pnlRegistrar.Controls.Add(this.label2);
            this.pnlRegistrar.Controls.Add(this.txtPrecio);
            this.pnlRegistrar.Controls.Add(this.lblPrecio);
            this.pnlRegistrar.Controls.Add(this.pnlProveedor);
            this.pnlRegistrar.Controls.Add(this.txtMarcaProducto);
            this.pnlRegistrar.Controls.Add(this.lblMarca);
            this.pnlRegistrar.Controls.Add(this.txtCategoria);
            this.pnlRegistrar.Controls.Add(this.lblCategoria);
            this.pnlRegistrar.Controls.Add(this.btnCerrarRegistrar);
            this.pnlRegistrar.Controls.Add(this.btnCancelarRegistro);
            this.pnlRegistrar.Controls.Add(this.btnRegistrar);
            this.pnlRegistrar.Controls.Add(this.txtRegistrarProducto);
            this.pnlRegistrar.Controls.Add(this.lblNombreRegistar);
            this.pnlRegistrar.Location = new System.Drawing.Point(34, 27);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.Size = new System.Drawing.Size(326, 210);
            this.pnlRegistrar.TabIndex = 10;
            this.pnlRegistrar.Visible = false;
            // 
            // btnCerrarRegistrar
            // 
            this.btnCerrarRegistrar.Location = new System.Drawing.Point(207, 180);
            this.btnCerrarRegistrar.Name = "btnCerrarRegistrar";
            this.btnCerrarRegistrar.Size = new System.Drawing.Size(104, 27);
            this.btnCerrarRegistrar.TabIndex = 4;
            this.btnCerrarRegistrar.Text = "Cerrar";
            this.btnCerrarRegistrar.UseVisualStyleBackColor = true;
            this.btnCerrarRegistrar.Click += new System.EventHandler(this.btnCerrarRegistrar_Click);
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.Location = new System.Drawing.Point(113, 180);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(88, 27);
            this.btnCancelarRegistro.TabIndex = 3;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = true;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(3, 180);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 27);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtRegistrarProducto
            // 
            this.txtRegistrarProducto.Location = new System.Drawing.Point(149, 51);
            this.txtRegistrarProducto.Name = "txtRegistrarProducto";
            this.txtRegistrarProducto.Size = new System.Drawing.Size(158, 20);
            this.txtRegistrarProducto.TabIndex = 1;
            // 
            // lblNombreRegistar
            // 
            this.lblNombreRegistar.AutoSize = true;
            this.lblNombreRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRegistar.Location = new System.Drawing.Point(19, 53);
            this.lblNombreRegistar.Name = "lblNombreRegistar";
            this.lblNombreRegistar.Size = new System.Drawing.Size(58, 15);
            this.lblNombreRegistar.TabIndex = 0;
            this.lblNombreRegistar.Text = "Nombre";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(149, 112);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(158, 20);
            this.txtCategoria.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(19, 114);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 15);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Location = new System.Drawing.Point(149, 83);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(158, 20);
            this.txtMarcaProducto.TabIndex = 8;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(19, 85);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 15);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(149, 146);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(158, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(19, 148);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 15);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registrar";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 536);
            this.Controls.Add(this.pnlRegistrar);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.pnlInsumos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnInsumos);
            this.Controls.Add(this.dtgvInventario);
            this.Controls.Add(this.btnMenu);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInventario)).EndInit();
            this.pnlInsumos.ResumeLayout(false);
            this.pnlInsumos.PerformLayout();
            this.pnlProveedor.ResumeLayout(false);
            this.pnlProveedor.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).EndInit();
            this.pnlRegistrar.ResumeLayout(false);
            this.pnlRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dtgvInventario;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel pnlInsumos;
        private System.Windows.Forms.Button btnRegistrarInsumos;
        private System.Windows.Forms.Button btnCerrarInsumos;
        private System.Windows.Forms.Button btnAceptarInsumos;
        private System.Windows.Forms.Button btnTraerTodo;
        private System.Windows.Forms.TextBox txtInsumos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel pnlProveedor;
        private System.Windows.Forms.Button btnCerrarProveedor;
        private System.Windows.Forms.Button btnAceptarProveedor;
        private System.Windows.Forms.Button btnTraerProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblBuscarProveedor;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCrearProducto;
        private System.Windows.Forms.DataGridView dtgvListaInsumos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvProducto;
        private System.Windows.Forms.Label lblListaInsumos;
        private System.Windows.Forms.TextBox txtCostoProducto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Panel pnlRegistrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnCerrarRegistrar;
        private System.Windows.Forms.Button btnCancelarRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtRegistrarProducto;
        private System.Windows.Forms.Label lblNombreRegistar;
        private System.Windows.Forms.Label label2;
    }
}