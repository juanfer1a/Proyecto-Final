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
    public partial class frm_Reportes : Form
    {
        public frm_Reportes()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
        
        private void btnReporVentas_Click(object sender, EventArgs e)
        {
            //Hacemos visible el panel
            pnlVentas.Visible = true;

        }

        //Boton cerrar del panel reporte ventas
        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            pnlVentas.Visible = false;
        }

        private void btnHMovimientos_Click(object sender, EventArgs e)
        {
            //Hacemos visible el panel
            pnlMovimientos.Visible = true;
        }

        //Boton cerrar del panel historial de movimientos
        private void btnCerrarMove_Click(object sender, EventArgs e)
        {
            pnlMovimientos.Visible = false;
        }

        private void btnGBalance_Click(object sender, EventArgs e)
        {
            //Hacemos visible el panel
            pnlBalance.Visible = true;
        }

        //Boton cerrar del panel generar balance
        private void btnCerrarBalance_Click(object sender, EventArgs e)
        {
            pnlBalance.Visible = false;
        }

        
    }

}
