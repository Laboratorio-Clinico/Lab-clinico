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
    public partial class LeerCodigo : Form
    {
        public LeerCodigo()
        {
            InitializeComponent();
            Txt_codigo.TabIndex = 1;
        }

        private void LeerCodigo_Load(object sender, EventArgs e)
        {

        }

        private void Bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
