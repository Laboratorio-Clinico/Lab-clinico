using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.Barcode;
using System.Data.Odbc;

namespace LaboratorioClinico
{
    public partial class CrearCodigo : Form
    {
        public CrearCodigo(int codigo, long dpi)
        {
            InitializeComponent();       
            obtenerId();
            Txt_texto.Text = id+Convert.ToString(codigo);
            llenarMuestra(codigo, dpi);
        }

      
        BarcodeEncoder Crear;
        BarcodeDecoder Escaner;
        SaveFileDialog Guardar;
        int id;
        //  OpenFileDialog OD;

        public object Generar { get; private set; }

        private void CrearCodigo_Load(object sender, EventArgs e)
        {

        }

        private void llenarMuestra(int examen, long dpi)
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();
                cmd.CommandText = "insert into muestra values(null,'" + examen + "','" + dpi + "','"+Convert.ToInt64(Txt_texto.Text)+"')";
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo insertar datos: "+ ex);
            }
           
        }

        private void obtenerId()
        {
            
            try
            {
               
                OdbcCommand comando = new OdbcCommand("Select count(*) from muestra", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                id = Convert.ToInt32(tabla.Rows[0][0]);
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se encontro count");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardar = new SaveFileDialog();
            Guardar.Filter = "PNG File |*.png";
            if (Guardar.ShowDialog() == DialogResult.OK)
                Pic_img.Image.Save(Guardar.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            int iAux;
            try
            {
                if (int.TryParse(Txt_texto.Text, out iAux))
                {
                    Er_validar.SetError(Txt_texto, "");
                    Crear = new BarcodeEncoder();
                    Crear.IncludeLabel = true;
                    Crear.CustomLabel = Txt_texto.Text;
                    if (Txt_texto.Text != "")
                        Pic_img.Image = new Bitmap(Crear.Encode(BarcodeFormat.Code39, Txt_texto.Text));

                }else
                {
                    Er_validar.SetError(Txt_texto, "Solo números se acepta");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Dato invalido: " + ex.Message);
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_texto_Validating(object sender, CancelEventArgs e)
        {
           /* int iNum;
            if(!int.TryParse(Txt_texto.Text, out iNum)){
                Er_validar.SetError(Txt_texto,"Solo números se acepta");
            }else
            {
                Er_validar.SetError(Txt_texto, "");
            }*/

        }
    }
}
