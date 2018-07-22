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

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            cont++;
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from productos where producto= '" + nombreP.Text + "'", conexion.ObtenerConexion());
            MySqlCommand cmd = conexion.ObtenerConexion().CreateCommand();
            DataTable datos = new DataTable();
            sda.Fill(datos);

            MySqlDataAdapter sda2 = new MySqlDataAdapter("select idProducto, precio from productos where producto = '" + nombreP.Text + "'", conexion.ObtenerConexion());
            DataTable datos2 = new DataTable();
            sda2.Fill(datos2);

            MySqlDataAdapter sda3 = new MySqlDataAdapter("select dpi from empleado where nombre ='" + cliente.SelectedItem.ToString() + "'", conexion.ObtenerConexion());
            DataTable datos3 = new DataTable();
            sda3.Fill(datos3);

            int total;
            int p, c;

            c = Convert.ToInt32(cantidadP.Text);
            p = Convert.ToInt32(datos2.Rows[0][1].ToString());


            total = c * p;
            acumulado = acumulado + total;

            if (datos.Rows[0][0].ToString() == "1")
            {
                detalle.Rows.Add(datos2.Rows[0][0].ToString(), nombreP.Text, cantidadP.Text, datos2.Rows[0][1].ToString(), total.ToString());
                tl.Text = acumulado.ToString();
                //
                cmd.CommandText = "insert into detalle values('" + cont + "','" + Convert.ToInt32(orden.Text) + "','" + datos2.Rows[0][0] + "','" + Convert.ToInt32(cantidadP.Text.ToString()) + "')";
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("No existe producto");
            }*/
        }
    }
}
