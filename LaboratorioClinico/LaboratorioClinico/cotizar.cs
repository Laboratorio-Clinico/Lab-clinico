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
    public partial class cotizar : Form
    {
        public cotizar()
        {
            InitializeComponent();
            proLlenareExamen();
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

            try
            {
                Cmb_examen.Text = "Seleccione el examen que desea buscar";
                Cmb_examen.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("Select iIdExamen, sDescripcion from Examenes", conexion.ObtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_examen.ValueMember = "iIdExamen";
                Cmb_examen.DisplayMember = "sDescripcion";

                Cmb_examen.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }

        }
        public void proLlenareDoctor()
        {


            try
            {
                Cmb__doctor.Text = "Seleccione el doctor que desea buscar";
                Cmb__doctor.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("proVerDoctores", conexion.ObtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb__doctor.ValueMember = "iIdEmpleado";
                Cmb__doctor.DisplayMember = "sNombre";

                Cmb__doctor.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
        }

        public void proBuscarCotizacion(int iIdExamen, int iIdEmpleado) {
            try
            {
                MySqlCommand comando= new MySqlCommand("Pro_cotizacionDeExamenes", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("iIdExamen", iIdExamen);
                comando.Parameters.AddWithValue("iIdEmpleado", iIdEmpleado);
                conexion.ObtenerConexion().Open();
                comando.ExecuteNonQuery();
                DataTable tabla = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(tabla);
                Dgv_verDatos.DataSource = tabla;
            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }
          


        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
           int iIdExamen = Convert.ToInt32(Cmb_examen.SelectedValue);
           int iIdEmpleado = Convert.ToInt32(Cmb__doctor.SelectedValue);
            proBuscarCotizacion(iIdExamen, iIdEmpleado);




        }

        private void Btn_requisitos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requerimientos requerimiento = new Requerimientos();
            requerimiento.ShowDialog();
            this.Show();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
