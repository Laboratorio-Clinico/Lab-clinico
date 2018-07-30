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
        public void proGuardarDatos(int iEmpresas,int iEspecialidades) {

            try
            {
                OdbcCommand cm;
                cm = new OdbcCommand("Pro_ingresoNuevoMedico", conexion.ObtenerConexion());
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.AddWithValue("@iColegiado", this.Txt_colegiado.Text);
                cm.Parameters.AddWithValue("@sNombre", this.Txt_nombre.Text);
                cm.Parameters.AddWithValue("@sApellido", this.Txt_apellido.Text);
                cm.Parameters.AddWithValue("@nTelefono", this.Txt_telefono.Text);
                cm.Parameters.AddWithValue("@sDireccion", this.Txt_direccion.Text);
                cm.Parameters.AddWithValue("@sCorreo", this.Txt_Correo.Text);
                cm.Parameters.AddWithValue("@iIdEspecialidad", iEspecialidades);
                cm.Parameters.AddWithValue("@iIdEmpresa", iEmpresas);
                cm.Parameters.AddWithValue("@dFechaDeNacimiento", this.Dtp_fechaNacimiento.Text);

                cm.ExecuteNonQuery();
                MessageBox.Show("Datos agregados exitosamente");
            }
            catch (Exception error) { MessageBox.Show("Error"+error); }
            finally
            {

                conexion.ObtenerConexion().Close();
                Txt_colegiado.ResetText();
                Txt_nombre.ResetText();
                Txt_apellido.ResetText();
                Txt_telefono.ResetText();
                Txt_Correo.ResetText();
                Txt_direccion.ResetText();
                Dtp_fechaNacimiento.ResetText();
            
        }
    }
        public void proLlenarEmpresa()
        {

            try
               
            {
                Cmb_empresa.Items.Clear();
                Cmb_empresa.Text = "Seleccione una empresa";
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdEmpresa,sEmpresa from Empresa", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);
                DataRow fila = tabla.NewRow();
                fila["sEmpresa"] = "Seleccione una Empresa";
                tabla.Rows.InsertAt(fila, 0);

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
        
                
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdEspecialidad,sEspecialidad from Especialidad", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["sEspecialidad"] = "Seleccione la especialidad";
                tabla.Rows.InsertAt(fila, 0);

                Cmb_especialidad.ValueMember = "iIdEspecialidad";
                Cmb_especialidad.DisplayMember = "sEspecialidad";

                Cmb_especialidad.DataSource = tabla;
                
                conexion.ObtenerConexion().Close();

            }
            catch (Exception error) { MessageBox.Show("Error al llenar especialidad"); }


        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {


                int iEmpresas = Convert.ToInt32(Cmb_empresa.SelectedValue);
                int iEspecialidades = Convert.ToInt32(Cmb_especialidad.SelectedValue);
            
                proGuardarDatos(iEmpresas, iEspecialidades);



        }

        private void Gpb_nacimiento_Enter(object sender, EventArgs e)
        {

        }
    }
}
