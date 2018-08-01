﻿using System;
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
    public partial class ConfigUser : Form
    {
        public ConfigUser()
        {
            InitializeComponent();
        }

        private void ConfigUser_Load(object sender, EventArgs e)
        {

            
            //----------------------------------Cargar usuario-----------------------------------------------
            OdbcCommand cmd2 = new OdbcCommand("Select sUsuario from usuario", conexion.ObtenerConexion());
            OdbcDataReader almacen2 = cmd2.ExecuteReader();
            

            while (almacen2.Read())
            {
                Cmb_usuarioEliminar.Refresh();
                Cmb_usuarioEliminar.Items.Add(almacen2.GetValue(0).ToString());
                Cmb_usuario.Refresh();
                Cmb_usuario.Items.Add(almacen2.GetValue(0).ToString());
            }
            conexion.ObtenerConexion().Close();
            almacen2.Close();

            try
            {
                //----------------------------------Cargar Privilegio-----------------------------------------------
                OdbcCommand cmd = new OdbcCommand("Select sPrivilegio from privilegio", conexion.ObtenerConexion());
                OdbcDataReader almacen = cmd.ExecuteReader();

                while (almacen.Read())
                {
                    Cmb_privi.Refresh();
                    Cmb_privi.Items.Add(almacen.GetValue(0).ToString());

                }
                conexion.ObtenerConexion().Close();
                almacen2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
           
            






        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tbc_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcCommand borrar = new OdbcCommand("delete from usuario where sUsuario = '" + Cmb_usuarioEliminar.SelectedItem.ToString() + "'", conexion.ObtenerConexion());
                borrar.ExecuteNonQuery();
                Txt_privilegio.Text = "";

                //-------------------ELIMINAR-----------------------------------------------------------------//
                OdbcCommand cmd2 = new OdbcCommand("Select sUsuario from usuario", conexion.ObtenerConexion());
                OdbcDataReader almacen2 = cmd2.ExecuteReader();

                Cmb_usuarioEliminar.ResetText();
                Cmb_usuarioEliminar.Items.Clear();
                Cmb_usuario.ResetText();
                Cmb_usuario.Items.Clear();

                while (almacen2.Read())
                {
                    Cmb_usuarioEliminar.Refresh();
                    Cmb_usuarioEliminar.Items.Add(almacen2.GetValue(0).ToString());
                    Cmb_usuario.Refresh();
                    Cmb_usuario.Items.Add(almacen2.GetValue(0).ToString());
                }
                conexion.ObtenerConexion().Close();
                almacen2.Close();

                MessageBox.Show("Usuario eliminado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, no hay usuario seleccionado");
            }
           
        }

        private void Cmb_usuarioEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcDataAdapter sda = new OdbcDataAdapter("select sPrivilegio from privilegio where iIdPrivilegio = (select iIdPrivilegio from usuario where sUsuario = '" + Cmb_usuarioEliminar.SelectedItem.ToString() + "')", conexion.ObtenerConexion());
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();
                DataTable datos = new DataTable();
                sda.Fill(datos);

                Txt_privilegio.ResetText();
                Txt_privilegio.Text = datos.Rows[0][0].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Error Seleccionar");
            }
           
        }

        private void Cmb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tbc_control_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_privi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_cambiar_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcCommand borrar = new OdbcCommand("update usuario set iIdPrivilegio = (select iIdPrivilegio from privilegio where sPrivilegio = '" + Cmb_privi.Text + "') where sUsuario ='" + Cmb_usuario.SelectedItem.ToString() + "'", conexion.ObtenerConexion());
                borrar.ExecuteNonQuery();
                MessageBox.Show("Cambios Realizados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
          
        }
    }
}
