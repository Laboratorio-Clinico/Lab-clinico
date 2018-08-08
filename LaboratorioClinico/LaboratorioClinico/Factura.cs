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


namespace LaboratorioClinico
{
    public partial class Factura : Form
    {

        public Factura()
        {
            InitializeComponent();
            formPago();
            obtenerId();
            Lbl_numSerie.Text = Convert.ToString(id+1);
        }
        //@Sindy Batz
        //Validación si efectivo o crédito
        public void formPago()
        {
            try
            {
                Cmb_formaPago.Items.Clear();
                Cmb_formaPago.Text = "Seleccione forma pago";
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdPago,forma from formaPago", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);



                Cmb_formaPago.ValueMember = "iIdPago";
                Cmb_formaPago.DisplayMember = "forma";
                Cmb_formaPago.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        int id;
        private void obtenerId()
        {
            try
            {
                OdbcCommand comando = new OdbcCommand("Select count(*) from factura", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                id = Convert.ToInt32(tabla.Rows[0][0]);
                //MessageBox.Show("Mostrando: " + tabla.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro count");
            }
        }

        public void proGuardarEncabezado()
        {
            try{
                int iIdPago = Convert.ToInt32(Cmb_formaPago.SelectedValue);
                
              
                OdbcCommand comando = new OdbcCommand("{CALL InsertaFactura(?,?,?,?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nIdFactura", Convert.ToInt32(Lbl_numSerie.Text));
                comando.Parameters.AddWithValue("@sSerieFactura", Lbl_serie.Text);
                comando.Parameters.AddWithValue("@dFecha", Dtp_fechaf.Text);
                comando.Parameters.AddWithValue("@sNit", Txt_nitf.Text);
                comando.Parameters.AddWithValue("@iFormaDePago", iIdPago);

                comando.ExecuteNonQuery();
                MessageBox.Show("Datos insertados correctamente");
            }catch (Exception error) { MessageBox.Show("Error" + error); }
                finally
            { conexion.ObtenerConexion().Close();}
        }
        //@Sindy Batz
        //Procedimiento que guardara el detalle de la factura
        public void proGuardarDatosDetalleFactura()
        {
            try{

                OdbcCommand comando = new OdbcCommand("{CALL InsertaDetalleFactura(?,?,?,?,?)}", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nIdFactura", Txt_codigof.Text);
                comando.Parameters.AddWithValue("@iIdExamen", Txt_codigof.Text);
                comando.Parameters.AddWithValue("@iCantidad", Txt_cantidadf.Text);
                comando.Parameters.AddWithValue("@fPrecio", Txt_preciouf.Text);
                comando.Parameters.AddWithValue("@fDescuento", Txt_descuentof.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("Datos insertados correctamente");
            }
            catch (Exception error) { MessageBox.Show("Error" + error); }
                finally
            {    conexion.ObtenerConexion().Close();}
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }       

        private void Lbl_cargarf_Click(object sender, EventArgs e)
        {

        }

        private void Txt_nitf_TextChanged(object sender, EventArgs e)
        {
        }


        int acumulado = 0, cont = 0;
        int acumulado1 = 0, descTotal=0;
        int subtotal=0; int descuento=0; int total=0;

        //Factura Sindy Batz
        private void button1_Click(object sender, EventArgs e)
        {
           
            cont++;
            try
            {
               
                int p, c, d; int a = 0;
                int iIdPago = Convert.ToInt32(Cmb_formaPago.SelectedValue);

                OdbcDataAdapter sda = new OdbcDataAdapter("select count(*) from examenes where iIdExamen= '" + Txt_codigof.Text + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                OdbcDataAdapter sda2 = new OdbcDataAdapter("select ex.iIdExamen, ex.sDescripcion,ex.fPrecio from examenes ex where ex.iIdExamen = '" + Txt_codigof.Text + "'", conexion.ObtenerConexion());
                DataTable datos2 = new DataTable();
                sda2.Fill(datos2);

                c = Convert.ToInt32(Txt_cantidadf.Text);
                p = Convert.ToInt32(datos2.Rows[0][2].ToString());
                d = Convert.ToInt32(Txt_descuentof.Text);

                subtotal = c * p;
                descuento = ((subtotal * d) / 100);
                total = subtotal - descuento;
                acumulado = acumulado + subtotal;//Subtotal
                descTotal = descTotal + descuento;//Total descuento
                acumulado1 = acumulado1 + total;//Total                
                a = a + cont;
                
                if (datos.Rows[0][0].ToString() == "1")
                {
                    Dgb_facturaf.Rows.Add(datos2.Rows[0][0].ToString(), Txt_cantidadf.Text, Txt_descripcion.Text, datos2.Rows[0][2].ToString(), subtotal.ToString(), Txt_descuentof.Text, total.ToString());
                    Lbl_subFf.Text = acumulado.ToString();
                    Lbl_desc.Text = descTotal.ToString();                
                    Lbl_totalFf.Text = acumulado1.ToString();

                    proGuardarDatosDetalleFactura();
                  
                    Txt_codigof.ResetText();
                    Txt_cantidadf.ResetText();
                    Txt_descripcion.ResetText();
                    Txt_preciouf.ResetText();
                    Txt_descuentof.ResetText();

                }
                else{
                    MessageBox.Show("No existe producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{              
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, pa.sDireccion FROM paciente pa WHERE pa.sNit='" + Convert.ToString(Txt_nitf.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_nombref.Text = datos.Rows[0][0].ToString();
                Txt_direccionf.Text = datos.Rows[0][1].ToString();                

            }catch (Exception ex){
                MessageBox.Show("Intente de nuevo.", "Paciente no registrado.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT ex.sDescripcion, ex.fPrecio FROM examenes ex WHERE ex.iIdExamen='" + Convert.ToString(Txt_codigof.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_descripcion.Text = datos.Rows[0][0].ToString();
                Txt_preciouf.Text = datos.Rows[0][1].ToString();

            }catch (Exception ex){
                MessageBox.Show("Intente de nuevo.", "Código no encontrado.", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }
        }

        private void Lbl_noserie_Click(object sender, EventArgs e)
        {
        }

        private void Gpb_datosf_Enter(object sender, EventArgs e)
        {
        }

        private void Cmb_formaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Cmb_formaPago.SelectedValue) == 2)
            {
                Txt_credit.Visible = true;
                Lbl_credit.Visible = true;
            }else if(Convert.ToInt32(Cmb_formaPago.SelectedValue) == 1)
            {
                Txt_credit.Visible = false;
                Lbl_credit.Visible = false;
            }
        }
        //@Sindy Batz
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            int r = 0; int rec = 0;int f =0;int acumulado2;
            int iIdPago = Convert.ToInt32(Cmb_formaPago.SelectedValue);

            if (iIdPago == 2){
                r = ((acumulado1 * 5)/100);
                f = 5;
            }else{
                if (iIdPago == 1){
                    r = 0;
                    f = 0;
                }
            }

            rec = rec + r;//Recargo
            acumulado2 = acumulado1 + rec;//Total 
            Lbl_reC.Text = f.ToString();
            Lbl_totalFf.Text = acumulado2.ToString();
            proGuardarEncabezado();


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
