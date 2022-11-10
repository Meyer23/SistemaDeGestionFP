using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuntoVenta.Modulos
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            MostrarClientes();
        }

        private void Btn_NuevoCliente(object sender, EventArgs e)
        {
            PanelCliente.Hide();
            PanelNuevoCliente.Show();
            DataGridViewClientes.Hide();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {



                if (TxtNombresCliente.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("dbo.sp_clientes_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombresCliente.Text);
                        cmd.Parameters.AddWithValue("@RUC_CI", TxtRuc.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);

                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();

                        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                        cmd.Parameters.AddWithValue("@Saldo", 0);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        PanelNuevoCliente.Hide();
                        PanelCliente.Show();
                        DataGridViewClientes.Show();
                        MostrarClientes();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }

        public bool ValidarCorreo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");

        }

        private void MostrarClientes()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_clientes_mostrar", con);




                da.Fill(dt);
                DataGridViewClientes.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelCliente.Show();
            PanelNuevoCliente.Hide();
            DataGridViewClientes.Show();
            MostrarClientes();
            limpiar();
        }

        private void limpiar()
        {
            TxtNombresCliente.Clear();
            TxtRuc.Clear();
            TxtCorreo.Clear();
            TxtRuc.Clear();
            TxtCelular.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            BtnGuardarCliente.Visible = true;
        }

        private void BuscarCliente()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("dbo.sp_cliente_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBuscarCliente.Text);
                da.Fill(dt);
                DataGridViewClientes.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Buscar_Cliente(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void EliminarCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.DataGridViewClientes.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox
                .Show("¿Está seguro de eliminar este cliente del sistema?", "Eliminando", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in DataGridViewClientes.SelectedRows)
                        {

                            int onekey = Convert.ToInt32(row.Cells["idCliente"].Value);

                            try
                            {

                                try
                                {

                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("dbo.sp_clientes_eliminar", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@idCliente", onekey);
                                    cmd.ExecuteNonQuery();

                                    con.Close();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }

                        }
                        MostrarClientes();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void EditarCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.DataGridViewClientes.Columns["Editar"].Index)
            {
                BtnGuardarCliente.Visible = false;
                BtnGuardarEditado.Visible = true;
                ObtenerDatosCliente();
            }
        }

        private void ObtenerDatosCliente()
        {
            try
            {
                idUsuario_Label.Text = DataGridViewClientes.SelectedCells[2].Value.ToString();
                TxtNombresCliente.Text = DataGridViewClientes.SelectedCells[3].Value.ToString();
                TxtRuc.Text = DataGridViewClientes.SelectedCells[4].Value.ToString();
                TxtDireccion.Text = DataGridViewClientes.SelectedCells[5].Value.ToString();
                TxtTelefono.Text = DataGridViewClientes.SelectedCells[6].Value.ToString();
                TxtCelular.Text = DataGridViewClientes.SelectedCells[7].Value.ToString();
                TxtCorreo.Text = DataGridViewClientes.SelectedCells[8].Value.ToString();

                PanelCliente.Hide();
                DataGridViewClientes.Hide();
                PanelNuevoCliente.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardar_Editado(object sender, EventArgs e)
        {
            if (!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                if (TxtNombresCliente.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("dbo.sp_clientes_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idCliente", idUsuario_Label.Text);
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombresCliente.Text);
                        cmd.Parameters.AddWithValue("@RUC_CI", TxtRuc.Text);

                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();

                        cmd.ExecuteNonQuery();
                        con.Close();
                        PanelNuevoCliente.Hide();
                        PanelCliente.Show();
                        DataGridViewClientes.Show();
                        MostrarClientes();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }
    }
}