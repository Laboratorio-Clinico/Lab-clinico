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

namespace LaboratorioClinico
{
    public partial class CrearCodigo : Form
    {
        public CrearCodigo()
        {
            InitializeComponent();
        }

        BarcodeEncoder Crear;
        BarcodeDecoder Escaner;
        SaveFileDialog Guardar;
      //  OpenFileDialog OD;

        public object Generar { get; private set; }

        private void CrearCodigo_Load(object sender, EventArgs e)
        {

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
            try
            {
                Crear = new BarcodeEncoder();
                Crear.IncludeLabel = true;
                Crear.CustomLabel = Txt_texto.Text;
                if (Txt_texto.Text != "")
                    Pic_img.Image = new Bitmap(Crear.Encode(BarcodeFormat.Code39, Txt_texto.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Dato invalido: " + ex.Message);
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
