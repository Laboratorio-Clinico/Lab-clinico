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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
            llenarSangre();
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

        public void llenarSangre()
        {
            //Procedimiento que llena el COMBOBOX del tipo de Sangre

            try
            {
                Cmb_sangrep.Items.Clear();
                Cmb_sangrep.Text = "Seleccione el tipo de sangre";
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdTipoDeSangre,sGrupoSanguineo from tipodesangre", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_sangrep.ValueMember = "iIdTipoDeSangre";
                Cmb_sangrep.DisplayMember = "sGrupoSanguineo";

                Cmb_sangrep.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        private void Btn_guardarp_Click(object sender, EventArgs e)
        {

            try
            {
                //Procedimiento para ingresar datos del paciente
                OdbcCommand cm;
                cm = new OdbcCommand("{CALL InsertaPaciente(?,?,?,?,?,?,?,?,?,?,?,?)}", conexion.ObtenerConexion());
                cm.CommandType = CommandType.StoredProcedure;
                OdbcParameter parametros = new OdbcParameter();
                int idPaciente = Convert.ToInt64(Cmb_sangrep.SelectedValue);

                cm.Parameters.AddWithValue("@nIdPaciente", Txt_expedientep.Text);
                cm.Parameters.AddWithValue("@sNit", Txt_nitp.Text);
                cm.Parameters.AddWithValue("@sNombre", Txt_nombrep.Text);
                cm.Parameters.AddWithValue("@sDireccion", Txt_direccionp.Text);
                cm.Parameters.AddWithValue("@sGenero", Cmb_sexop.Text);
                cm.Parameters.AddWithValue("@dFechaDeNacimiento", Dtp_fechap.Text);
                cm.Parameters.AddWithValue("@dFechaDeEmision", Dtp_fecha2p.Text);
                cm.Parameters.AddWithValue("@iIdTipoDeSangre", idPaciente);
                cm.Parameters.AddWithValue("@sAlergia", Txt_alergiasp.Text);
                cm.Parameters.AddWithValue("@sRefiere", Txt_refierep.Text);
                cm.Parameters.AddWithValue("@correo", Txt_correoP.Text);
                cm.Parameters.AddWithValue("@telefono", Txt_telefonop.Text);
                cm.ExecuteNonQuery();

                MessageBox.Show("Paciente Ingresado Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpia todos los textbox y comboBox de la forma PACIENTE
                Txt_expedientep.Clear();
                Txt_nitp.Clear();
                Txt_nombrep.Clear();
                Txt_direccionp.Clear();
                Cmb_sexop.ResetText();
                Dtp_fechap.ResetText();
                Dtp_fecha2p.ResetText();
                Cmb_sangrep.ResetText();
                Txt_alergiasp.Clear();
                Txt_refierep.Clear();
                Txt_correoP.Clear();
                Txt_telefonop.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }


        }
        private bool Validar()
        {
            bool bValor = true;

            if (Txt_alergiasp.Text == "")
            {
                bValor = false;
                Er_validar.SetError(Txt_alergiasp, "Ingrese alergias o ninguna");
            }
            return bValor;
        }

       /* private void BorrarMsj()
        {
            Er_validar.SetError(Txt_contraseña, "");
            Er_validar.SetError(Txt_usuario, "");
        }*/
        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        private void Txt_alergiasp_TextChanged(object sender, EventArgs e)
        {
           // Validar();
        }

        private void Dtp_fechap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_sangrep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gpb_datosp_Enter(object sender, EventArgs e)
        {

        }

        private void Gpb_guardarp_Enter(object sender, EventArgs e)
        {

        }
    }
}
