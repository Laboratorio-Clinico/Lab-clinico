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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        public void Pro_guardarDatos(int cargo) {
            MySqlCommand cm;
            cm = new MySqlCommand("Pro_ingresoNuevoEmpleado", conexion.ObtenerConexion());
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@sNombre", this.Txt_nombre);
            cm.Parameters.AddWithValue("@sApellido", this.Txt_apellido);
            cm.Parameters.AddWithValue("@deTelefono", this.Txt_telefono);
            cm.Parameters.AddWithValue("@sDireccion", this.Txt_direccion);
            cm.Parameters.AddWithValue("@sCorreo", this.Txt_correo);
            cm.Parameters.AddWithValue("@iidCargo", cargo);
            cm.Parameters.AddWithValue("@fSueldo", this.Txt_sueldo);
            cm.Parameters.AddWithValue("@dFechaDeNacimiento", this.Dtp_fechaNacimiento);

            int query = cm.ExecuteNonQuery();

            if (query == 1)
            {
                MessageBox.Show("Cliente ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
                Cmb_cargo.Text = "Seleccione el cargo correspondiente";
                Cmb_cargo.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("Select sCargo from examenes", conexion.ObtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_cargo.ValueMember = "iCodigo";
                Cmb_cargo.DisplayMember = "sDescripcion";

                Cmb_cargo.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            
    }
    }
}
