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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void Gpb_mantenimiento_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_tsangrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_eliminarm_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gpb_datosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("select nombrep, telefonop, nirp,tiposangrep,direccionp,correop,alergiasp, quienRefp,sexop from paciente where expedientep='" + Convert.ToInt32(Txt_expe.Text) + "'", conexion.ObtenerConexion());
            DataTable datos = new DataTable();
            sda.Fill(datos);
            Txt_nombre.Text = datos.Rows[0][0].ToString();
            Txt_telefono.Text = datos.Rows[0][1].ToString();
            Txt_tipoSangre.Text = datos.Rows[0][2].ToString();
            Txt_direccion.Text = datos.Rows[0][3].ToString();
            Txt_correo.Text = datos.Rows[0][4].ToString();
            Txt_alergias.Text = datos.Rows[0][5].ToString();
            Txt_refiere.Text = datos.Rows[0][6].ToString();
            Cmb_sexo.Text = datos.Rows[0][7].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("select nombrep, telefonop, nirp,tiposangrep,direccionp,correop,alergiasp, quienRefp,sexop from paciente where expedientep='" + Convert.ToInt32(Txt_expe.Text) + "'", conexion.ObtenerConexion());
            DataTable datos = new DataTable();
            sda.Fill(datos);
            Txt_nombre.Text = datos.Rows[0][0].ToString();
            Txt_telefono.Text = datos.Rows[0][1].ToString();
            Txt_tipoSangre.Text = datos.Rows[0][2].ToString();
            Txt_direccion.Text = datos.Rows[0][3].ToString();
            Txt_correo.Text = datos.Rows[0][4].ToString();
            Txt_alergias.Text = datos.Rows[0][5].ToString();
            Txt_refiere.Text = datos.Rows[0][6].ToString();    
            Cmb_sexo.Text = datos.Rows[0][7].ToString();
        }

        private void Btn_editarp_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion();
            MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();
            cmd.CommandText = "update paciente set nombrep = '" + Txt_nombre.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update paciente set telefonop = '" + Txt_telefono.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update paciente set nitp = '" + Txt_nit.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update paciente set tipoSangrep = '" + Txt_tipoSangre.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update paciente set direccionp = '" + Txt_direccion.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update paciente set correop = '" + Txt_correo.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update paciente set alergiasp = '" + Txt_alergias.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update paciente set quienRefp = '" + Txt_refiere.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update paciente set sexop = '" + Cmb_sexo.Text + "' where expedientep = '" + Convert.ToInt32(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Cliente Modificado Exitosamente.");

        }

        private void Btn_eliminarp_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion(); 
            MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();

            cmd.CommandText = "delete from paciente where expedientep = '" + Convert.ToInt64(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliente Eliminado Exitosamente");
        }
    }
}
