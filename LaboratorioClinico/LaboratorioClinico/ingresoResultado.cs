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
    public partial class ingresoResultado : Form
    {
        public ingresoResultado()
        {
            InitializeComponent();
        }

        private void Btn_busc_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, pa.sDireccion FROM paciente pa WHERE pa.nIdPaciente='" + Convert.ToString(Txt_dpir.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_nombrer.Text = datos.Rows[0][0].ToString();
                Txt_direccionr.Text = datos.Rows[0][1].ToString();
             

            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Paciente no registrado.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_BuscarExamen_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT ex.sDescripcion FROM examenes ex WHERE ex.iIdExamen='" + Convert.ToString(Txt_codEx.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_nombrex.Text = datos.Rows[0][0].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Código no encontrado.", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dtp_fechar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
