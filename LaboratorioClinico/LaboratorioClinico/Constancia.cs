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
    public partial class Constancia : Form
    {
        public Constancia()
        {
            InitializeComponent();
        }

        private void Lbl_direccionf_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_nombref_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_imprimirr_Click(object sender, EventArgs e)
        {

        }

        private void Btn_busc_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT sNombre, sNit, sDireccion FROM paciente WHERE nIdPaciente ='" + Convert.ToInt64(Txt_dpir.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);


                Txt_nombrer.Text = datos.Rows[0][0].ToString();
                Txt_direccionr.Text = datos.Rows[0][1].ToString();
                Txt_nitc.Text = datos.Rows[0][2].ToString();

                OdbcDataAdapter sda2 = new OdbcDataAdapter("SELECT iIdCitas, dFecha FROM citas WHERE nNoExpediente ='" + Convert.ToInt64(Txt_dpir.Text) + "'", conexion.ObtenerConexion());
                DataTable datos2 = new DataTable();
                sda2.Fill(datos2);

                Txt_cita.Text = datos2.Rows[0][0].ToString();
                Txt_fechae.Text = datos2.Rows[0][1].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar paciente..");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Txt_fechae_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
