﻿using System.Data.Odbc;
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

        private void Btn_editar_Click(object sender, EventArgs e) //Copiar los datoa del DataGrid a los textbox para editar o eliminar
        {
            try
            {
                Gpb_datosm.Enabled = true;
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
            //MessageBox.Show("Seleccionar una fila para editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Dgv_examen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
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
    }
}
