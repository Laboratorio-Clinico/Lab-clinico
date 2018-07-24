using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LaboratorioClinico
{
    public partial class cotizar : Form
    {
        public cotizar()
        {
            InitializeComponent();
            proLlenareExamen();
            proLlenareDoctor();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void proLlenareExamen()
        {

            try
            {
                Cmb_examen.Text = "Seleccione el examen que desea buscar";
                Cmb_examen.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("Select iIdExamen, sDescripcion from Examenes", conexion.ObtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_examen.ValueMember = "iIdExamen";
                Cmb_examen.DisplayMember = "sDescripcion";

                Cmb_examen.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }

        }
        public void proLlenareDoctor()
        {


            try
            {
                Cmb__doctor.Text = "Seleccione el doctor que desea buscar";
                Cmb__doctor.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("Select nIdEmpleado, sApellido from Empleado where iIdCargo > 5010 && iIdCargo <5015", conexion.ObtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb__doctor.ValueMember = "iIdEmpleado";
                Cmb__doctor.DisplayMember = "sApellido";

                Cmb__doctor.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
        }
        public void proLlenarLaboratorio()
        {


            try
            {
                Cmb__doctor.Text = "Seleccione el laboratorio en el que realizará el exámen";
                Cmb__doctor.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("Select iIdLaboratorio, sUbicacion from Laboratorio", conexion.ObtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb__doctor.ValueMember = "iIdLaboratorio";
                Cmb__doctor.DisplayMember = "sUbicacion";

                Cmb__doctor.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
        }
        public void proLlenareTipoDeDescuento()
        {


            try
            {
                Cmb__doctor.Text = "Seleccione el tipo de descuento a utilizar";
                Cmb__doctor.Items.Clear();
                conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("Select iIdTipoDeDescuento, sDescripcion from TipoDeDescuento", conexion.ObtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb__doctor.ValueMember = "iIdTipoDeDescuento";
                Cmb__doctor.DisplayMember = "sDescripcion";

                Cmb__doctor.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
        }
        public void proSeleccionDeDescuento(int iTipoDeDescuento)
        {
            if (iTipoDeDescuento == 9001) { Txt_porcentajeDeDescuento.Text = "0.45"; }
            else if (iTipoDeDescuento == 9002) { Txt_porcentajeDeDescuento.Text = "0.35"; }
            else if (iTipoDeDescuento == 9003) { Txt_porcentajeDeDescuento.Text = "0.25"; }
            else if (iTipoDeDescuento == 9004) { Txt_porcentajeDeDescuento.Text = "0.15"; }
            else if (iTipoDeDescuento == 9005) { Txt_porcentajeDeDescuento.Text = "0.50"; }

          }

        public void proGuardarCotizacion(int iIdExamenes, int iIdEmpleado, int iIdLaboratorio, int iIdTipoDescuento)
        {

            double doTotalExamenes = Convert.ToDouble(Txt_Total);
            double doDescuento = Convert.ToDouble(Txt_porcentajeDeDescuento);
            double doCantidad = Convert.ToDouble(Txt_Cantidad);
            double doPrecio = (doTotalExamenes / doDescuento) / doCantidad;
            try
            {

                MySqlCommand comando;
                comando = new MySqlCommand("Pro_agregarCotizacion", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@iAIdLaboratorio", iIdLaboratorio);
                comando.Parameters.AddWithValue("@dAFecha", this.Dtp_fecha);
                comando.Parameters.AddWithValue("@iAIdTipoDeDescuento", iIdTipoDescuento);
                comando.Parameters.AddWithValue("@iAIdexamen", iIdExamenes);
                comando.Parameters.AddWithValue("@iACantidad", doCantidad);
                comando.Parameters.AddWithValue("@iAfPrecio", doPrecio);
                comando.Parameters.AddWithValue("@iAfDescuento", doDescuento);
                comando.Parameters.AddWithValue("@iAidEmpleado", iIdEmpleado);

            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }

            Txt_Cantidad.ResetText();
            Txt_noLaboratorio.ResetText();
            Txt_Total.ResetText();
            Txt_porcentajeDeDescuento.ResetText();

        }

        public void proBuscarCotizacion(int iIdExamenes)
        {
           
            try
            {
                MySqlCommand comando = new MySqlCommand("Pro_cotizacionesPrecio", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@iIdExamen", MySqlDbType.Int16);
                comando.Parameters["@iIdExamen"].Value = iIdExamenes;
                comando.Parameters.AddWithValue("iIdExamen", iIdExamenes);
                conexion.ObtenerConexion().Open();
                comando.ExecuteNonQuery();
                DataTable tabla = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(tabla);
                Dgv_verDatos.DataSource = tabla;
            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }



        }
        public void proPrecioyTotal(int iIdExamenes){
            double doPrecio = 0;
            double doDescuento = 0;
            double doCantidad = 0;
            double doTotal = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("Pro_cotizacionesPrecio", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@iIdExamen", MySqlDbType.Int16);
                comando.Parameters["@iIdExamen"].Value = iIdExamenes;
                conexion.ObtenerConexion().Open();
                comando.ExecuteNonQuery();
                MySqlDataReader buscador = comando.ExecuteReader();
                if (buscador.Read() == true)
                {
                    doPrecio = Convert.ToDouble(buscador["fPrecio"]);
                    doCantidad = Convert.ToDouble(Txt_Cantidad);
                    doDescuento = Convert.ToDouble(Txt_porcentajeDeDescuento);
                    doTotal = doPrecio * doCantidad * doDescuento;
                    Txt_Total.Text = Convert.ToString(doTotal);
                }
            }
            catch (MySqlException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            int iIdExamenes = Convert.ToInt32(Cmb_examen.SelectedValue);
            int iIdEmpleado = Convert.ToInt32(Cmb__doctor.SelectedValue);
            int iIdTipoDescuento = Convert.ToInt32(Cmb_tipoDeDescuento.SelectedValue);
            int iIdLaboratorio = Convert.ToInt32(Cmb_laboratorio.SelectedValue);
            //proBuscarCotizacion(iIdExamenes, iIdEmpleado, iIdLaboratorio, iIdTipoDescuento);
            proPrecioyTotal(iIdExamenes);


        }

        private void Btn_requisitos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requerimientos requerimiento = new Requerimientos();
            requerimiento.ShowDialog();
            this.Show();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_tipoDeDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_tipoDeDescuento.SelectedValue.ToString() != null)
            {
                int iTipoDeDescuento = Convert.ToInt32(Cmb_tipoDeDescuento);
                proSeleccionDeDescuento(iTipoDeDescuento);
  
            }
        }

        private void Cmb_laboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_laboratorio.SelectedValue.ToString() != null)
            {
                int iLaboratorio = Convert.ToInt32(Cmb_laboratorio);
                Txt_noLaboratorio.Text = iLaboratorio.ToString();

            }
        }

        private void Cmb_examen_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
