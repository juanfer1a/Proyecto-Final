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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Variables para el usuario
        string nombre;
        string contraseña;


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Para llamar la otra ventana
            Menu menu = new Menu();
            
            menu.Show();
            this.Hide();

            
        }





    }
}
