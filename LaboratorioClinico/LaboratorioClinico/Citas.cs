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

        private void Btn_agregar_Click(object sender, EventArgs e) //Agregar al data grid los examenes que quiere el paciente 
        {
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("SELECT iIdExamen, sDescripcion, fPrecio from examenes where iIdExamen = '" + Convert.ToInt32(Cmb_examenes.SelectedValue) + "'", conexion.ObtenerConexion());
                DataTable datos = new DataTable();
                sda.Fill(datos);
                Dgv_examen.Rows.Add(datos.Rows[0][0].ToString(), datos.Rows[0][1].ToString(), datos.Rows[0][2].ToString());

                //Guardar detalle de citas
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();
                cmd.CommandText = "insert into detalledecitas values('"+ Convert.ToInt32(Lbl_numeroCita.Text) +"','"+Convert.ToInt32(datos.Rows[0][0])+"')";
                cmd.ExecuteNonQuery();

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
            if (Txt_dpi.TextLength == 13)
            {
                Erp_error.SetError(Txt_dpi, "");
                try
                {
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT sNombre, sNit, sDireccion FROM paciente WHERE nIdPaciente ='" + Convert.ToInt64(Txt_dpi.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);

                    if (datos.Rows.Count > 0)
                    {
                        Txt_nombrep.Text = datos.Rows[0][0].ToString();
                        Txt_nitp.Text = datos.Rows[0][1].ToString();
                        Txt_direp.Text = datos.Rows[0][2].ToString();
                        Pnl_datosp.Enabled = true;
                        Gpb_detalleCita.Enabled = true;
                    }
                    else
                    {
                        this.Hide();
                        new Paciente().ShowDialog();
                        this.Show();
                    }
                    //cargar el # de cita actual
                    obtenerId();
                    Lbl_numeroCita.Text = Convert.ToString(id + 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar paciente..");
                }
            }
            else
            {
                Erp_error.SetError(Txt_dpi, "Deben ingresarse 13 dígitos.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Exámen().ShowDialog();
            this.Show();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            int iStatus = 0;
            try
            {
                //Procedimiento para ingresar encabezado de la cita
                OdbcCommand cm;
                cm = new OdbcCommand("{CALL Pro_ingresaCita(?,?,?,?)}", conexion.ObtenerConexion());
                cm.CommandType = CommandType.StoredProcedure;
                OdbcParameter parametros = new OdbcParameter();

                
                if (Cmb_estado.SelectedItem.ToString() == "No Confirmado")
                {
                    iStatus = 0;
                }
                else if (Cmb_estado.SelectedItem.ToString() == "Confirmado")
                {
                    iStatus = 1;
                }

                cm.Parameters.AddWithValue("dpi", Convert.ToInt32(Txt_dpi.Text));
                cm.Parameters.AddWithValue("fec", Dtp_fecha.Text);
                cm.Parameters.AddWithValue("hor", Txt_hora.Text);
                cm.Parameters.AddWithValue("est", iStatus.ToString());
                cm.ExecuteNonQuery();

                MessageBox.Show("Cita Guardada Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar cita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
