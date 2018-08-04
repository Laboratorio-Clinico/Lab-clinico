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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            AbrirReporte(new InicioReportes());
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ganancias_Click(object sender, EventArgs e)
        {
          //  AbrirReporte(new Ganancia());
        }

        private void AbrirReporte(object formReport)
        {
            //Para abrir un form dentro un panel
            if (this.Pnl_Contenedor.Controls.Count > 0)
                this.Pnl_Contenedor.Controls.RemoveAt(0);
            Form fh = formReport as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pnl_Contenedor.Controls.Add(fh);
            this.Pnl_Contenedor.Tag = fh;
            fh.Show();
        }

        private void Lbl_boton_Click(object sender, EventArgs e)
        {
            AbrirReporte(new InicioReportes());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Lbl_inicio_Click(object sender, EventArgs e)
        {
            AbrirReporte(new InicioReportes());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           // AbrirReporte(new RegClientes());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirReporte(new Re_RegCli());
        }
    }
}
