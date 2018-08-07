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
    public partial class LeerCode : Form
    {
        public LeerCode()
        {
            InitializeComponent();
            Lbl_error.Text = "Escriba o escanee un código";
            Lbl_error.Location = new Point(175, 246);
            Lbl_error.Visible = true;

        }

        private void Dgv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
 
        private void textBox1_TextChanged(object sender, EventArgs e)
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
                   
                    Lbl_error.Visible = false;
                    Dgv_data.DataSource = datos;
                    Dgv_data.Refresh();
                }
                else
                {
                               
                    Dgv_data.Columns.Clear();
                    Lbl_error.Text = "No existe código";
                    Lbl_error.Location = new Point(210, 246);
                    Lbl_error.Visible = true;
                }

                conexion.ObtenerConexion().Close();
            }
            catch (Exception ex)
            {
                Dgv_data.Columns.Clear();
                Lbl_error.Text = "Escriba o escanee un código";
                Lbl_error.Location=new Point(175, 246);
                Lbl_error.Visible = true;
            }

        }

        private void LeerCode_Load(object sender, EventArgs e)
        {
            
        }
    }
}
