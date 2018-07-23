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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_guardarp_Click(object sender, EventArgs e)
        {
            MySqlCommand cm;
            cm = new MySqlCommand("InsertaPaciente", conexion.ObtenerConexion());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@expedientep", this.Txt_expedientep.Text);
            cm.Parameters.AddWithValue("@nombrep", this.Txt_nombrep.Text);
            cm.Parameters.AddWithValue("@telefonop", this.Txt_telefonop.Text);
            cm.Parameters.AddWithValue("@nitp", this.Txt_nitp.Text);

            int query = cm.ExecuteNonQuery();
            if (query == 1)
            {
                MessageBox.Show("Paciente guardado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Gpb_guardarp_Enter(object sender, EventArgs e)
        {

        }
    }
}
