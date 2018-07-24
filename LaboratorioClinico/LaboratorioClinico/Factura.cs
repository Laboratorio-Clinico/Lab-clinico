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
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             cont++;
             MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from Examenes where sDescripcion= '" + Txt_descripcion.Text + "'", conexion.ObtenerConexion());
             MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();
             DataTable datos = new DataTable();
             sda.Fill(datos);

             MySqlDataAdapter sda2 = new MySqlDataAdapter("select iIdExamen, fPrecio from examenes where sDescripcion = '" + Txt_descripcion.Text + "'", conexion.ObtenerConexion());
             DataTable datos2 = new DataTable();
             sda2.Fill(datos2);

           
             int total;
             int p, c;
             c = Convert.ToInt32(Txt_cantidadf.Text);
             p = Convert.ToInt32(datos2.Rows[0][1].ToString());
             total = c * p;
             acumulado = acumulado + total;

             if (datos.Rows[0][0].ToString() == "1")
             {
                Dgb_facturaf.Rows.Add(datos2.Rows[0][0].ToString(), Txt_cantidadf.Text, Txt_descripcion.Text, datos2.Rows[0][1].ToString(), total.ToString());
                 Txt_totalff.Text = acumulado.ToString();
                 //
                 cmd.CommandText = "insert into detalledefactura values('" + cont + "','" + Convert.ToInt32(Txt_nombref.Text) + "','" + datos2.Rows[0][0] + "','" + Convert.ToInt32(Txt_cantidadf.Text.ToString()) + "')";
                 cmd.ExecuteNonQuery();
             }
             else
             {
                 MessageBox.Show("No existe producto");
             }
             */
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
