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

                OdbcCommand comando = new OdbcCommand("{CALL Pro_ingresoNuevoMedico(?,?,?,?,?,?,?,?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("iColegiado", Txt_colegiado.Text);
                comando.Parameters.AddWithValue("sNombre", Txt_nombre.Text);
                comando.Parameters.AddWithValue("sApellido", Txt_apellido.Text);
                comando.Parameters.AddWithValue("nTelefono", Txt_telefono.Text);
                comando.Parameters.AddWithValue("sDireccion", Txt_direccion.Text);
                comando.Parameters.AddWithValue("sCorreo", Txt_Correo.Text);
                comando.Parameters.AddWithValue("iIdEspecialidad", iEspecialidades);
                comando.Parameters.AddWithValue("iIdEmpresa", iEmpresas);
                comando.Parameters.AddWithValue("dFechaDeNacimiento", Dtp_fechaNacimiento.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos insertados correctamente");
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
                OdbcCommand comando = new OdbcCommand("Select iIdEmpresa,sEmpresa from empresa", conexion.ObtenerConexion());
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
                OdbcCommand comando = new OdbcCommand("Select iIdEspecialidad,sEspecialidad from especialidad", conexion.ObtenerConexion());
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


                int iEmpresas = Convert.ToInt64(Cmb_empresa.SelectedValue);
                int iEspecialidades = Convert.ToInt64(Cmb_especialidad.SelectedValue);
            
                proGuardarDatos(iEmpresas, iEspecialidades);



        }

        private void Gpb_nacimiento_Enter(object sender, EventArgs e)
        {

        }
    }
}
