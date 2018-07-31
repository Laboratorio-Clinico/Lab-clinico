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
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
           
            cont++;
            OdbcDataAdapter sda = new OdbcDataAdapter("select count(*) from examenes where iIdExamen= '" + Txt_codigof.Text + "'", conexion.ObtenerConexion());
            DataTable datos = new DataTable();
            sda.Fill(datos);

            OdbcDataAdapter sda2 = new OdbcDataAdapter("select ex.iIdExamen, ex.sDescripcion,ex.fPrecio from examenes ex where ex.iIdExamen = '" + Txt_codigof.Text + "'", conexion.ObtenerConexion());
 
            DataTable datos2 = new DataTable();
            sda2.Fill(datos2);

            int subtotal; int descuento;int total;
            int p, c,d;
            c = Convert.ToInt32(Txt_cantidadf.Text);
            p = Convert.ToInt32(datos2.Rows[0][2].ToString());
            d = Convert.ToInt32(Txt_descuentof.Text);
            subtotal = c * p;
            descuento = ((subtotal * d)/100);
            total = subtotal-descuento;
            acumulado  = acumulado + subtotal;//Subtotal
            descTotal = descTotal + descuento;
            acumulado1 = acumulado1 + total;
            int a = 0;
            a = a + cont;

            if (datos.Rows[0][0].ToString() == "1")
            {
                Dgb_facturaf.Rows.Add(datos2.Rows[0][0].ToString(), Txt_cantidadf.Text, Txt_descripcion.Text, datos2.Rows[0][2].ToString(), subtotal.ToString(), Txt_descuentof.Text, total.ToString());
                Lbl_subFf.Text= acumulado.ToString();
                Lbl_desc.Text = descTotal.ToString();
                Lbl_totalFf.Text = acumulado1.ToString();
                Lbl_noserie.Text = a.ToString();
                
                /*cmd.CommandText = "insert into detalledefactura values('" + Convert.ToInt32(Lbl_noserie.Text) + "','" + datos2.Rows[0][0] + "','" + Convert.ToInt32(Txt_cantidadf.Text) + "','" + datos2.Rows[0][2].ToString() + "','" + Convert.ToInt32(Txt_descuentof.Text) + "')";
                cmd.ExecuteNonQuery();*/
		        
                Txt_codigof.ResetText();
                Txt_cantidadf.ResetText();
                Txt_descripcion.ResetText();
                Txt_preciouf.ResetText();
                Txt_descuentof.ResetText();

            }
            else
            {
                MessageBox.Show("No existe producto");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, pa.sDireccion FROM paciente pa WHERE pa.sNit='" + Convert.ToString(Txt_nitf.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_nombref.Text = datos.Rows[0][0].ToString();
                Txt_direccionf.Text = datos.Rows[0][1].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Paciente no registrado.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT ex.sDescripcion, ex.fPrecio FROM examenes ex WHERE ex.iIdExamen='" + Convert.ToString(Txt_codigof.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_descripcion.Text = datos.Rows[0][0].ToString();
                Txt_preciouf.Text = datos.Rows[0][1].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Intente de nuevo.", "Código no encontrado.", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
