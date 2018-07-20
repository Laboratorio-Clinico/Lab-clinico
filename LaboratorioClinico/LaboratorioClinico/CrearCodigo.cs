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


        SaveFileDialog Guardar;
        OpenFileDialog OD;

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
            Generar = new BarcodeEncoder();
            Generar.IncludeLabel = true;
            Generar.CustomLabel = Txt_texto.Text;
            if (Txt_texto.Text != "")
                Pic_img.Image = new Bitmap(Generar.Encode(BarcodeFormat.Code39, Txt_texto.Text));
        }
    }
}
