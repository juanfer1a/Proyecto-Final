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
    public partial class Usuarios : Form
    {
        public Usuarios()
        { 
            InitializeComponent();
            btnRegistar.Enabled = false;
            btnModificar.Enabled=false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
                menu.Show();
                this.Close();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            
            if (cboTipoUsuario.SelectedItem == "Usuario")
            {
                btnRegistar.Enabled = true;
                //Para ir a la ventana de Registrar para el usuario
                Registrar registrar = new Registrar();
                registrar.Show();
                this.Hide();
            }
            else 
            {
                //Para ir a la ventana de Registrar para el proveedor
                Proveedor proveedor = new Proveedor();
                proveedor.Show();
                this.Hide();
            }

                
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboTipoUsuario.SelectedItem == "Usuario")
            {
                btnModificar.Enabled = true;
                //Para ir a la ventana de Registrar para el usuario
                Registrar registrar = new Registrar();
                registrar.Show();
                this.Hide();
            }
            else
            {
                //Para ir a la ventana de Registrar para el proveedor
                Proveedor proveedor = new Proveedor();
                proveedor.Show();
                this.Hide();
            }
        }

        private void cboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Habilitamos el btnRegistrar cuando escojan alguna opcion
            if (true)
            {
                btnModificar.Enabled=true;
            }else
            {
                btnModificar.Enabled=false;
            }

            if (true)
            {
                btnRegistar.Enabled=true;
            }else
            {
                btnRegistar.Enabled=false;
            }


        }
    }
}
