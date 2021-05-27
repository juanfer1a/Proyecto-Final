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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }
        
        //Instanciamos todas las ventanas del Menu para poder llamar las ventanas
            Ventas ventas = new Ventas();
            Usuarios usuarios = new Usuarios();
            Inventario inventario = new Inventario();
            Facturacion facturacion = new Facturacion();
            frm_Reportes reportes = new frm_Reportes();
            Promociones promociones = new Promociones();
            Caja caja = new Caja();

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Abrir la ventana
            ventas.Show();
            //Cerrar esta ventana
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            usuarios.Show();
            
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
            facturacion.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            inventario.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            reportes.Show();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            this.Close();
            promociones.Show();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            this.Close();
            caja.Show();
        }
    }
}
