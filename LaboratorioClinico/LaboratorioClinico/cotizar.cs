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
    public partial class cotizar : Form
    {
        public cotizar()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void proLlenareExamen() {


            try {
                Cmb_examen.Text = "Seleccione el examen que desea buscar";
                Cmb_examen.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand("Select descripcion from examenes", conexion.ObtenerConexion());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.fill(dt);

                Cmb_examen.ValueMember = "codigo";
                Cmb_examen.DisplayMember = "descripcion";

                Cmb_examen.DataSource = dt;

                conexion.ObtenerConexion.Close();

            } catch (MySqlException error) { MessageBox.Show(error.Message); }
        }
        public void proLlenareDoctor()
        {


            try
            {
                Cmb__doctor.Text = "Seleccione el doctor que desea buscar";
                Cmb__doctor.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand("proVerDoctores", conexion.ObtenerConexion());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.fill(dt);

                Cmb__doctor.ValueMember = "idEmpleado";
                Cmb__doctor.DisplayMember = "nombre";

                Cmb__doctor.DataSource = dt;

                conexion.ObtenerConexion.Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {


        }

        private void Btn_requisitos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requerimientos requerimiento = new Requerimientos();
            requerimiento.ShowDialog();
            this.Show();
        }
    }
}
