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
    public partial class Requerimientos : Form
    {
        public Requerimientos()
        {
            InitializeComponent();
            llenarExamen();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void Requerimientos_Load(object sender, EventArgs e)
        {
            //******************************Cargar los examenes***********************************************
           /* OdbcCommand cmd2 = new OdbcCommand("Select sDescripcion from examenes", conexion.ObtenerConexion());
            OdbcDataReader almacen2 = cmd2.ExecuteReader();


            while (almacen2.Read())
            {
                Cmb_examen.Refresh();
                Cmb_examen.Items.Add(almacen2.GetValue(0).ToString());

            }
            conexion.ObtenerConexion().Close();
            almacen2.Close();*/
        }

        public void llenarExamen()
        {

            //Procedimiento para llenar el COMBOBOX de tipo de examen

            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdExamen,sDescripcion from examenes", conexion.ObtenerConexion());
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
        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar y Mostrar los requisitos del examen que es seleccionado
            try
            {
                int idExamen = Convert.ToInt32(Cmb_examen.SelectedValue);
           
            conexion.ObtenerConexion();
            OdbcCommand sda = new OdbcCommand("select sDescripcion as Requisitos from requisitos where iIdRequisitos='" + idExamen + "'", conexion.ObtenerConexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(sda);
            DataTable dtDatos = new DataTable();
            adaptador.Fill(dtDatos);
                          
                   
                Txt_requerimientos.Text = dtDatos.Rows[0][0].ToString();
                
            }catch (Exception ex){

                MessageBox.Show("No se encuentra el examen intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             

            }
           
          
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gpb_requisitos_Enter(object sender, EventArgs e)
        {

        }

        private void Dgb_requisitosr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmb_examen_Click(object sender, EventArgs e)
        {
            Txt_requerimientos.Clear();
        }
    }
}
