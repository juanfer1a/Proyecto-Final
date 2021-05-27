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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            
            try
            {
                 string mostrarTabla = "select * from tblEmpleado";
                 cn.MostrarTabla(mostrarTabla,dtgvMostrar);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("No se mostro" + ex.Message);
            }
           
            
        }
        //Conectamos con la clase conexión
        Conexion cn= new Conexion();

        private void btnRegresarUsuario_Click(object sender, EventArgs e)
        {
            //Regresar al punto
            Usuarios usuario = new Usuarios();
            usuario.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Falta aun la base de datos
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string guardar_libro = "Insert into tblEmpleado([idCedula],[strNombre],[strApellido],[strDireccion],[intTelefono])" + "values('" + txtIdentificacion.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDir.Text + "','" + txtTel.Text + "')";
                cn.conectarComando(guardar_libro);

                MessageBox.Show("Se guardo la informacion");

                //Mantenemos la tabla refrescada.               
                string mostrarTabla = "select * from tblEmpleado";
                cn.MostrarTabla(mostrarTabla, dtgvMostrar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardo la informacion" + ex.Message);

            }
        }
    }
}
