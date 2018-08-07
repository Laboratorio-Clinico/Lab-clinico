using System;
using System.Data;
using System.Data.Odbc;
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
    public partial class Membresias : Form
    {
        public Membresias()
        {
            InitializeComponent();
        }

        public void Pro_llenarDatos(Decimal nPaciente)
        {
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
                    Btn_Beneficios.Visible = true;
                    label2.Visible = true;
                    Lbl_buscar.Visible = true;
                    Btn_agregar.Visible = true;
                    Btn_buscar.Visible = false;
                    Lbl_buscar.Visible = false;
                }
                else { MessageBox.Show("El paciente no esta registrado"); }

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }

        }

        public void Pro_llenarMembresias()
        {
            /*En este procedimiento se guardan los diferentes tipos de membresias dentro de un comboBox*/
            try
            {


                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iNoMembresia,sDescripcion from membresia", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["sDescripcion"] = "Seleccione la membresia";
                tabla.Rows.InsertAt(fila, 0);

                Cmb_membresia.ValueMember = "iNoMembresia";
                Cmb_membresia.DisplayMember = "sDescripcion";

                Cmb_membresia.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }

        public void Pro_agregarMembresia()
        {
            /*En este procedimiento se guarda la nueva membresia que el paciente seleccione del comboBox, además de que guardará los créditos de
              beneficio que el obtener la membresia conlleva*/

            try
            {
                int iMembresias = Convert.ToInt32(Cmb_membresia.SelectedValue);
                OdbcCommand comando = new OdbcCommand("{CALL Pro_ingresoMembresias(?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("nPaciente", Txt_DPI.Text);
                comando.Parameters.AddWithValue("iMembresia", iMembresias);
                comando.ExecuteNonQuery();
                MessageBox.Show("Membresía agregada exitosamente");
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
            label2.Visible = false;
            Lbl_buscar.Visible = false;
            Btn_Beneficios.Visible = false;
            Btn_agregar.Visible = false;
            Btn_buscar.Visible = true;
            Lbl_buscar.Visible = true;
            Txt_DPI.Text = "";
            Txt_nombre.Text = "";
            Txt_nit.Text = "";
        }

        public void Pro_mostrarBeneficios()
        {
            /*En este procedimiento se muestra al usuario los diferentes beneficios que la membresia seleccionada por el comboBox.*/
            try
            {
                int iMembresias = Convert.ToInt32(Cmb_membresia.SelectedValue);

                OdbcCommand comando = new OdbcCommand("{CALL Pro_verMembresia(?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("iMembresia", iMembresias);
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
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            /*Este botón obtiene el Dpi del paciente y lo convierte en un decimal, luego lo envia al procedimiento que se encarga de 
             cargar los datos que la base de datos que tiene el paciente, ademas de cargar el comboBox que me permitirá seleccionar
             la membresía.*/

            decimal nPaciente = Convert.ToDecimal(Txt_DPI.Text);
            Pro_llenarDatos(nPaciente);
            Pro_llenarMembresias();

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            /*Este botón se encarga de llamar al procedimiento que guardará la nueva membresia del paciente*/
            Pro_agregarMembresia();
        }

        private void Btn_Beneficios_Click(object sender, EventArgs e)
        {
            /*Este botón se encarga de llamar al procedimiento que muestra los diferentes tipos de beneficios de membresias*/
            Pro_mostrarBeneficios();
        }

        private void Membresias_Load(object sender, EventArgs e)
        {

        }
    }
}
