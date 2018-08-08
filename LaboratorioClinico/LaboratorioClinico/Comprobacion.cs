using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LaboratorioClinico
{
    public partial class Comprobacion : Form
    {
        public Comprobacion()
        {
            InitializeComponent();
        }
        public void Pro_llenarDatosPaciente(decimal nPaciente) {
            /*En este procedimiento se cargan los datos del paciente en los diferentes campos que muestra la forma*/
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Select *from paciente where nidpaciente='{0}'", nPaciente), conexion.ObtenerConexion());
                comando.ExecuteNonQuery();

                OdbcDataReader buscador = comando.ExecuteReader();
                if (buscador.Read() == true)
                {
                    Txt_nombre.Text = buscador["sNombre"].ToString();
                    Txt_nit.Text = buscador["sNit"].ToString();
                  
                }
                else { MessageBox.Show("El paciente no esta registrado"); }

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }
        }

        public void Pro_buscarCita(decimal nPaciente)
        {
            try
            {

                OdbcCommand comando = new OdbcCommand("{CALL Pro_BuscarCita(?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("nPaciente", nPaciente);
                comando.Parameters.AddWithValue("dFechaC", Dtp_fecha.Text);
                DataTable tabla = new DataTable();
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(tabla);
                Dgv_verBeneficios.DataSource = tabla;
            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally
            {
                conexion.ObtenerConexion().Close();


            }

        }

        public void Pro_noCita(decimal nPaciente) {

            try
            {

                OdbcCommand comando = new OdbcCommand("{CALL Pro_buscarNocita(?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("nPaciente", nPaciente);
                comando.Parameters.AddWithValue("dFechaC", Dtp_fecha.Text);
                DataTable tabla = new DataTable();
                OdbcDataReader buscador = comando.ExecuteReader();
                if (buscador.Read() == true) {
                   Txt_noCita.Text = buscador["iIdCitas"].ToString();
                }
                
            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally
            {
                conexion.ObtenerConexion().Close();


            }

        }

        public void Pro_confirmarCita() {

            try
            {
             
                OdbcCommand comando = new OdbcCommand("{CALL Pro_LlegadaCita(?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("iCita", Txt_noCita.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Asistencia Confirmada");
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        public void Pro_cancelarCita()
        {

            try
            {

                OdbcCommand comando = new OdbcCommand("{CALL Pro_CancelaCita(?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("iCita", Txt_noCita.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cancelación confirmada");
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            /*Este botón obtiene el Dpi del paciente y lo convierte en un decimal, luego lo envia al procedimiento que se encarga de 
            cargar los datos que la base de datos que tiene el paciente, ademas de cargar el comboBox que me permitirá seleccionar
            la membresía.*/

            decimal nPaciente = Convert.ToDecimal(Txt_DPI.Text);
            Pro_llenarDatosPaciente(nPaciente);
            Pro_noCita(nPaciente);
            Pro_buscarCita(nPaciente);
        }

  

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Pro_cancelarCita();
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            Pro_confirmarCita();
        } 
    }
}
