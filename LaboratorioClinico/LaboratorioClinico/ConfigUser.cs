using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LaboratorioClinico
{
    public partial class ConfigUser : Form
    {
        public ConfigUser()
        {
            InitializeComponent();
        }

        private void ConfigUser_Load(object sender, EventArgs e)
        {

            
            //----------------------------------Eliminar usuario-----------------------------------------------
            MySqlCommand cmd2 = new MySqlCommand("Select sUsuario from usuario", conexion.ObtenerConexion());
            MySqlDataReader almacen2 = cmd2.ExecuteReader();

            while (almacen2.Read())
            {
                Cmb_usuarioEliminar.Refresh();
                Cmb_usuarioEliminar.Items.Add(almacen2.GetValue(0).ToString());
            }
            conexion.ObtenerConexion().Close();
            almacen2.Close();
            
            
           



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tbc_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            MySqlCommand borrar = new MySqlCommand("delete from usuario where sUsuario = '" + Cmb_usuarioEliminar.SelectedItem.ToString() + "'", conexion.ObtenerConexion());
            borrar.ExecuteNonQuery();


          
            MySqlCommand cmd2 = new MySqlCommand("Select sUsuario from usuario", conexion.ObtenerConexion());
            MySqlDataReader almacen2 = cmd2.ExecuteReader();

            Cmb_usuarioEliminar.ResetText();
            Cmb_usuarioEliminar.Items.Clear();

            while (almacen2.Read())
            {
                Cmb_usuarioEliminar.Refresh();
                Cmb_usuarioEliminar.Items.Add(almacen2.GetValue(0).ToString());
            }
            conexion.ObtenerConexion().Close();
            almacen2.Close();

            MessageBox.Show("Usuario eliminado");
        }

        private void Cmb_usuarioEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MySqlDataAdapter sda = new MySqlDataAdapter("select sPrivilegio from privilegio where iIdPrivilegio = (select iIdPrivilegio from usuario where sUsuario = '"+Cmb_usuarioEliminar.SelectedItem.ToString() +"')", conexion.ObtenerConexion());
            MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();
            DataTable datos = new DataTable();
            sda.Fill(datos);
            

            Txt_privilegio.Text = datos.Rows[0][0].ToString();
        }
    }
}
