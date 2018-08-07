using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioClinico
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
            prollenarExamen();
        }
        int id;
        private void obtenerId()
        {
            try
            {
                OdbcCommand comando = new OdbcCommand("Select count(*) from citas", conexion.ObtenerConexion());
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

        private void prollenarExamen()
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

                Cmb_examenes.ValueMember = "iIdExamen";
                Cmb_examenes.DisplayMember = "sDescripcion";

                Cmb_examenes.DataSource = tabla;
               
               
                

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }


        private void Citas_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_examen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gpb_detalleCita_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            //Agregar al data grid los examenes que quiere el paciente 
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT iIdExamen, sDescripcion, fPrecio from examenes where iIdExamen = '" + Convert.ToInt32(Cmb_examenes.SelectedValue) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);
                
                Dgv_examen.Rows.Add(datos.Rows[0][0].ToString(), datos.Rows[0][1].ToString(), datos.Rows[0][2].ToString());

                //Crea la muestra
                
                this.Hide();
                new CrearCodigo(Convert.ToInt32(Cmb_examenes.SelectedValue), Convert.ToInt32(Txt_dpi.Text)).ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {

            }
         

        }

        private void Btn_buscar_Click(object sender, EventArgs e)//BUSCAR SI EXISTE CLIENTE, SI NO... INGRESARLO.
        {
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT sNombre, sNit, sDireccion FROM paciente WHERE nIdPaciente ='" + Convert.ToInt32(Txt_dpi.Text) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);

                if (datos.Rows.Count > 0)
                {
                    Txt_nombrep.Text = datos.Rows[0][0].ToString();
                    Txt_nitp.Text = datos.Rows[0][1].ToString();
                    Txt_direp.Text = datos.Rows[0][2].ToString();

                    //cargar el # de cita actual
                    Lbl_numeroCita.Text = Convert.ToString(id + 1);
                }
                else
                {
                    this.Hide();
                    new Paciente().ShowDialog();
                    this.Show();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Exámen().ShowDialog();
            this.Show();
        }
    }
}
