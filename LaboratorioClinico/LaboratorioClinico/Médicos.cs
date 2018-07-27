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
    public partial class Médicos : Form
    {
        public Médicos()
        {
            InitializeComponent();
            proLlenarEmpresa();
            proLlenarEspecialidad();
        }

        private void Médicos_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void proGuardarDatos(int iEmpresa,int iEspecialidad) {

            try
            {
                OdbcCommand cm;
                cm = new OdbcCommand("Pro_ingresoNuevoMedico", conexion.ObtenerConexion());
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@sNombre", this.Txt_nombre);
                cm.Parameters.AddWithValue("@sApellido", this.Txt_apellido);
                cm.Parameters.AddWithValue("@nTelefono", this.Txt_telefono);
                cm.Parameters.AddWithValue("@sDireccion", this.Txt_direccion);
                cm.Parameters.AddWithValue("@sCorreo", this.Txt_Correo);
                cm.Parameters.AddWithValue("@sEspecialidad", iEspecialidad);
                cm.Parameters.AddWithValue("@iColegiado", this.Txt_colegiado);
                cm.Parameters.AddWithValue("@iEmpresa", iEmpresa);
                cm.Parameters.AddWithValue("@dFechaDeNacimiento", this.Dtp_fechaNacimiento);
                cm.ExecuteNonQuery();
                MessageBox.Show("Datos agregados exitosamente");

                Txt_Correo.ResetText();
                Txt_nombre.ResetText();
                Txt_apellido.ResetText();
                Txt_telefono.ResetText();
                Txt_direccion.ResetText();
                Cmb_especialidad.ResetText();
                Txt_colegiado.ResetText();
                Cmb_empresa.ResetText();
                Dtp_fechaNacimiento.ResetText();
            }
            catch (Exception error) { MessageBox.Show("Error"); }
        }
        public void proLlenarEmpresa()
        {

            try
            {
                Cmb_empresa.Text = "Seleccione una empresa";
                Cmb_empresa.Items.Clear();
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdEmpresa,sEmpresa from Empresa", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_empresa.ValueMember = "iIdEmpresa";
                Cmb_empresa.DisplayMember = "sEmpresa";

                Cmb_empresa.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (Exception error) { MessageBox.Show("Error al llenar campos de Empresa"); }


        }
        public void proLlenarEspecialidad()
        {

            try
            {
                Cmb_empresa.Text = "Seleccione la especialidad";
                Cmb_empresa.Items.Clear();
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdEspecialidad,sEspecialidad from Especialidad", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_empresa.ValueMember = "iIdEspecialidad";
                Cmb_empresa.DisplayMember = "sEspecialidad";

                Cmb_empresa.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (Exception error) { MessageBox.Show("Error al llenar especialidad"); }


        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {


            try
            {

                int iEmpresa = Convert.ToInt32(Cmb_empresa.SelectedValue);
                int iEspecialidad = Convert.ToInt32(Cmb_especialidad.SelectedValue);
                proGuardarDatos(iEmpresa, iEspecialidad);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void Gpb_nacimiento_Enter(object sender, EventArgs e)
        {

        }
    }
}
