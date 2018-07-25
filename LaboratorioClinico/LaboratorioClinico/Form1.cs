using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioClinico
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
            Txt_usuario.Focus();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public static string EncripContra(string password)
        {
            SHA1 sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] input = (new UnicodeEncoding()).GetBytes(password); byte[] hash = sha1.ComputeHash(input);
            return Convert.ToBase64String(hash);

        }
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            BorrarMsj();
            Validar();
            string user = Txt_usuario.Text;
            string pass = EncripContra(Txt_contraseña.Text);
            string tipo;


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from usuario where sUsuario='" + user + "'and sContrasena ='" + pass + "'", conexion.ObtenerConexion());
                MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();
                DataTable datos = new DataTable();
                sda.Fill(datos);

                if (datos.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Usuario Correcto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    
                   
                    try
                    {
                        //--------------------------Saber privilegio--------------------------------
                        MySqlDataAdapter sda2 = new MySqlDataAdapter("select sPrivilegio from privilegio where iIdPrivilegio = (select iIdPrivilegio from usuario where sUsuario = '" + Txt_usuario.Text + "')", conexion.ObtenerConexion());
                        MySqlCommand cmd2 = conexion.ObtenerConexion().CreateCommand();
                        DataTable datos2 = new DataTable();
                        sda2.Fill(datos2);


                        tipo = datos2.Rows[0][0].ToString();
                        

                        this.Hide();
                        Menu abrir = new Menu(user, tipo);
                        abrir.ShowDialog();
                        Txt_usuario.ResetText();
                        Txt_contraseña.ResetText();
                        this.Show();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error");
                    }
                   


                }
                else
                {
                    MessageBox.Show("Usuario o Contrasena Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_usuario.ResetText();
                    Txt_contraseña.ResetText();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Imposible conectar a la base de datos o tabla no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private bool Validar()
        {
            bool bValor = true;

            if (Txt_usuario.Text == "")
            {
                bValor = false;
                Er_validar.SetError(Txt_usuario, "Ingrese Usuario");
            } 

            if (Txt_contraseña.Text == "")
            {
                bValor = false;
                Er_validar.SetError(Txt_contraseña, "Ingrese Contraseña");
            }
            return bValor;
        }

        private void BorrarMsj()
        {
            Er_validar.SetError(Txt_contraseña, "");
            Er_validar.SetError(Txt_usuario, "");
        }

        private void Cbo_privi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_contraseña_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_usuario_Enter(object sender, EventArgs e)
        {
            if (Txt_usuario.Text == "Usuario") {
                Txt_usuario.Text = "";
                Txt_usuario.ForeColor = Color.MidnightBlue;
            }
        }

        private void Txt_usuario_Leave(object sender, EventArgs e)
        {
            if (Txt_usuario.Text == "")
            {
                Txt_usuario.Text = "Usuario";
                Txt_usuario.ForeColor = Color.CornflowerBlue;
            }
        }

        private void Txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (Txt_contraseña.Text == "Contraseña")
            {
                Txt_contraseña.Text = "";
                Txt_contraseña.ForeColor = Color.MidnightBlue;
                Txt_contraseña.PasswordChar = '*';
            }
        }

        private void Txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (Txt_contraseña.Text == "")
            {
                Txt_contraseña.Text = "Contraseña";
                Txt_contraseña.ForeColor = Color.CornflowerBlue;
                Txt_contraseña.PasswordChar = ' ';
            }
        }

        private void Txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
