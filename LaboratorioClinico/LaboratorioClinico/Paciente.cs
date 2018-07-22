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
            /*MySqlCommand cm;
            cm = new MySqlCommand("InsertaPaciente", conexionn.conectar());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@nit", this.nitI.Text);
            cm.Parameters.AddWithValue("@nomb", this.nombreI.Text);
            cm.Parameters.AddWithValue("@dire", this.direccionI.Text);
            cm.Parameters.AddWithValue("@tel", this.telefonoI.Text);
            cm.Parameters.AddWithValue("@email", this.emailI.Text);

            int query = cm.ExecuteNonQuery();
            if (query == 1)
            {
                MessageBox.Show("Cliente ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
    }
}
