using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Security.Cryptography;

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

            
            //----------------------------------Cargar usuario-----------------------------------------------
            OdbcCommand cmd2 = new OdbcCommand("Select sUsuario from usuario", conexion.ObtenerConexion());
            OdbcDataReader almacen2 = cmd2.ExecuteReader();
            

            while (almacen2.Read())
            {
                Cmb_usuarioEliminar.Refresh();
                Cmb_usuarioEliminar.Items.Add(almacen2.GetValue(0).ToString());
                Cmb_usuario.Refresh();
                Cmb_usuario.Items.Add(almacen2.GetValue(0).ToString());
                Cmb_usuarioCambio.Refresh();
                Cmb_usuarioCambio.Items.Add(almacen2.GetValue(0).ToString());
            }
            conexion.ObtenerConexion().Close();
            almacen2.Close();

            try
            {
                //----------------------------------Cargar Privilegio-----------------------------------------------
                OdbcCommand cmd = new OdbcCommand("Select sPrivilegio from privilegio", conexion.ObtenerConexion());
                OdbcDataReader almacen = cmd.ExecuteReader();

                while (almacen.Read())
                {
                    Cmb_privi.Refresh();
                    Cmb_privi.Items.Add(almacen.GetValue(0).ToString());

                }
                conexion.ObtenerConexion().Close();
                almacen2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
           
            






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
            try
            {
                OdbcCommand borrar = new OdbcCommand("delete from usuario where sUsuario = '" + Cmb_usuarioEliminar.SelectedItem.ToString() + "'", conexion.ObtenerConexion());
                borrar.ExecuteNonQuery();
                Txt_privilegio.Text = "";

                //-------------------ELIMINAR-----------------------------------------------------------------//
                OdbcCommand cmd2 = new OdbcCommand("Select sUsuario from usuario", conexion.ObtenerConexion());
                OdbcDataReader almacen2 = cmd2.ExecuteReader();

                Cmb_usuarioEliminar.ResetText();
                Cmb_usuarioEliminar.Items.Clear();
                Cmb_usuario.ResetText();
                Cmb_usuario.Items.Clear();

                while (almacen2.Read())
                {
                    Cmb_usuarioEliminar.Refresh();
                    Cmb_usuarioEliminar.Items.Add(almacen2.GetValue(0).ToString());
                    Cmb_usuario.Refresh();
                    Cmb_usuario.Items.Add(almacen2.GetValue(0).ToString());
                }
                conexion.ObtenerConexion().Close();
                almacen2.Close();

                MessageBox.Show("Usuario eliminado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, no hay usuario seleccionado");
            }
           
        }

        private void Cmb_usuarioEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("select sPrivilegio from privilegio where iIdPrivilegio = (select iIdPrivilegio from usuario where sUsuario = '" + Cmb_usuarioEliminar.SelectedItem.ToString() + "')", conexion.ObtenerConexion());
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_privilegio.ResetText();
                Txt_privilegio.Text = datos.Rows[0][0].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Error Seleccionar");
            }
           
        }

        private void Cmb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tbc_control_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_privi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_cambiar_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcCommand borrar = new OdbcCommand("update usuario set iIdPrivilegio = (select iIdPrivilegio from privilegio where sPrivilegio = '" + Cmb_privi.Text + "') where sUsuario ='" + Cmb_usuario.SelectedItem.ToString() + "'", conexion.ObtenerConexion());
                borrar.ExecuteNonQuery();
                MessageBox.Show("Cambios Realizados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
          
        }

        private void Cmb_usuarioCambio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
               

            }

        public static string EncripContra(string password)
        {
            SHA1 sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] input = (new UnicodeEncoding()).GetBytes(password); byte[] hash = sha1.ComputeHash(input);
            return Convert.ToBase64String(hash);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Variables para poder realizar la consulta
            string user = Cmb_usuarioCambio.Text;
            string pass = EncripContra(Txt_actual.Text);


            //Validar si el usuario y contraseña(actual) es correctos en la Base de Datos
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("select count(*) from usuario where sUsuario='" + user + "'and sContrasena ='" + pass + "'", conexion.ObtenerConexion());
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();
                DataTable datos = new DataTable();
                sda.Fill(datos);

                if (datos.Rows[0][0].ToString() == "1")
                {
                    Pbx_correcto.Visible=true;
                    Txt_nueva.Enabled = true;
                    MessageBox.Show("Usuario Correcto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    conexion.ObtenerConexion().Close();
                }
                else
                {
                    Pbx_incorrecto.Visible = true;
                    MessageBox.Show("Usuario o Contrasena Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cmb_usuarioCambio.ResetText();
                    Txt_actual.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible conectar a la base de datos o tabla no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Realizar update de la contraseña del Usuario
                cmd.CommandText = "update usuario set sContrasena = '" + EncripContra(Txt_nueva.Text) + "' where sUsuario = '" + Convert.ToString(Cmb_usuarioCambio.Text) + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contraseña Modificada", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar la contraseña.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }

            //Limpiar los TEXTBOX y COMBOBOX 
            Cmb_usuarioCambio.ResetText();
            Txt_actual.Clear();
            Txt_nueva.Clear();
            Pbx_correcto.Visible = false;
            Pbx_incorrecto.Visible = false;
        }

        private void Cmb_usuarioCambio_Click(object sender, EventArgs e)
        {
            //Habilitar y Visualizar 
            Gpb_contraseña.Enabled = true;
            Txt_actual.Enabled = true;
            Pbx_incorrecto.Visible = false;
            Pbx_correcto.Visible = false;

        }

        private void Txt_privilegio_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
