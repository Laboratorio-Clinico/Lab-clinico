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
            Tbc_paciente.Visible = false;
            Tbc_medicos.Visible = false;
            Tbc_examen.Visible = false;
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
            try
            {
                Pnl_eliminarP.Visible = true;
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT pa.sNombre, te.iTelefono, pa.sNit, sa.iIdTipoDeSangre, pa.sDireccion, co.sCorreo, pa.sAlergia, pa.sRefiere, pa.sGenero'" +
                                                            "' FROM paciente pa, telefono te, correo co, tipodesangre sa, alergias al'" +
                                                            "'WHERE pa.nIdPaciente = te.nDPI AND pa.nIdPaciente = co.nDPI AND pa.nIdPaciente = sa.iIdTipoDeSangre AND'" +
                                                            "'pa.nIdPaciente='" + Convert.ToInt32(Txt_expedientep.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);
                Txt_nombrep.Text = datos.Rows[0][0].ToString();
                Txt_telefonop.Text = datos.Rows[0][1].ToString();
                Txt_nitp.Text = datos.Rows[0][2].ToString();
                Txt_tsangrep.Text = datos.Rows[0][3].ToString();
                Txt_direccionp.Text = datos.Rows[0][4].ToString();
                Txt_correoP.Text = datos.Rows[0][5].ToString(); ;
                Txt_alergiasp.Text = datos.Rows[0][6].ToString();
                Txt_refierep.Text = datos.Rows[0][7].ToString();
                Cmb_sexop.Text = datos.Rows[0][8].ToString();

                Txt_expe.Enabled = false;
                Txt_nombrep.Enabled = false;
                Txt_telefonop.Enabled = false;
                Txt_nitp.Enabled = false;
                Txt_tsangrep.Enabled = false;
                Txt_direccionp.Enabled = false;
                Txt_correoP.Enabled = false;
                Txt_alergiasp.Enabled = false;
                Txt_refierep.Enabled = false;
                Cmb_sexop.Enabled = false;

            }
            catch(Exception ex)
            {

            }



       

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Pnl_modificarP.Visible = true;
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT pa.sNombre, te.iTelefono, pa.sNit, sa.iIdTipoDeSangre, pa.sDireccion, co.sCorreo, pa.sAlergia, pa.sRefiere, pa.sGenero'" + 
                                                            "' FROM paciente pa, telefono te, correo co, tipodesangre sa'" +
                                                            "'WHERE pa.nIdPaciente = te.nDPI AND pa.nIdPaciente = co.nDPI AND pa.nIdPaciente = sa.iIdTipoDeSangre AND'"+
                                                            "'pa.nIdPaciente='" + Convert.ToInt32(Txt_expe.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);
                Txt_nombre.Text = datos.Rows[0][0].ToString();
                Txt_telefono.Text = datos.Rows[0][1].ToString();
                Txt_nit.Text = datos.Rows[0][2].ToString();
                Txt_tipoSangre.Text = datos.Rows[0][3].ToString();
                Txt_direccion.Text = datos.Rows[0][4].ToString();
                Txt_correo.Text = datos.Rows[0][5].ToString(); ;
                Txt_alergias.Text = datos.Rows[0][6].ToString();
                Txt_refiere.Text = datos.Rows[0][7].ToString();
                Cmb_sexo.Text = datos.Rows[0][8].ToString();

                Txt_expe.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Btn_editarp_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ObtenerConexion();
                MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();
                cmd.CommandText = "update paciente set sNombre = '" + Txt_nombre.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update telefono set iTelefono = '" + Txt_telefono.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sNit = '" + Txt_nit.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set iIdTipoDeSangre = '" + Txt_tipoSangre.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sDireccion = '" + Txt_direccion.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update correo set sCorreo = '" + Txt_correo.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sAlergia = '" + Txt_alergias.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sRefiere = '" + Txt_refiere.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sGenero = '" + Cmb_sexo.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Modificado Exitosamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Btn_eliminarp_Click(object sender, EventArgs e)
        {
            conexion.ObtenerConexion(); 
            MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();

            cmd.CommandText = "delete from paciente where expedientep = '" + Convert.ToInt64(Txt_expe.Text) + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliente Eliminado Exitosamente");
        }

        private void Cmb_tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_tabla.SelectedItem.ToString() == "Paciente")
            {
                Tbc_paciente.Visible = true;
                Tbc_medicos.Visible = false;
                Tbc_examen.Visible = false;
            
            }
            else if(Cmb_tabla.SelectedItem.ToString() == "Médico Asociado")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = true;
                Tbc_examen.Visible = false;
              
            }
            else if (Cmb_tabla.SelectedItem.ToString() == "Exámen")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = false;
                Tbc_examen.Visible = true;
            }
        }
    }
}
