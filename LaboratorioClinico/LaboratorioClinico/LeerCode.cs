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
               
                comando = "select pa.nIdPaciente as ID, pa.sNombre as Nombre, ex.sDescripcion as Examen from paciente pa, examenes ex, muestra mu where  mu.nNoExpediente = pa.nIdPaciente and ex.iIdExamen = mu.iIdExamen and mu.inumeroEtiqueta ='" + Convert.ToInt32(Txt_codigo.Text) + "'";
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
