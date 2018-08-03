using System.Data.Odbc;
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
    public partial class Exámen : Form
    {
        public Exámen()
        {
            InitializeComponent();
            proCargaDatos();
        }
        
        public void proCargaDatos() //Consulta para que el precio que aparezca en el examen, sea el más reciente.
        {
            try
            {
                conexion.ObtenerConexion();

                OdbcCommand sda = new OdbcCommand("Select iIdExamen, sDescripcion, fPrecio from examenes", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(sda);
                DataTable dato = new DataTable();
                adaptador.Fill(dato);

                
                conexion.ObtenerConexion().Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exámen_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Picb_paciente_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
