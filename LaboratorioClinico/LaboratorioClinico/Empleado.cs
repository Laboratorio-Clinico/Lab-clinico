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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
            proLlenareCargo();
        }

        public void Pro_guardarDatos() {

            try
            {

                int iCargo = Convert.ToInt32(Cmb_cargo.SelectedValue);
      

                OdbcCommand comando = new OdbcCommand("{CALL pr(?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p", Txt_nombre.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos insertados correctamente");



            }
            catch (Exception error) { MessageBox.Show("Error" + error);
               
            conexion.ObtenerConexion().Close(); }
                  Txt_DPIEmpleado.ResetText();
                  Txt_nombre.ResetText();
                  Txt_apellido.ResetText();
                  Txt_telefono.ResetText();
                  Txt_correo.ResetText();
                  Txt_direccion.ResetText();
                  Txt_sueldo.ResetText();
                  Cmb_cargo.ResetText();
                  Dtp_fechaNacimiento.ResetText();
            }

        public void proLlenareCargo()
        {


            try
            {
                
                
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdCargo,sDescripcion from cargo", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["sDescripcion"] = "Seleccione el puesto";
                tabla.Rows.InsertAt(fila, 0);

                Cmb_cargo.ValueMember = "iIdCargo";
                Cmb_cargo.DisplayMember = "sDescripcion";

                Cmb_cargo.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }


        private void Btn_guardar_Click(object sender, EventArgs e)
        {
           
            Pro_guardarDatos();

        }

        private void Cmb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
