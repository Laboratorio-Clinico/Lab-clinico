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

          


            if (Txt_DPIEmpleado.TextLength == 13)
            {
                Erp_errorE.SetError(Txt_DPIEmpleado, "");
                try
                {

                    int iCargo = Convert.ToInt32(Cmb_cargo.SelectedValue);


                    OdbcCommand comando = new OdbcCommand("{CALL Pro_insertarEmpleado(?,?,?,?,?,?,?,?,?,?)}", conexion.ObtenerConexion());
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("iEmpleado", Txt_DPIEmpleado.Text);
                    comando.Parameters.AddWithValue("sNombre", Txt_nombre.Text);
                    comando.Parameters.AddWithValue("sApellido", Txt_apellido.Text);
                    comando.Parameters.AddWithValue("nTelefono", Txt_telefono.Text);
                    comando.Parameters.AddWithValue("sDireccion", Txt_direccion.Text);
                    comando.Parameters.AddWithValue("sCorreo", Txt_correo.Text);
                    comando.Parameters.AddWithValue("iCargo", iCargo);
                    comando.Parameters.AddWithValue("fSueldo", Txt_sueldo.Text);
                    comando.Parameters.AddWithValue("dFechaDeNacimiento", Dtp_fechaNacimiento.Text);
                    comando.Parameters.AddWithValue("iUsuario", Txt_DPIEmpleado.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados correctamente");



                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error);

                    conexion.ObtenerConexion().Close();
                }
                Txt_DPIEmpleado.ResetText();
                Txt_nombre.ResetText();
                Txt_apellido.ResetText();
                Txt_telefono.ResetText();
                Txt_correo.ResetText();
                Txt_direccion.ResetText();
                Txt_sueldo.ResetText();
                Cmb_cargo.ResetText();
                Dtp_fechaNacimiento.ResetText();
            }else
            {
                Erp_errorE.SetError(Txt_DPIEmpleado, "Deben ingresarse 13 dígitos");
            }
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
            int num;
            if (int.TryParse(Txt_DPIEmpleado.Text, out num))
            {
                Er_validar.SetError(Txt_DPIEmpleado, "");
                Pro_guardarDatos();
            }
            else
            {
                Er_validar.SetError(Txt_DPIEmpleado, "Solo números se acepta");
            }
            

        }

        private void Cmb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_DPIEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
