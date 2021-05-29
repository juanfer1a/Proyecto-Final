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
        int dia;
        int año;
        int mes;
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


        private void btnGBalance_Click(object sender, EventArgs e)
        {
            //Hacemos visible el panel
            pnlBalance.Visible = true;
        }

        
      

        public void obtenFecha(DateTimePicker dateTime)
        {
            dia = (int)dateTime.Value.Day;
            mes = (int)dateTime.Value.Month;
            año = (int)dateTime.Value.Year;
        }

        private void btnGenerarReporVentas_Click(object sender, EventArgs e)
        {
            obtenFecha(datPDesdeVentas);
            lblPruebas.Text = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();
            obtenFecha(datPHastaVentas);
            lblPruebaHasta.Text = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();
            // lblPruebas.Text = datPDesdeVentas.Text;
        }

        private void btnGenerarBalance_Click(object sender, EventArgs e)
        {

            obtenFecha(datPDesdeBalance);
            lblPruebas.Text = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();
            obtenFecha(datPHastaBalance);
            lblPruebaHasta.Text = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();
            // lblPruebas.Text = datPDesdeVentas.Text;
        }

        private void btnGenerarReporMovi_Click(object sender, EventArgs e)
        {

            obtenFecha(datPDesdeMovimientos);
            lblPruebas.Text = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();
            obtenFecha(datPHastaMovimientos);
            lblPruebaHasta.Text = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();
            // lblPruebas.Text = datPDesdeVentas.Text;
        }

        private void btnCerrarBalance_Click(object sender, EventArgs e)
        {
            pnlBalance.Hide();
        }

        private void btnCerrarMove_Click(object sender, EventArgs e)
        {
            pnlMovimientos.Hide();
        }
    }

}
