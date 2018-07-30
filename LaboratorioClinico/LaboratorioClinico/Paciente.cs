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


            try
            {
                Cmb_sangrep.Items.Clear();
                Cmb_sangrep.Text = "Seleccione el tipo de sangre";
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdTipoDeSangre,sGrupoSanguineo from tipoDeSangre", conexion.ObtenerConexion());
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
                OdbcCommand cm;
               // OdbcCommand cm = new OdbcCommand("{CALL InsertaPrueba (nIdPaciente,sNit,sNombre,sDireccion,sGenero,dFechaDeNacimiento,dFechaDeEmision,iIdTipoDeSangre,sAlergia,sRefiere,correo,telefono)}", conexion.ObtenerConexion());
                cm = new OdbcCommand("InsertaPaciente", conexion.ObtenerConexion());
                cm.CommandType = CommandType.StoredProcedure;

                int idPaciente = Convert.ToInt32(Cmb_sangrep.SelectedValue);
                /// int idPaciente = int.Parse(Cmb_sangrep.ToString());
                MessageBox.Show("idPaciente: " + Cmb_sangrep.SelectedValue);

                OdbcParameter parametros = new OdbcParameter();
              //  OdbcParameter parametros = cm.Parameters.Add("RETURN_VALUE", OdbcType.Int);
              parametros.Direction = ParameterDirection.ReturnValue;

                parametros = cm.Parameters.Add("@nIdPaciente", OdbcType.Numeric, 13);
                parametros.Value = Txt_expedientep.Text;
                parametros = cm.Parameters.Add("@sNit", OdbcType.VarChar, 9);
                parametros.Value = Txt_nitp.Text;
                parametros = cm.Parameters.Add("@sNombre", OdbcType.VarChar, 45);
                parametros.Value = Txt_nombrep.Text;
                parametros = cm.Parameters.Add("@sDireccion", OdbcType.VarChar, 45);
                parametros.Value = Txt_direccionp.Text;
                parametros = cm.Parameters.Add("@sGenero", OdbcType.VarChar, 1);
                parametros.Value = Cmb_sexop.Text;
                parametros = cm.Parameters.Add("@dFechaDeNacimiento", OdbcType.Date);
                parametros.Value = Dtp_fechap.Text;
                parametros = cm.Parameters.Add("@dFechaDeEmision", OdbcType.Date);
                parametros.Value = Dtp_fecha2p.Text;
                parametros = cm.Parameters.Add("@iIdTipoDeSangre", OdbcType.Int, 11);
                parametros.Value = idPaciente;
                parametros = cm.Parameters.Add("@sAlergia", OdbcType.VarChar, 2000);
                parametros.Value = Txt_alergiasp.Text;
                parametros = cm.Parameters.Add("@sRefiere", OdbcType.VarChar, 45);
                parametros.Value = Txt_refierep.Text;
                parametros = cm.Parameters.Add("@correo", OdbcType.VarChar, 50);
                parametros.Value = Txt_correoP.Text;
                parametros = cm.Parameters.Add("@telefono", OdbcType.Numeric, 8);
                parametros.Value = Txt_telefonop.Text;

               // parametros = cm.Parameters.Add("@OutputParm", OdbcType.VarChar, 28);
                //parametros.Direction = ParameterDirection.Output;

                cm.ExecuteNonQuery();
            }
            catch (Exception error) {
                MessageBox.Show("Error: " + error); 
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
    }
}
