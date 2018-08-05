using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioClinico
{
    public partial class SolicitudDeMembresia : Form
    {
        public SolicitudDeMembresia()
        {
            InitializeComponent();
        }

        public void Pro_llenarDatos(Decimal nPaciente) {
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Select *from paciente where nidpaciente='{0}'",nPaciente),conexion.ObtenerConexion());   
                comando.ExecuteNonQuery();

                OdbcDataReader buscador = comando.ExecuteReader();
                if (buscador.Read() == true)
                {
                    Txt_nombre.Text = buscador["sNombre"].ToString();
                    Txt_nit.Text = buscador["sNit"].ToString();
                    Btn_beneficios.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    Btn_agregar.Visible = true;
                    Btn_buscar.Visible = false;
                    Lbl_buscar.Visible = false;
                }
                else { MessageBox.Show("El paciente no esta registrado"); }

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }
        
    }

        public void Pro_llenarMembresias() {
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

        public void Pro_agregarMembresia() {

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
            label3.Visible = false;
            Btn_beneficios.Visible = false;
            Btn_agregar.Visible = false;
            Btn_buscar.Visible = true;
            Lbl_buscar.Visible = true;
            Txt_DPI.Text = "";
            Txt_nombre.Text = "";
            Txt_nit.Text = "";
        }
        public void Pro_mostrarBeneficios() {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            decimal nPaciente = Convert.ToDecimal(Txt_DPI.Text);
            Pro_llenarDatos(nPaciente);
            Pro_llenarMembresias();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Pro_agregarMembresia();
   
        }

        private void Btn_beneficios_Click(object sender, EventArgs e)
        {
            Pro_mostrarBeneficios();
        }
    }
}
