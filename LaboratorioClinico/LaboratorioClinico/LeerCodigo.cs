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
    public partial class LeerCodigo : Form
    {
        public LeerCodigo()
        {
            InitializeComponent();
            Txt_codigo.TabIndex = 1;
        }

        private void LeerCodigo_Load(object sender, EventArgs e)
        {

        }

        private void Bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {
            string comando;
            try
            {
                comando = "select iIdExamen as ID, sDescripcion as Descripcion, fPrecio as Precio from examenes where iIdExamen = '" + Convert.ToInt32(Txt_codigo.Text) + "'";
                OdbcDataAdapter con = new OdbcDataAdapter(comando, conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                con.Fill(datos);
               
                if (datos.Rows.Count > 0)
                {
                    Dgv_resultados.DataSource = datos;
                    Dgv_resultados.Refresh();
                }
                else
                {
                    Dgv_resultados.Columns.Clear();
                    Dgv_resultados.Columns.Add("error", " ");
                    Dgv_resultados.Rows.Add("No existe la muestra");
                }

                conexion.ObtenerConexion().Close();
            }
            catch (Exception ex)
            {
                Dgv_resultados.Columns.Clear();
                Dgv_resultados.Columns.Add("error", " ");
                Dgv_resultados.Rows.Add("No existe la muestra");
            }
           
            
        }

        private void Dgv_resultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
