﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LaboratorioClinico
{
    public partial class Requerimientos : Form
    {
        public Requerimientos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Requerimientos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conexion.ObtenerConexion();
            DataTable dtDatos = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter("select *from examenes where sDescripcion='" + Convert.ToString(Txt_nombrer.Text) + "'", conexion.ObtenerConexion());
            sda.Fill(dtDatos);
            Dgb_requisitosr.DataSource = dtDatos;
            Txt_nombrer.ResetText();
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
