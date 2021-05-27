﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final
{
    class Conexion
    {
        string conecxionSting;

        //Metodo para ejecutar las consultas en la DB
        public void conectarComando(string comando)
        {
            //Conectamos con el servidos
            //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conectar);
            conecxionSting = "Data Source=sql5104.site4now.net;Initial Catalog=db_a73994_proyecto;Persist Security Info=True;User ID=db_a73994_proyecto_admin;Password=parcero89";
            SqlConnection conexion = new SqlConnection(conecxionSting);
            try
            {
                //Abrimos la conexión con la DB
                conexion.Open();
                MessageBox.Show("Bien");
                //Ejecutamos los comandos
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                //Cerramos la conexión con la DB
                conexion.Close();
            }
            catch (Exception ex)
            {
           
                MessageBox.Show("mal"+ex.Message);
                throw;
            }
            
        }

        //Metodo para mostrar los datos en un DatagridView
        public void MostrarTabla(string comando, DataGridView datagrid)
        {
            //Conectamos con el servidos
            conecxionSting = "Data Source=sql5104.site4now.net;Initial Catalog=db_a73994_proyecto;Persist Security Info=True;User ID=db_a73994_proyecto_admin;Password=parcero89";
            SqlConnection conexion = new SqlConnection(conecxionSting);

            SqlCommand cmd = new SqlCommand(comando, conexion);
            //Estamos tomando la conexión y la consultada de la variable "traer todo"
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            //Representación de una tabla en memoria 
            DataTable tabla = new DataTable();
            //llenamos tabla con los datos consigandos en la data 
            data.Fill(tabla);
            //Mostramos en el datagrid
            datagrid.DataSource = tabla;

        }

    }
}
