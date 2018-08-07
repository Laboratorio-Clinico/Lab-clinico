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
            proNumeroCotizacion();
        }

        int contador = 0;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void proNumeroCotizacion()
        {
            int numero = 0;
            int numero2 = 0;
            /*Este procedimiento crea la llave primaria que se guardará con la cotización, para hacerlo, cuenta los datos que estan
             insertados en la tabla de cotizacion.*/

            OdbcDataAdapter adaptador = new OdbcDataAdapter("select count(*) from cotizacion", conexion.ObtenerConexion());
            DataTable contador = new DataTable();
            adaptador.Fill(contador);
            numero = Convert.ToInt32(contador.Rows[0][0].ToString());
            numero2 = numero + 1;

            Txt_noCotizacion.Text = Convert.ToString(numero2);


        }
        public void proLlenareExamen()
        {
            /*Este procedimiento carga al comboBox las opciones de exámen que existen en la base de datos.*/
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

            /*Este procedimiento carga al comboBox las opciones de los diferentes doctores que existen en la base de datos.*/

            try
            {

                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select nIdEmpleado, sApellido from empleado where iIdCargo > 5010 && iIdCargo <5015", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);


                Cmb_doctor.ValueMember = "iIdEmpleado";
                Cmb_doctor.DisplayMember = "sApellido";

                Cmb_doctor.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        public void proLlenarLaboratorio()
        {

            /*Este procedimiento carga al comboBox las diferentes ubicaciones del laboratorio que existen en la base de datos.*/
            try
            {

                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdLaboratorio, sUbicacion from laboratorio", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);


                Cmb_laboratorio.ValueMember = "iIdLaboratorio";
                Cmb_laboratorio.DisplayMember = "sUbicacion";

                Cmb_laboratorio.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        public void proLlenarDescuento()
        {
            /*Este procedimiento carga al comboBox los diferentes tipos de descuentos que existen en la base de datos.*/
            try
            {

                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select idtiposdes, tipo from tiposdes", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cmb_tipoDeDescuento.ValueMember = "idtiposdes";
                Cmb_tipoDeDescuento.DisplayMember = "tipo";

                Cmb_tipoDeDescuento.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        public void proSeleccionDeDescuento()
        {
            /*Este procedimiento selecciona la cantidad de descuento que incluye el tipo de descuento seleccionado*/
            int iTipoDeDescuento = Convert.ToInt32(Cmb_tipoDeDescuento.SelectedValue);
            if (iTipoDeDescuento == 3001) { Txt_porcentajeDeDescuento.Text = "0.45"; }
            else if (iTipoDeDescuento == 3002) { Txt_porcentajeDeDescuento.Text = "0.35"; }
            else if (iTipoDeDescuento == 3003) { Txt_porcentajeDeDescuento.Text = "0.25"; }
            else if (iTipoDeDescuento == 3004) { Txt_porcentajeDeDescuento.Text = "0.15"; }
            else if (iTipoDeDescuento == 3005) { Txt_porcentajeDeDescuento.Text = "0.50"; }

        }
        public void proBuscarCotizacion(int iIdExamenes)
        {


            try
            {

                OdbcCommand comando = new OdbcCommand("{CALL Pro_cotizacionesPrecio(?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("iIdExamenes", iIdExamenes);
                DataTable tabla = new DataTable();
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(tabla);
              
                Dgv_verDatos.Rows.Add(iIdExamenes.ToString(), tabla.Rows[0][0].ToString(), tabla.Rows[0][1].ToString());
       
                
            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally
            {
                conexion.ObtenerConexion().Close();
            }
        }
        public void proPrecioyTotal(int iIdExamenes)
        {

            double doPrecio = 0;
            double doDescuento = 0;
            double doCantidad = 0;
            double doTotal = 0;
            double doTotal2 = 0;
            double doTotalF = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand("{CALL Pro_cotizacionesPrecio(?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@iIdExamenes", iIdExamenes);

                OdbcDataReader buscador = comando.ExecuteReader();
                if (buscador.Read() == true)
                {

                    doPrecio = Convert.ToDouble(buscador["fPrecio"]);
                    doCantidad = Convert.ToDouble(Txt_Cantidad.Text);
                    doDescuento = Convert.ToDouble(Txt_porcentajeDeDescuento.Text);
                    doTotal = doPrecio * doCantidad * doDescuento;
                    doTotal2 = Convert.ToInt32(Txt_Total.Text);
                    doTotalF = doTotal2 + doTotal;
                    Txt_Total.Text = Convert.ToString(doTotalF);
                    Txt_precioE.Text = Convert.ToString(doTotal);
                }

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
            finally { conexion.ObtenerConexion().Close(); }
        }

        public void proGuardarCotizacion() {

            // Este procedimiento guarda las cotizaciones realizadas, dentro de la base de datos
            try
            {
                int iCotizaciones = Convert.ToInt32(Txt_noCotizacion.Text);
                int iLaboratorios = Convert.ToInt32(Cmb_laboratorio.SelectedValue);
                int iTipoDescuento = Convert.ToInt32(Cmb_tipoDeDescuento.SelectedValue);

                OdbcCommand comando = new OdbcCommand("{CALL Pro_ingresoCotizacio(?,?,?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("iCotizacion", iCotizaciones);
                comando.Parameters.AddWithValue("iLaboratorio", iLaboratorios);
                comando.Parameters.AddWithValue("dFecha", Dtp_fecha.Text);
                comando.Parameters.AddWithValue("iDescuento", iTipoDescuento);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cotizacion agregada");
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

        }
        public void proGuardarDetallesCotizacion()
        {
            //Este procedimiento se encarga de guardar cada detalle de cotización
            try
            {
  
                int iCotizaciones = Convert.ToInt32(Txt_noCotizacion.Text);
                double total = Convert.ToDouble(Txt_precioE.Text);
                double fDescuentos = Convert.ToDouble(Txt_porcentajeDeDescuento.Text);
                double fCostos = total / fDescuentos;
                int iIdExamenes = Convert.ToInt32(Cmb_examen.SelectedValue);
                int iEmpleados = Convert.ToInt32(Cmb_doctor.SelectedValue);

                int iCantidades = Convert.ToInt32(Txt_Cantidad.Text.ToString);


                OdbcCommand comando = new OdbcCommand("{CALL Pro_ingresoDetallesCotizacion(?,?,?,?,?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("iCotizacion", iCotizaciones);
                comando.Parameters.AddWithValue("fCosto", fCostos);
                comando.Parameters.AddWithValue("fDescuento", fDescuentos);
                comando.Parameters.AddWithValue("iExamen", iIdExamenes);
                comando.Parameters.AddWithValue("iEmpleado", iEmpleados);
                comando.Parameters.AddWithValue("iCantidad", iCantidades);
                comando.ExecuteNonQuery();
                MessageBox.Show("Detalle agregado");
                Txt_Cantidad.Text = "";
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
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

        }

        private void Cmb_tipoDeDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Al seleccionar el tipo de descuento, llamamos al procedimiento que nos cargará el tipo de descuento que tendremos.*/
            proSeleccionDeDescuento();

        }

        private void Cmb_laboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Al seleccionar la ubicación del laboratorio, se carga en el textBox  Txt_noLaboratorio el número de laboratorio
             al que esa sucursal pertenece */
            try
            {
                if (Cmb_laboratorio.SelectedValue.ToString() != null)
                {
                    int iLaboratorio = Convert.ToInt32(Cmb_laboratorio.SelectedValue);
                    Txt_noLaboratorio.Text = iLaboratorio.ToString();
                }
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

        }

        private void Cmb_examen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



       

        private void cotizar_Load(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)

        {
            
           contador++;
             double doCantidad = Convert.ToDouble(Txt_Cantidad.Text);
            int iIdExamenes = Convert.ToInt32(Cmb_examen.SelectedValue);
           
            proBuscarCotizacion(iIdExamenes);
             proPrecioyTotal(iIdExamenes);
            proGuardarDetallesCotizacion();

            /*  if (contador > 1)
              {
                  proGuardarDetallesCotizacion();
              }
              else
              {
                  proGuardarCotizacion();
                  proGuardarDetallesCotizacion();
              }*/
           
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
