using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Drawing.Printing;
using System.Drawing;


namespace LaboratorioClinico
{
    public partial class cotizar : Form
    {
        public cotizar()
        {
            InitializeComponent();
            proLlenareExamen();
            proLlenareDoctor();
            proLlenarDescuento();
            proLlenarLaboratorio();
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
                
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdExamen, sDescripcion from examenes", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["sDescripcion"] = "Seleccione el examen";
                tabla.Rows.InsertAt(fila, 0);

                Cmb_examen.ValueMember = "iIdExamen";
                Cmb_examen.DisplayMember = "sDescripcion";

                Cmb_examen.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }

        }
        public void proLlenareDoctor()
        {


            try
            {
               
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select nIdEmpleado, sApellido from empleado where iIdCargo > 5010 && iIdCargo <5015", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["sApellido"] = "Seleccione el doctor";
                tabla.Rows.InsertAt(fila, 0);

                Cmb_doctor.ValueMember = "iIdEmpleado";
                Cmb_doctor.DisplayMember = "sApellido";

                Cmb_doctor.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        public void proLlenarLaboratorio()
        {
            try
            {
           
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdLaboratorio, sUbicacion from laboratorio", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);
               /* DataRow fila = tabla.NewRow();
                fila["sUbicacion"] = "Seleccione el laboratorio en el que se desea realizar el exámen";
                tabla.Rows.InsertAt(fila, 0);*/

                Cmb_laboratorio.ValueMember = "iIdLaboratorio";
                Cmb_laboratorio.DisplayMember = "sUbicacion";

                Cmb_laboratorio.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        public void proLlenarDescuento()
        {
            try
            {

                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select idtiposdes, tipo from tiposdes", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);
               /* DataRow fila = tabla.NewRow();
                fila["tipo"] = "Seleccione el tipo de descuento";
                tabla.Rows.InsertAt(fila, 0);
                */
                Cmb_tipoDeDescuento.ValueMember = "idtiposdes";
               Cmb_tipoDeDescuento.DisplayMember = "tipo";

                Cmb_tipoDeDescuento.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }


        public void proSeleccionDeDescuento()
        {
            int iTipoDeDescuento = Convert.ToInt32(Cmb_tipoDeDescuento.SelectedValue);
            if (iTipoDeDescuento == 3001) { Txt_porcentajeDeDescuento.Text = "0.45"; }
            else if (iTipoDeDescuento == 3002) { Txt_porcentajeDeDescuento.Text = "0.35"; }
            else if (iTipoDeDescuento == 3003) { Txt_porcentajeDeDescuento.Text = "0.25"; }
            else if (iTipoDeDescuento == 3004) { Txt_porcentajeDeDescuento.Text = "0.15"; }
            else if (iTipoDeDescuento == 3005) { Txt_porcentajeDeDescuento.Text = "0.50"; }

        }

        public void proGuardarCotizacion(int iIdExamenes, int iIdEmpleado, int iIdLaboratorio, int iIdTipoDescuento)
        {

            double doTotalExamenes = Convert.ToDouble(Txt_Total);
            double doDescuento = Convert.ToDouble(Txt_porcentajeDeDescuento);
            double doCantidad = Convert.ToDouble(Txt_Cantidad);
            double doPrecio = (doTotalExamenes / doDescuento) / doCantidad;
            try
            {

                OdbcCommand comando;
                comando = new OdbcCommand("Pro_agregarCotizacion", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@iAIdLaboratorio", iIdLaboratorio);
                comando.Parameters.AddWithValue("@dAFecha", this.Dtp_fecha.Value);
                comando.Parameters.AddWithValue("@iAIdTipoDeDescuento", iIdTipoDescuento);
                comando.Parameters.AddWithValue("@iAIdexamen", iIdExamenes);
                comando.Parameters.AddWithValue("@iACantidad", doCantidad);
                comando.Parameters.AddWithValue("@iAfPrecio", doPrecio);
                comando.Parameters.AddWithValue("@iAfDescuento", doDescuento);
                comando.Parameters.AddWithValue("@iAidEmpleado", iIdEmpleado);

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }


        }

        public void proBuscarCotizacion(int iIdExamenes)
        {

            try
            {
                OdbcCommand comando = new OdbcCommand("{CALL Pro_cotizacionesPrecio(?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@iIdExamenes",iIdExamenes);
                comando.ExecuteNonQuery();
                DataTable tabla = new DataTable();
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(tabla);
                Dgv_verDatos.DataSource = tabla;
            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }
         
        }
       public void proPrecioyTotal(int iIdExamenes)
        {

            double doPrecio = 0;
            double doDescuento = 0;
            double doCantidad = 0;
            double doTotal = 0;
            double doTotal2 = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand("{CALL Pro_cotizacionesPrecio(?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@iIdExamenes", iIdExamenes);
                comando.ExecuteNonQuery();

                OdbcDataReader buscador = comando.ExecuteReader();
                if (buscador.Read() == true)
                {
                    
                    doPrecio = Convert.ToDouble(buscador["fPrecio"]);
                    doCantidad = Convert.ToDouble(Txt_Cantidad.Text);
                    doDescuento = Convert.ToDouble(Txt_porcentajeDeDescuento.Text);
                    doTotal = doPrecio * doCantidad * doDescuento;
                    doTotal2 = Convert.ToInt32(Txt_Total.Text);
                    doTotal2 = doTotal2 + doTotal;
                    Txt_Total.Text = Convert.ToString(doTotal);
                }
            
            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }
        }
   
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
           
            int iIdExamenes = Convert.ToInt32(Cmb_examen.SelectedValue);           
 
            proBuscarCotizacion(iIdExamenes);
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
            int iExamenes = Convert.ToInt32(Cmb_examen.SelectedValue);
            int iEmpleado = Convert.ToInt32(Cmb_doctor.SelectedValue);
            int iTipoDescuento = Convert.ToInt32(Cmb_tipoDeDescuento.SelectedValue);
            int iLaboratorio = Convert.ToInt32(Cmb_laboratorio.SelectedValue);
            proGuardarCotizacion(iExamenes, iEmpleado, iLaboratorio, iTipoDescuento);
            
        }

        private void Cmb_tipoDeDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                proSeleccionDeDescuento();
               
        }

        private void Cmb_laboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (Cmb_laboratorio.SelectedValue.ToString() != null)
                {
                    int iLaboratorio = Convert.ToInt32(Cmb_laboratorio.SelectedValue);
                    Txt_noLaboratorio.Text = iLaboratorio.ToString();
                }
            } catch(Exception error){ MessageBox.Show(error.Message); }
      
        }

        private void Cmb_examen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   

        private void Btn_agregar_Click(object sender, EventArgs e)
        {

            int iIdExamenes = Convert.ToInt32(Cmb_examen.SelectedValue);

            proBuscarCotizacion(iIdExamenes);
            proPrecioyTotal(iIdExamenes);

        }
    }
}
