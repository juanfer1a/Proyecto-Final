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
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Para mostrar el menu y cerrar esta ventana
            Menu menu = new Menu();
                menu.Show();
                this.Close();
        }
    }
}
