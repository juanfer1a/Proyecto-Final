using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
             Menu menu = new Menu();
             menu.Show();
             this.Close();
        }

         //BLOQUE DEL BOTÓN INSUMOS  
        private void btnInsumos_Click(object sender, EventArgs e)
        {
            //Abrimos el panel
            pnlInsumos.Visible = true;
        }

        private void btnAceptarInsumos_Click(object sender, EventArgs e)
        {

            pnlInsumos.Visible = false;
        }

        private void btnCerrarInsumos_Click(object sender, EventArgs e)
        {
            //Cerramos el panel
            pnlInsumos.Visible = false;
        }
        
        private void btnRegistrarInsumos_Click(object sender, EventArgs e)
        {
            //Conexión a base de datos
            pnlRegistrar.Visible = Visible;

        }

        private void btnTraerTodo_Click(object sender, EventArgs e)
        {
            //Conexión a base de datos
        }

        //BLOQUE DEL BOTÓN PROVEEDOR
        private void btnTraerProveedor_Click(object sender, EventArgs e)
        {
            //Conexión a base de datos
        }

        private void btnAceptarProveedor_Click(object sender, EventArgs e)
        {
            pnlProveedor.Visible = false;
        }

        private void btnCerrarProveedor_Click(object sender, EventArgs e)
        {
            pnlProveedor.Visible = false;            
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            pnlProveedor.Visible = true;  
        }

        //BLOQUE DE CREAR PRODUCTO
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Base de datos
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlProducto.Visible = false;  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlProducto.Visible = false;  
        }
         private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            pnlProducto.Visible = true;  
        }

        //BLOQUE REGISTRAR INSUMOS
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Base de datos
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = false;  
        }

        private void btnCerrarRegistrar_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = false;  
        }

       
    }
}
