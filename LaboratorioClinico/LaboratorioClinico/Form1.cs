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

            string user = Txt_usuario.Text;
            string pass = Txt_contraseña.Text;


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from usuario where usuario='" + user + "'and contraseña ='" + pass + "'", conexion.ObtenerConexion());
                MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();
                DataTable datos = new DataTable();
                sda.Fill(datos);

                if (datos.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Usuario Correcto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Txt_usuario.ResetText();
                    Txt_contraseña.ResetText();


                    this.Hide();
                    Menu abrir = new Menu(user);
                    abrir.ShowDialog();
                    this.Show();


                }
                else
                {
                    MessageBox.Show("Usuario o Contrasena Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Imposible conectar a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void Cbo_privi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
