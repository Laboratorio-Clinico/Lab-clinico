using System.Data.Odbc;
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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            Tbc_paciente.Visible = false;
            Tbc_medicos.Visible = false;
            //Tbc_examen.Visible = false;
            Tbc_empleado.Visible = false;
            Tbc_mem.Visible = false;
            Picb_fondo.Visible = true;
        }

        public void proValidarCampos()
        {

        }

        public void prollenarSangre() //LLENAR EL COMBOBOX DE TIPO DE SANGRE EN "PACIENTE", POR MEDIO DE UNA CONSULTA
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdTipoDeSangre,sGrupoSanguineo from tipodesangre", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);
                Cmb_tipoSangre.ValueMember = "iIdTipoDeSangre";
                Cmb_tipoSangre.DisplayMember = "sGrupoSanguineo";
                Cmb_tipoSangre.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }
        
        public void prollenarEspecialidad() //LLENAR EL COMBOBOX DE ESPECIALIDAD EN "MÉDICO", POR MEDIO DE UNA CONSULTA
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdEspecialidad,sEspecialidad from especialidad", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);
                Cmb_especialidadMedicoM.ValueMember = "iIdEspecialidad";
                Cmb_especialidadMedicoM.DisplayMember = "sEspecialidad";
                Cmb_especialidadMedicoM.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        public void prollenarEmpresa()  //LLENAR EL COMBOBOX DE EMPRESA EN "MÉDICO", POR MEDIO DE UNA CONSULTA
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdEmpresa,sEmpresa from empresa", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();
            
                adaptador.Fill(tabla);
                Cmb_empresaMedicoM.ValueMember = "iIdEmpresa";
                Cmb_empresaMedicoM.DisplayMember = "sEmpresa";
                Cmb_empresaMedicoM.DataSource = tabla;

                conexion.ObtenerConexion().Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        public void prollenarCargo()  //LLENAR EL COMBOBOX DE CARGO EN "EMPLEADO", POR MEDIO DE UNA CONSULTA
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iIdCargo, sDescripcion from cargo", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);
                Cmb_cargoEmpm.ValueMember = "iIdCargo";
                Cmb_cargoEmpm.DisplayMember = "sDescripcion";
                Cmb_cargoEmpm.DataSource = tabla;

                conexion.ObtenerConexion().Close();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        public void prollenarMembresia()
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand comando = new OdbcCommand("Select iNoMembresia,sDescripcion from membresia", conexion.ObtenerConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();
           
                adaptador.Fill(tabla);
                Cmb_nuevaMembm.ValueMember = "iNoMembresia";
                Cmb_nuevaMembm.DisplayMember = "sDescripcion";
                Cmb_nuevaMembm.DataSource = tabla;

                conexion.ObtenerConexion().Close();

            }
            catch (OdbcException error) { MessageBox.Show(error.Message); }
        }

        private void Gpb_mantenimiento_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_tsangrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_eliminarm_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gpb_datosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)  //Buscar paciente para poder eliminarlo.......................
        {
            if (Txt_expedientep.TextLength == 13)
            {
                Erp_error.SetError(Txt_expedientep, "");
                try
                {
                    Pnl_eliminarP.Visible = true;
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, te.iTelefono  , pa.sNit, sa.sGrupoSanguineo, pa.sDireccion, co.sCorreo, pa.sAlergia, pa.sRefiere, pa.sGenero FROM paciente pa, telefono te, correo co, tipodesangre sa WHERE pa.nIdPaciente = te.nIdPaciente AND pa.nIdPaciente = co.nIdPaciente AND pa.iIdTipoDeSangre = sa.iIdTipoDeSangre AND pa.nIdPaciente='" + Convert.ToInt64(Txt_expedientep.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);

                    //Llenar los campos con el paciente encontrado
                    Txt_nombrep.Text = datos.Rows[0][0].ToString();
                    Txt_telefonop.Text = datos.Rows[0][1].ToString();
                    Txt_nitp.Text = datos.Rows[0][2].ToString();
                    Cmb_tipoSangrep.Text = datos.Rows[0][3].ToString();
                    Txt_direccionp.Text = datos.Rows[0][4].ToString();
                    Txt_correoP.Text = datos.Rows[0][5].ToString(); ;
                    Txt_alergiasp.Text = datos.Rows[0][6].ToString();
                    Txt_refierep.Text = datos.Rows[0][7].ToString();
                    Cmb_sexop.Text = datos.Rows[0][8].ToString();

                    //Deshabilitar los campos, que sean solo de lectura
                    Txt_nombrep.Enabled = false;
                    Txt_telefonop.Enabled = false;
                    Txt_nitp.Enabled = false;
                    Cmb_tipoSangrep.Enabled = false;
                    Txt_direccionp.Enabled = false;
                    Txt_correoP.Enabled = false;
                    Txt_alergiasp.Enabled = false;
                    Txt_refierep.Enabled = false;
                    Cmb_sexop.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Erp_error.SetError(Txt_expedientep, "Deben ingresarse 13 dígitos.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)  //Buscar paciente para modificarlo................................
        {
            
            if (Txt_expe.TextLength == 13)
            {
                Erp_error.SetError(Txt_expe, "");
                try
                {
                    Pnl_modificarP.Visible = true;
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, te.iTelefono  , pa.sNit, sa.sGrupoSanguineo, pa.sDireccion, co.sCorreo, pa.sAlergia, pa.sRefiere, pa.sGenero FROM paciente pa, telefono te, correo co, tipodesangre sa WHERE pa.nIdPaciente = te.nIdPaciente AND pa.nIdPaciente = co.nIdPaciente AND pa.iIdTipoDeSangre = sa.iIdTipoDeSangre AND pa.nIdPaciente='" + Convert.ToInt64(Txt_expe.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);
                    //Llenar todos los campos con los datos del paciente encontrado................................
                    Txt_nombre.Text = datos.Rows[0][0].ToString();
                    Txt_telefono.Text = datos.Rows[0][1].ToString();
                    Txt_nit.Text = datos.Rows[0][2].ToString();
                    Txt_tipoSangre.Text = datos.Rows[0][3].ToString();
                    Txt_direccion.Text = datos.Rows[0][4].ToString();
                    Txt_correo.Text = datos.Rows[0][5].ToString(); ;
                    Txt_alergias.Text = datos.Rows[0][6].ToString();
                    Txt_refiere.Text = datos.Rows[0][7].ToString();
                    Cmb_sexo.Text = datos.Rows[0][8].ToString();
                    //Txt_tipoSangre.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intente de nuevo DPI.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }else
            {
                Erp_error.SetError(Txt_expe, "Deben ingresarse 13 dígitos.");
            }
        }

        private void Btn_editarp_Click(object sender, EventArgs e) //EDITAR PACIENTE.........................................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Realizar updates de cada dato del paciente por si se llegó a modificar alguno.
                cmd.CommandText = "update paciente set sNombre = '" + Txt_nombre.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update telefono set iTelefono = '" + Txt_telefono.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sNit = '" + Txt_nit.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set iIdTipoDeSangre = '" + Txt_tipoSangre.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sDireccion = '" + Txt_direccion.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update correo set sCorreo = '" + Txt_correo.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sAlergia = '" + Txt_alergias.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sRefiere = '" + Txt_refiere.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update paciente set sGenero = '" + Cmb_sexo.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_expe.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Paciente Modificado Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                //Limpiar la información previamente cargada para volver a buscar otro paciente
                Txt_expe.Enabled = true;
                Txt_expe.Clear();
                Pnl_modificarP.Visible = false;

                Txt_nombre.Clear();
                Txt_telefono.Clear();
                Txt_nit.Clear();
                Txt_tipoSangre.Clear();
                Txt_direccion.Clear();
                Txt_correo.Clear();
                Txt_alergias.Clear();
                Txt_refiere.Clear();
                Cmb_sexo.ResetText();  Cmb_sexo.Items.Clear(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_eliminarp_Click(object sender, EventArgs e) //Eliminar paciente..................................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Eliminar los datos del paciente de 4 tablas que guardan su información
                cmd.CommandText = "delete from paciente where nIdPaciente = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from telefono where nIdPaciente = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from correo where nIdPaciente = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                cmd.ExecuteNonQuery();
                //cmd.CommandText = "delete from tipodesangre where iIdTipoDeSangre = '" + Convert.ToInt32(Txt_expedientep.Text) + "'";
                //cmd.ExecuteNonQuery();
                

                MessageBox.Show("Paciente Eliminado Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar todos los textbox / combobox
                Txt_nombrep.Clear();
                Txt_telefonop.Clear();
                Txt_nitp.Clear();
                Cmb_tipoSangrep.ResetText(); Cmb_tipoSangrep.Items.Clear(); 
                Txt_direccionp.Clear();
                Txt_correoP.Clear();
                Txt_alergiasp.Clear();
                Txt_refierep.Clear();
                Cmb_sexop.ResetText();  Cmb_sexop.Items.Clear();

                //Volver a habilitar todos los textbox / combobox
                Pnl_eliminarP.Visible = false;

                Txt_nombrep.Enabled = true;
                Txt_telefonop.Enabled = true;
                Txt_nitp.Enabled = true;
                Cmb_tipoSangrep.Enabled = true;
                Txt_direccionp.Enabled = true;
                Txt_correoP.Enabled = true;
                Txt_alergiasp.Enabled = true;
                Txt_refierep.Enabled = true;
                Cmb_sexop.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }



            
        }

        private void Cmb_tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_tabla.SelectedItem.ToString() == "Paciente")
            {
                Tbc_paciente.Visible = true;
                Tbc_medicos.Visible = false;
               // Tbc_examen.Visible = false;
                Tbc_empleado.Visible = false;
                Tbc_mem.Visible = false;
                Picb_fondo.Visible = false;

            }
            else if(Cmb_tabla.SelectedItem.ToString() == "Médico Asociado")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = true;
               // Tbc_examen.Visible = false;
                Tbc_empleado.Visible = false;
                Tbc_mem.Visible = false;
                Picb_fondo.Visible = false;

            }
            else if (Cmb_tabla.SelectedItem.ToString() == "Exámen")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = false;
                //Tbc_examen.Visible = true;
                Tbc_empleado.Visible = false;
                Tbc_mem.Visible = false;
                Picb_fondo.Visible = false;
            }
            else if (Cmb_tabla.SelectedItem.ToString() == "Empleado")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = false;
                //Tbc_examen.Visible = false;
                Tbc_empleado.Visible = true;
                Tbc_mem.Visible = false;
                Picb_fondo.Visible = false;
            }
            else if (Cmb_tabla.SelectedItem.ToString() == "Membresia")
            {
                Tbc_paciente.Visible = false;
                Tbc_medicos.Visible = false;
                //Tbc_examen.Visible = false;
                Tbc_empleado.Visible = false;
                Tbc_mem.Visible = true;
                Picb_fondo.Visible = false;
            }
        }
        private void Txt_direMedicoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_buscarm_Click(object sender, EventArgs e) //Buscar médico para modificar..........................................
        {
            if (Txt_colegiadoM.TextLength == 13)
            {
                Erp_error.SetError(Txt_colegiadoM, "");
                try
                {
                    Gpb_datos.Visible = true;
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT me.sNombre, me.sApellido, te.itelefono, me.sDireccion, co.sCorreo, es.sEspecialidad, em.sEmpresa, me.dFechaDeNacimiento FROM medicosasociados me, telefono te, correo co, especialidad es, empresa em  WHERE me.nNoColegiado = te.nIdPaciente AND me.nNoColegiado = co.nIdPaciente AND me.iIdEspecialidad = es.iIdEspecialidad AND me.iIdEmpresa = em.iIdEmpresa AND me.nNoColegiado = '" + Convert.ToInt64(Txt_colegiadoM.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);

                    Txt_nombreMedicoM.Text = datos.Rows[0][0].ToString();
                    Txt_apellidoMedicoM.Text = datos.Rows[0][1].ToString();
                    Txt_telefonoMedicoM.Text = datos.Rows[0][2].ToString();
                    Txt_direMedicoM.Text = datos.Rows[0][3].ToString();
                    Txt_correoMedicoM.Text = datos.Rows[0][4].ToString();
                    Txt_especialidadMedicoM.Text = datos.Rows[0][5].ToString();
                    Txt_empresaMedicoM.Text = datos.Rows[0][6].ToString();
                    Dtp_nacimiento.Text = datos.Rows[0][7].ToString();

                    Txt_especialidadMedicoM.Enabled = false;
                    Txt_empresaMedicoM.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Erp_error.SetError(Txt_colegiadoM, "Deben ingresarse 13 dígitos.");
            }
        }

        private void Txt_apellidoMedicoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_editarm_Click(object sender, EventArgs e) //Modificar médico asociado...................................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                cmd.CommandText = "update medicosasociados set sNombre = '" + Txt_nombreMedicoM.Text + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set sApellido = '" + Txt_apellidoMedicoM.Text + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update telefono set iTelefono = '" + Txt_telefonoMedicoM.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set sDireccion = '" + Txt_direMedicoM.Text + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update correo set sCorreo = '" + Txt_correoMedicoM.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set iIdEspecialidad = '" + Convert.ToInt32(Cmb_especialidadMedicoM.SelectedValue) + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set iIdEmpresa = '" + Convert.ToInt32(Cmb_empresaMedicoM.SelectedValue) + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update medicosasociados set dFechaDeNacimiento = '" + Dtp_nacimiento.Text + "' where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoM.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Médico Modificado Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar la información previamente cargada para volver a buscar otro medico
                Txt_colegiadoM.Enabled = true;
                Txt_colegiadoM.Clear();
                Gpb_datos.Visible = false;

                Txt_nombreMedicoM.Clear();
                Txt_apellidoMedicoM.Clear();
                Txt_telefonoMedicoM.Clear();
                Txt_direMedicoM.Clear();
                Txt_correoMedicoM.Clear();
                Txt_empresaMedicoM.Clear();
                Dtp_nacimiento.Refresh();

                //Volver a ocultar los combobox que editan EMPRESA Y ESPECIALIDAD
                Cmb_especialidadMedicoM.Visible = false;
                Lbl_edEspecialidadEspm.Visible = false;
                Btn_edEspeMedicoM.Visible = true;

                Cmb_empresaMedicoM.Visible = false;
                Lbl_edEmpresaEmpm.Visible = false;
                Btn_edEmpreMedicoM.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Cmb_tipoSangre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_tipoSangre.Text = Cmb_tipoSangre.Text;
        }

        private void Btn_eliminarm_Click(object sender, EventArgs e) //Eliminar médico asociado.........................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Eliminar los datos del medico de 3 tablas que guardan su información
                cmd.CommandText = "delete from medicosasociados where nNoColegiado = '" + Convert.ToInt32(Txt_colegiadoE.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from telefono where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoE.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from correo where nIdPaciente = '" + Convert.ToInt32(Txt_colegiadoE.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Médico Eliminado Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar todos los textbox / combobox
                Txt_nombreMedicoE.Clear();
                Txt_apellidoMedicoE.Clear();
                Txt_telMedicoE.Clear();
                Txt_direMedicoE.Clear();
                Txt_correoMedicoE.Clear();
                Cmb_especialidadMedicoE.ResetText(); Cmb_especialidadMedicoE.Items.Clear();
                Cmb_empresaMedicoE.ResetText(); Cmb_empresaMedicoE.Items.Clear();
                Dtp_nacimientoE.Refresh();
                //Dtp_nacimientoE.CustomFormat = " ";


                //Volver a habilitar todos los textbox / combobox
                Txt_nombreMedicoE.Enabled = true;
                Txt_apellidoMedicoE.Enabled = true;
                Txt_telMedicoE.Enabled = true;
                Txt_direMedicoE.Enabled = true;
                Txt_correoMedicoE.Enabled = true;
                Cmb_especialidadMedicoE.Enabled = true;
                Cmb_empresaMedicoE.Enabled = true;
                Dtp_nacimientoE.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_buscarE_Click(object sender, EventArgs e) // Buscar médico para eliminarlo............................
        {
            if (Txt_colegiadoE.TextLength == 13)
            {
                Erp_error.SetError(Txt_colegiadoE, "");
                try
                {
                    Gpb_datosEliminar.Visible = true;
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT me.sNombre, me.sApellido, te.itelefono, me.sDireccion, co.sCorreo, es.sEspecialidad, em.sEmpresa, me.dFechaDeNacimiento FROM medicosasociados me, telefono te, correo co, especialidad es, empresa em  WHERE me.nNoColegiado = te.nIdPaciente AND me.nNoColegiado = co.nIdPaciente AND me.iIdEspecialidad = es.iIdEspecialidad AND me.iIdEmpresa = em.iIdEmpresa AND me.nNoColegiado ='" + Convert.ToInt64(Txt_colegiadoE.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);

                    Txt_nombreMedicoE.Text = datos.Rows[0][0].ToString();
                    Txt_apellidoMedicoE.Text = datos.Rows[0][1].ToString();
                    Txt_telMedicoE.Text = datos.Rows[0][2].ToString();
                    Txt_direMedicoE.Text = datos.Rows[0][3].ToString();
                    Txt_correoMedicoE.Text = datos.Rows[0][4].ToString();
                    Cmb_especialidadMedicoE.Text = datos.Rows[0][5].ToString();
                    Cmb_empresaMedicoE.Text = datos.Rows[0][6].ToString();
                    Dtp_nacimientoE.Text = datos.Rows[0][7].ToString();

                    //Deshabilitar los campos, que sean solo de lectura
                    Txt_nombreMedicoE.Enabled = false;
                    Txt_apellidoMedicoE.Enabled = false;
                    Txt_telMedicoE.Enabled = false;
                    Txt_direMedicoE.Enabled = false;
                    Txt_correoMedicoE.Enabled = false;
                    Cmb_especialidadMedicoE.Enabled = false;
                    Cmb_empresaMedicoE.Enabled = false;
                    Dtp_nacimientoE.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Erp_error.SetError(Txt_colegiadoE, "Deben ingresarse 13 dígitos.");
            }


        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_especialidadMedicoM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_especialidadMedicoM.Text = Cmb_especialidadMedicoM.Text;
        }

        private void Cmb_empresaMedicoM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_empresaMedicoM.Text = Cmb_empresaMedicoM.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cmb_tipoSangre.Visible = true;
            Lbl_editarSangrep.Visible = true;
            Btn_editarSangrep.Visible = false;
            prollenarSangre();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cmb_especialidadMedicoM.Visible = true;
            Lbl_edEspecialidadEspm.Visible = true;
            Btn_edEspeMedicoM.Visible = false;
            prollenarEspecialidad();
        }

        private void Btn_edEmpreMedicoM_Click(object sender, EventArgs e)
        {
            Cmb_empresaMedicoM.Visible = true;
            Lbl_edEmpresaEmpm.Visible = true;
            Btn_edEmpreMedicoM.Visible = false;
            prollenarEmpresa();
        }

        private void Gpb_datosEmpm_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_buscarEmpe_Click(object sender, EventArgs e)//BUSCAR EMPLEADO PARA ELIMINARLO
        {
            if (Txt_dpiEmpe.TextLength == 13)
            {
                Erp_error.SetError(Txt_dpiEmpe, "");
                try
                {
                    Gpb_datosEmpe.Visible = true;
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT em.sNombre, em.sApellido, em.sDireccion, te.itelefono, co.sCorreo, em.fSueldo, ca.sDescripcion, em.dFechaDeNacimiento FROM empleado em, telefono te, correo co, cargo ca WHERE em.nIdEmpleado = te.nIdPaciente AND em.nIdEmpleado = co.nIdPaciente AND em.iIdCargo = ca.iIdCargo AND em.nIdEmpleado ='" + Convert.ToInt64(Txt_dpiEmpe.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);

                    Txt_nombreEmpe.Text = datos.Rows[0][0].ToString();
                    Txt_apellidoEmpe.Text = datos.Rows[0][1].ToString();
                    Txt_direEmpe.Text = datos.Rows[0][2].ToString();
                    Txt_telEmpe.Text = datos.Rows[0][3].ToString();
                    Txt_correoEmpe.Text = datos.Rows[0][4].ToString();
                    Txt_sueldoEmpe.Text = datos.Rows[0][5].ToString();
                    Txt_cargoEmpe.Text = datos.Rows[0][6].ToString();
                    Dtp_fechaEmpe.Text = datos.Rows[0][7].ToString();

                    //Deshabilitar los campos, que sean solo de lectura
                    Txt_nombreEmpe.Enabled = false;
                    Txt_apellidoEmpe.Enabled = false;
                    Txt_direEmpe.Enabled = false;
                    Txt_telEmpe.Enabled = false;
                    Txt_correoEmpe.Enabled = false;
                    Txt_sueldoEmpe.Enabled = false;
                    Txt_cargoEmpe.Enabled = false;
                    Dtp_fechaEmpe.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("error:"+ex);
                }
            }
            else
            {
                Erp_error.SetError(Txt_dpiEmpe, "Deben ingresarse 13 dígitos.");
            }




        }

        private void Btn_buscarEmpm_Click(object sender, EventArgs e) //BUSCAR EMPLEADO PARA MODIFICARLO.............................................
        {
            if (Txt_dpiEmpm.TextLength == 13)
            {
                Erp_error.SetError(Txt_dpiEmpm, "");
                try
                {
                    Gpb_datosEmpm.Visible = true;
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT em.sNombre, em.sApellido, em.sDireccion, te.itelefono, co.sCorreo, em.fSueldo, ca.sDescripcion, em.dFechaDeNacimiento FROM empleado em, telefono te, correo co, cargo ca WHERE em.nIdEmpleado = te.nIdPaciente AND em.nIdEmpleado = co.nIdPaciente AND em.iIdCargo = ca.iIdCargo AND em.nIdEmpleado ='" + Convert.ToInt64(Txt_dpiEmpm.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);

                    Txt_nombreEmpm.Text = datos.Rows[0][0].ToString();
                    Txt_apellidoEmpm.Text = datos.Rows[0][1].ToString();
                    Txt_direEmpm.Text = datos.Rows[0][2].ToString();
                    Txt_telEmpm.Text = datos.Rows[0][3].ToString();
                    Txt_correoEmpm.Text = datos.Rows[0][4].ToString();
                    Txt_sueldoEmpm.Text = datos.Rows[0][5].ToString();
                    Txt_cargoEmpm.Text = datos.Rows[0][6].ToString();
                    Dtp_fechaEmpm.Text = datos.Rows[0][7].ToString();

                    Txt_cargoEmpm.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("error:"+ex);
                }
            }
            else
            {
                Erp_error.SetError(Txt_dpiEmpm, "Deben ingresarse 13 dígitos.");
            }
        }

        private void Btn_edCargoEmpm_Click(object sender, EventArgs e)
        {
            Cmb_cargoEmpm.Visible = true;
            Lbl_edCargoEmpm.Visible = true;
            Btn_edCargoEmpm.Visible = false;
            prollenarCargo();
        }

        private void Cmb_cargoEmpm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_cargoEmpm.Text = Cmb_cargoEmpm.Text;
        }

        private void Btn_editarEmpm_Click(object sender, EventArgs e)//MODIFICAR LA TABLA DE EMPLEADO.....................................
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                cmd.CommandText = "update empleado set sNombre = '" + Txt_nombreEmpm.Text + "' where nIdEmpleado = '" + Convert.ToInt32(Txt_dpiEmpm.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update empleado set sApellido = '" + Txt_apellidoEmpm.Text + "' where nIdEmpleado = '" + Convert.ToInt32(Txt_dpiEmpm.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update empleado set sDireccion = '" + Txt_direEmpm.Text + "' where nIdEmpleado = '" + Convert.ToInt32(Txt_dpiEmpm.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update telefono set iTelefono = '" + Txt_telEmpm.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_dpiEmpm.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update correo set sCorreo = '" + Txt_correoEmpm.Text + "' where nIdPaciente = '" + Convert.ToInt32(Txt_dpiEmpm.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update empleado set fSueldo = '" + Txt_sueldoEmpm.Text + "' where nIdEmpleado = '" + Convert.ToInt32(Txt_dpiEmpm.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update empleado set iIdCargo = '" + Convert.ToInt32(Cmb_cargoEmpm.SelectedValue) + "' where nIdEmpleado = '" + Convert.ToInt32(Txt_dpiEmpm.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update empleado set dFechaDeNacimiento = '" + Dtp_fechaEmpm.Text + "' where nIdEmpleado = '" + Convert.ToInt32(Txt_dpiEmpm.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Médico Modificado Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar la información previamente cargada para volver a buscar otro medico
                Txt_dpiEmpm.Enabled = true;
                Txt_dpiEmpm.Clear();
                Gpb_datosEmpm.Visible = false;

                Txt_nombreEmpm.Clear();
                Txt_apellidoEmpm.Clear();
                Txt_direEmpm.Clear();
                Txt_telEmpm.Clear();
                Txt_correoEmpm.Clear();
                Txt_sueldoEmpm.Clear();
                Dtp_fechaEmpm.Refresh();

                //Volver a ocultar los combobox que editan EMPRESA Y ESPECIALIDAD
                Cmb_cargoEmpm.Visible = false;
                Lbl_edCargoEmpm.Visible = false;
                Btn_edCargoEmpm.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_eliminarEmpe_Click(object sender, EventArgs e) //ELIMINAR EMPLEADO
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Eliminar los datos del empleado de 3 tablas que guardan su información
                cmd.CommandText = "delete from empleado where nIdEmpleado = '" + Convert.ToInt32(Txt_dpiEmpe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from telefono where nIdPaciente = '" + Convert.ToInt32(Txt_dpiEmpe.Text) + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from correo where nIdPaciente = '" + Convert.ToInt32(Txt_dpiEmpe.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Empleado Eliminado Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar todos los textbox / combobox
                Txt_nombreEmpe.Clear();
                Txt_apellidoEmpe.Clear();
                Txt_direEmpe.Clear();
                Txt_telEmpe.Clear();
                Txt_correoEmpe.Clear();
                Txt_cargoEmpe.Clear();
                Txt_sueldoEmpe.Clear();
                Dtp_fechaEmpe.Refresh();


                //Volver a habilitar todos los textbox / combobox
                Txt_nombreEmpe.Enabled = true;
                Txt_apellidoEmpe.Enabled = true;
                Txt_direEmpe.Enabled = true;
                Txt_telEmpe.Enabled = true;
                Txt_correoEmpe.Enabled = true;
                Txt_cargoEmpe.Enabled = true;
                Txt_sueldoEmpe.Enabled = true;
                Dtp_fechaEmpe.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                //MessageBox.Show("error:"+ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                cmd.CommandText = "update membresiadepaciente set iNoMembresia = '" + Convert.ToInt32(Cmb_nuevaMembm.SelectedValue) + "' where nNoExpediente = '" + Convert.ToInt32(Txt_dpiMembm.Text) + "'";
                cmd.ExecuteNonQuery();
        

                MessageBox.Show("Membresia Modificada Exitosamente.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Limpiar la información previamente cargada para volver a buscar otro medico
                Txt_dpiMembm.Clear();
                Txt_nombreMembm.Clear();
                Txt_actualMembm.Clear();
                Gpb_datosMembm.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)//Buscar paciente con membresía para modificarla
        {
            if (Txt_dpiMembm.TextLength == 13)
            {
                Erp_error.SetError(Txt_dpiMembm, "");
                try
                {
                    Gpb_datosMembm.Visible = true;
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, pa.sNit, me.sDescripcion FROM paciente pa, membresia me, membresiadepaciente mp WHERE pa.nIdPaciente = mp.nNoExpediente AND me.iNoMembresia = mp.iNoMembresia AND pa.nIdPaciente ='" + Convert.ToInt64(Txt_dpiMembm.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);

                    Txt_nombreMembm.Text = datos.Rows[0][0].ToString();
                    Txt_nitMembm.Text = datos.Rows[0][1].ToString();
                    Txt_actualMembm.Text = datos.Rows[0][2].ToString();

                    Txt_actualMembm.Enabled = false;
                    prollenarMembresia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("error:"+ex);

                }
            }
            else
            {
                Erp_error.SetError(Txt_dpiMembm, "Deben ingresarse 13 dígitos.");
            }





        }

        private void Txt_dpiMembm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) //Buscar empleado con membresia para cancelarla.............................
        {
            if (Txt_dpiMembe.TextLength == 13)
            {
                Erp_error.SetError(Txt_dpiMembe, "");
                try
                {
                    Gpb_datosMembe.Visible = true;
                    OdbcDataAdapter sda = new OdbcDataAdapter("SELECT pa.sNombre, pa.sNit, me.sDescripcion FROM paciente pa, membresia me, membresiadepaciente mp WHERE pa.nIdPaciente = mp.nNoExpediente AND me.iNoMembresia = mp.iNoMembresia AND pa.nIdPaciente ='" + Convert.ToInt64(Txt_dpiMembe.Text) + "'", conexion.ObtenerConexion());
                    DataTable datos = new DataTable();
                    sda.Fill(datos);

                    Txt_nombreMembe.Text = datos.Rows[0][0].ToString();
                    Txt_nitMembe.Text = datos.Rows[0][1].ToString();
                    Txt_membreMembe.Text = datos.Rows[0][2].ToString();

                    //Deshabilitar los textbox donde se cargó la información
                    Txt_nombreMembe.Enabled = false;
                    Txt_nitMembe.Enabled = false;
                    Txt_membreMembe.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intente de nuevo.", "Error en la búsqueda.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("error:" + ex);

                }
            }
            else
            {
                Erp_error.SetError(Txt_dpiMembe, "Deben ingresarse 13 dígitos.");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cancelMembe_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ObtenerConexion();
                OdbcCommand cmd = conexion.ObtenerConexion().CreateCommand();

                //Eliminar los datos del empleado de 3 tablas que guardan su información
                cmd.CommandText = "delete from membresiadepaciente where nNoExpediente = '" + Convert.ToInt32(Txt_dpiMembe.Text) + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Membresía Eliminada Exitosamente", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Gpb_datosMembe.Visible = false;

                //Limpiar todos los textbox / combobox
                Txt_dpiMembe.Clear();
                Txt_nombreMembe.Clear();
                Txt_nitMembe.Clear();
                Txt_membreMembe.Clear();

                //Volver a habilitar todos los textbox / combobox
                Txt_nombreMembe.Enabled = true;
                Txt_nitMembe.Enabled = true;
                Txt_membreMembe.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                //MessageBox.Show("error:"+ex);
            }
        }

        private void Txt_expe_Validating(object sender, CancelEventArgs e)
        {
            if(Txt_expe.TextLength != 8)
            {
                Erp_error.SetError(Txt_expe, "El DPI debe contener 13 dígitos.");
            }else
            {
                Erp_error.SetError(Txt_expe, "");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
