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
    public partial class Form1 : Form
    {
        int bandera=1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
              
                    Menu nuevo = new Menu(Txt_usuario.Text);
               
                    this.Visible = false;
                    nuevo.ShowDialog() ;
                    this.Visible=true;
               
                
                    
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
                
        }
    }
}
