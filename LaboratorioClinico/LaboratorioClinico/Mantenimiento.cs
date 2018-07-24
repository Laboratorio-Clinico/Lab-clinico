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
            Picb_fondo.Visible = true;
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
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT pa.sNombre, te.iTelefono  , pa.sNit, sa.iIdTipoDeSangre, pa.sDireccion, co.sCorreo, pa.sAlergia, pa.sRefiere, pa.sGenero FROM paciente pa, telefono te, correo co, tipodesangre sa WHERE pa.nIdPaciente = te.nIdPaciente AND pa.nIdPaciente = co.nIdPaciente AND pa.iIdTipoDeSangre = sa.iIdTipoDeSangre AND pa.nIdPaciente='" + Convert.ToInt32(Txt_expedientep.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_nombrep.Text = datos.Rows[0][0].ToString();
                Txt_telefonop.Text = datos.Rows[0][1].ToString();
                Txt_nitp.Text = datos.Rows[0][2].ToString();
                Cmb_tipoSangrep.Text = datos.Rows[0][3].ToString();
                Txt_direccionp.Text = datos.Rows[0][4].ToString();
                Txt_correoP.Text = datos.Rows[0][5].ToString(); ;
                Txt_alergiasp.Text = datos.Rows[0][6].ToString();
                Txt_refierep.Text = datos.Rows[0][7].ToString();
                Cmb_sexop.Text = datos.Rows[0][8].ToString();

                Txt_nombrep.Enabled = false;
                Txt_telefonop.Enabled = false;
                Txt_nitp.Enabled = false;
                Cmb_tipoSangrep.Enabled = false;
                Txt_direccionp.Enabled = false;
                Txt_correoP.Enabled = false;
                Txt_alergiasp.Enabled = false;
                Txt_refierep.Enabled = false;
                Cmb_sexop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Pnl_modificarP.Visible = true;
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT pa.sNombre, te.iTelefono  , pa.sNit, sa.iIdTipoDeSangre, pa.sDireccion, co.sCorreo, pa.sAlergia, pa.sRefiere, pa.sGenero FROM paciente pa, telefono te, correo co, tipodesangre sa WHERE pa.nIdPaciente = te.nIdPaciente AND pa.nIdPaciente = co.nIdPaciente AND pa.iIdTipoDeSangre = sa.iIdTipoDeSangre AND pa.nIdPaciente='" + Convert.ToInt32(Txt_expe.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_nombre.Text = datos.Rows[0][0].ToString();
                Txt_telefono.Text = datos.Rows[0][1].ToString();
                Txt_nit.Text = datos.Rows[0][2].ToString();
                Cmb_tipoSangre.Text = datos.Rows[0][3].ToString();
                Txt_direccion.Text = datos.Rows[0][4].ToString();
                Txt_correo.Text = datos.Rows[0][5].ToString(); ;
                Txt_alergias.Text = datos.Rows[0][6].ToString();
                Txt_refiere.Text = datos.Rows[0][7].ToString();
                Cmb_sexo.Text = datos.Rows[0][8].ToString();

                Txt_expe.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
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
                cmd.CommandText = "update paciente set iIdTipoDeSangre = '" + Cmb_tipoSangre.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
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

                MessageBox.Show("Paciente Modificado Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                Txt_expe.Enabled = true;
                Txt_expe.Clear();

                Txt_nombre.Clear();
                Txt_telefono.Clear();
                Txt_nit.Clear();
                Cmb_tipoSangre.ResetText(); Cmb_tipoSangre.Items.Clear();
                Txt_direccion.Clear();
                Txt_correo.Clear();
                Txt_alergias.Clear();
                Txt_refiere.Clear();
                Cmb_sexo.ResetText();  Cmb_sexo.Items.Clear(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_eliminarp_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ObtenerConexion();
                MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();

                cmd.CommandText = "delete from paciente where nIdPaciente = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente Eliminado Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar todos los textbox / combobox
                Txt_nombrep.Clear();
                Txt_telefonop.Clear();
                Txt_nitp.Clear();
                Cmb_tipoSangrep.Items.Clear(); Cmb_tipoSangrep.Refresh();
                Txt_direccionp.Clear();
                Txt_correoP.Clear();
                Txt_alergiasp.Clear();
                Txt_refierep.Clear();
                Cmb_sexop.Items.Clear(); Cmb_sexop.Refresh();

                //Volver a habilitar todos los textbox / combobox
                Txt_nombrep.Enabled = true;
                Txt_telefonop.Enabled = true;
                Txt_nitp.Enabled = true;
                Cmb_tipoSangrep.Enabled = true;
                Txt_direccionp.Enabled = true;
                Txt_correoP.Enabled = true;
                Txt_alergiasp.Enabled = true;
                Txt_refierep.Enabled = true;
                Cmb_sexop.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }



            
        }

        private void Cmb_tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_tabla.SelectedItem.ToString() == "Paciente")
            {
                Tbc_paciente.Visible = true;
                Tbc_medicos.Visible = false;
                Tbc_examen.Visible = false;
                Picb_fondo.Visible = false;

            }
            else if(Cmb_tabla.SelectedItem.ToString() == "Médico Asociado")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = true;
                Tbc_examen.Visible = false;
                Picb_fondo.Visible = false;

            }
            else if (Cmb_tabla.SelectedItem.ToString() == "Exámen")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = false;
                Tbc_examen.Visible = true;
                Picb_fondo.Visible = false;
            }
        }
    }
}
