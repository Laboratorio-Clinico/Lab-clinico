using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            /*try
            {
              
                    Menu nuevo = new Menu(Txt_usuario.Text, Cbo_privi.SelectedItem.ToString());
               
                    this.Visible = false;
                    nuevo.ShowDialog() ;
                    this.Visible=true;
               
                
                    
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }*/

            string user = Txt_usuario.Text;
            string pass = Txt_contrasena.Text;
            int privi = 0;



            if (String.Compare(Cmb_privilegio.SelectedItem.ToString(), "Administrador") == 0)
            {
                privi = 1;
            }
            else if (String.Compare(Cmb_privilegio.SelectedItem.ToString(), "UsuarioL") == 0)
            {
                privi = 2;
            }
            else if (String.Compare(Cmb_privilegio.SelectedItem.ToString(), "Usuario") == 0)
            {
                privi = 3;
            }

            MySqlDataAdapter sda = new MySql.Data.MySqlClient.MySqlDataAdapter("select count(*) from usuario where usuario='" + user + "'and contraseña ='" + pass + "'and idprivilegio='" + privi + "'", conexion.ObtenerConexion());
            MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();
            DataTable datos = new DataTable();
            sda.Fill(datos);

            if (datos.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Usuario Correcto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
           


                Txt_usuario.ResetText();
                Txt_contrasena.ResetText();
                Cmb_privilegio.ResetText();

                this.Hide();
                Menu abrir = new Menu(Txt_usuario.Text, Cmb_privilegio.SelectedItem.ToString());
                abrir.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Usuario o Contrasena Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_privi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
