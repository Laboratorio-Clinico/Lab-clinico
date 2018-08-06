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
            tipoCorreo();
        }
        public void tipoCorreo()
        {

         
            try
            {
                Cmb_correo.Items.Clear();
                Cmb_correo.Text = "Seleccione forma pago";
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdCorreo,sCorreo from correo", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_correo.ValueMember = "iIdCorreo";
                Cmb_correo.DisplayMember = "sCorreo";
                Cmb_correo.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
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

        private void Btn_guardarResultado_Click(object sender, EventArgs e)
        {
            try
            {
                int iIdCorreo = Convert.ToInt32(Cmb_correo.SelectedValue);


                OdbcCommand comando = new OdbcCommand("{CALL InsertaResultados(?,?,?,?,?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nIdPaciente", Txt_dpir.Text);
                comando.Parameters.AddWithValue("@iIdExamen", Txt_codEx.Text);
                comando.Parameters.AddWithValue("@requisitos", Txt_resultadox.Text);
                comando.Parameters.AddWithValue("@fechaEmision", Dtp_fechar.Text);
                comando.Parameters.AddWithValue("@correo", Txt_Correor.Text);
                comando.Parameters.AddWithValue("@sCorreo", iIdCorreo);

                comando.ExecuteNonQuery();
                MessageBox.Show("Resultados insertados correctamente");
            }
            catch (Exception error) { MessageBox.Show("Error" + error); }
            finally
            { conexion.ObtenerConexion().Close(); }
        }

        private void Btn_imprimirResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_editarResultado_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                cmd.CommandText = "update examenes set sDescripcion = '" + Txt_nombrem.Text + "' where iIdExamen = '" + Convert.ToInt32(Txt_codigom.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update examenes set fPrecio = '" + Convert.ToUInt32(Txt_preciom.Text) + "' where iIdExamen = '" + Convert.ToInt32(Txt_codigom.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Examen Modificado Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                proCargaDatos();

                //Limpiar y deshabilitar
                Txt_codigom.Clear();
                Txt_nombrem.Clear();
                Txt_preciom.Clear();
                Gpb_datosm.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }*/
        }
    }
}
