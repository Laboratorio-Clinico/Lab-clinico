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
            OdbcCommand cm;
            cm = new OdbcCommand("InsertaPrueba", conexion.ObtenerConexion());
            cm.CommandType = CommandType.StoredProcedure;

            int idPaciente = Convert.ToInt32(Cmb_sangrep.SelectedValue);
           

            cm.Parameters.AddWithValue("@nIdPaciente", this.Txt_expedientep.Text);
            cm.Parameters.AddWithValue("@sNit", this.Txt_nitp.Text);
            cm.Parameters.AddWithValue("@sNombre", this.Txt_nombrep.Text);
            cm.Parameters.AddWithValue("@sDireccion", this.Txt_direccionp.Text);
            cm.Parameters.AddWithValue("@sGenero", this.Cmb_sexop.Text);
            cm.Parameters.AddWithValue("@dFechaDeNacimiento", this.Dtp_fechap.Value);
            cm.Parameters.AddWithValue("@dFechaDeEmision", this.Dtp_fecha2p.Value);
            cm.Parameters.AddWithValue("@iIdTipoDeSangre", idPaciente);
            cm.Parameters.AddWithValue("@sAlergia", this.Txt_alergiasp.Text);
            cm.Parameters.AddWithValue("@sRefiere", this.Txt_refierep.Text);
            cm.Parameters.AddWithValue("@correo", this.Txt_correoP.Text);
            cm.Parameters.AddWithValue("@telefono", this.Txt_telefonop.Text);



            int query = cm.ExecuteNonQuery();
            if (query == 1)
            {
                MessageBox.Show("Paciente guardado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
