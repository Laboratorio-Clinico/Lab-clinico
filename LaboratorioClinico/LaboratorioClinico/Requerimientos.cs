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

namespace LaboratorioClinico
{
    public partial class Requerimientos : Form
    {
        public Requerimientos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Requerimientos_Load(object sender, EventArgs e)
        {
            //******************************Cargar los examenes***********************************************
            OdbcCommand cmd2 = new OdbcCommand("Select sDescripcion from examenes", conexion.ObtenerConexion());
            OdbcDataReader almacen2 = cmd2.ExecuteReader();


            while (almacen2.Read())
            {
                Cmb_examen.Refresh();
                Cmb_examen.Items.Add(almacen2.GetValue(0).ToString());

            }
            conexion.ObtenerConexion().Close();
            almacen2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           /* conexion.ObtenerConexion();
            DataTable dtDatos = new DataTable();
            OdbcDataAdapter sda = new OdbcDataAdapter("select *from examenes where sDescripcion='" + Convert.ToString(Txt_nombrer.Text) + "'", conexion.ObtenerConexion());
            sda.Fill(dtDatos);
            int a = 1;
            try
            {                
                    Dgb_requisitosr.DataSource = dtDatos;
                
            }catch (Exception ex){

                MessageBox.Show("No se encuentra el examen intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_nombrer.ResetText();

            }*/
           
          
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
