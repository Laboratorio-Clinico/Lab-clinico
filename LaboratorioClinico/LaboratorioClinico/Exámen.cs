using System.Data.Odbc;
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
    public partial class Exámen : Form
    {
        public Exámen()
        {
            InitializeComponent();
            proCargaDatos();
        }

        public static string sCodigo;
        public static string sNombre;
        public static string sPrecio;

        public void proCargaDatos() //Cargar toda la infomación almacenada de los exámenes a un DataGridView.
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdExamen as ID, sDescripcion as Nombre, fPrecio as Precio from examenes", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                //Column1. = "iIdExamen";
                Dgv_examen.DataSource = tabla;
                conexion.ObtenerConexion().Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exámen_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Picb_paciente_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento open = new Mantenimiento();
            open.ShowDialog();
            this.Show();
        }

        private void Btn_editar_Click(object sender, EventArgs e) //Copiar los datos del DataGrid a los textbox para editar
        {
            try
            {
                Gpb_datosm.Enabled = true;
                Txt_codigom.Enabled = false;
                if(Dgv_examen.SelectedRows.Count > 0)
                {
                    Txt_codigom.Text = Dgv_examen.CurrentRow.Cells[0].Value.ToString();
                    Txt_nombrem.Text = Dgv_examen.CurrentRow.Cells[1].Value.ToString();
                    Txt_preciom.Text = Dgv_examen.CurrentRow.Cells[2].Value.ToString();
                }else
                {
                    MessageBox.Show("Seleccionar una fila para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }  
        }

        private void Dgv_examen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_eliminar_Click(object sender, EventArgs e) //Copiar los datos del DataGrid a los textbox para eliminar
        {
            Gpb_datose.Enabled = true;
            if (Dgv_examen.SelectedRows.Count > 0)
            {
                Txt_codigoe.Text = Dgv_examen.CurrentRow.Cells[0].Value.ToString();
                Txt_nombree.Text = Dgv_examen.CurrentRow.Cells[1].Value.ToString();
                Txt_precioe.Text = Dgv_examen.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_confirmarm_Click(object sender, EventArgs e)//Editar examen.......................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                cmd.CommandText = "update examenes set sDescripcion = '" + Txt_nombrem.Text + "' where iIdExamen = '" + Convert.ToInt32(Txt_codigom.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update examenes set fPrecio = '" + Convert.ToUInt32(Txt_preciom.Text) + "' where iIdExamen = '" + Convert.ToInt32(Txt_codigom.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Examen Modificado Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar y deshabilitar
                Txt_codigom.Clear();
                Txt_nombrem.Clear();
                Txt_preciom.Clear();
                Gpb_datosm.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }          
        }

        private void Btn_confirmare_Click(object sender, EventArgs e)//Eliminar información examen....................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Eliminar los datos del examen de 2 tablas que guardan su información
                cmd.CommandText = "delete from examenes where iIdExamen = '" + Convert.ToInt32(Txt_codigoe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from requisitosdeexamen where iIdExamen = '" + Convert.ToInt32(Txt_codigoe.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Examen Eliminado Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Txt_codigoe.Clear();
                Txt_nombree.Clear();
                Txt_precioe.Clear();
                Gpb_datose.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
