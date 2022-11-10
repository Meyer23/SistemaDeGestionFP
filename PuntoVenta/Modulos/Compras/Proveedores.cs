using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace PuntoVenta.Modulos.Compras
{
    public partial class Proveedores : Form
    {
        int idProveedor;
        string estadoProveedor;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            mostrarProveedores();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtBusqueda.Visible = false;
            menuStrip1.Visible = false;
            BtnNuevo.Visible = false;
            PanelRegistro.Visible = true;
            BtnGuardarCambios.Visible = false;
            limpiar();
        }

        private void limpiar()
        {
            TxtNombre.Clear();
            TxtRazonSocial.Clear();
            TxtRuc.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtCelular.Clear();
            TxtCorreo.Clear();
            TxtNombre.Focus();
            BtnGuardar.Visible = true;
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
                if (TxtNombre.Text != "" && TxtRuc.Text != "")
                {

                    if (TxtDireccion.Text == "")
                    {
                        TxtDireccion.Text = "Paraguay";
                    }
                    if (TxtTelefono.Text == "")
                    {
                        TxtTelefono.Text = "0";
                    }
                    if (TxtCelular.Text == "")
                    {
                        TxtCelular.Text = "0";
                    }
                    if (TxtCorreo.Text == "")
                    {
                        TxtCorreo.Text = "0";
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_proveedor_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSocial.Text);
                        cmd.Parameters.AddWithValue("@Ruc", TxtRuc.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                        cmd.Parameters.AddWithValue("@Saldo", 0);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarProveedores();
                        PanelRegistro.Visible = false;
                        TxtBusqueda.Visible = true;
                        menuStrip1.Visible = true;
                        BtnNuevo.Visible = true;
                        limpiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incompletos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool ValidarCorreo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void mostrarProveedores()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_proveedor_mostrar", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }      
        
        private void BuscarProveedor(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_proveedor_buscar", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@texto", TxtBusqueda.Text);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
                ocultar_columnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cambiar_color_eliminados();
        }

        private void cambiar_color_eliminados()
        {
            foreach (DataGridViewRow row in datalistado.Rows)
            {
                if (row.Cells["Estado"].Value.ToString() == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Strikeout);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void ocultar_columnas()
        {
            datalistado.Columns[2].Visible = false;
        }

        private void EliminarProveedor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Está seguro de eliminar este proveedor del sistema?", "Eliminando registro...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in datalistado.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["idProveedor"].Value);

                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = Conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("sp_proveedor_eliminar", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@idProveedor", onekey);
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
                        mostrarProveedores();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void EditarProveedor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                BtnGuardar.Visible = false;
                BtnGuardarCambios.Visible = true;
                ObtenerDatosProveedor();
            }
        }

        private void EditarProveedor2(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Visible = false;
            BtnGuardarCambios.Visible = true;
            ObtenerDatosProveedor();
        }

        private void ObtenerDatosProveedor()
        {
            try
            {
                estadoProveedor = datalistado.SelectedCells[10].Value.ToString();
                if (estadoProveedor == "ELIMINADO")
                {
                    restaurarProveedor();
                }
                else
                {
                    idProveedor = Convert.ToInt32(datalistado.SelectedCells[2].Value.ToString());
                    TxtNombre.Text = datalistado.SelectedCells[3].Value.ToString();
                    TxtRazonSocial.Text = datalistado.SelectedCells[4].Value.ToString();
                    TxtRuc.Text = datalistado.SelectedCells[5].Value.ToString();
                    TxtDireccion.Text = datalistado.SelectedCells[6].Value.ToString();
                    TxtTelefono.Text = datalistado.SelectedCells[7].Value.ToString();
                    TxtCelular.Text = datalistado.SelectedCells[8].Value.ToString();
                    TxtCorreo.Text = datalistado.SelectedCells[9].Value.ToString();
               
                    TxtBusqueda.Visible = false;
                    menuStrip1.Visible = false;
                    BtnNuevo.Visible = false;
                    PanelRegistro.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (!ValidarCorreo(TxtCorreo.Text))
            {
                MessageBox.Show("Dirección de correo electrónico no válida, el correo debe tener el formato: nombre@dominio.com, " + " por favor, seleccione un correo válido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCorreo.Focus();
                TxtCorreo.SelectAll();
            }
            else
            {
                if (TxtNombre.Text != "" && TxtRuc.Text != "")
                {

                    if (TxtDireccion.Text == "")
                    {
                        TxtDireccion.Text = "Paraguay";
                    }
                    if (TxtTelefono.Text == "")
                    {
                        TxtTelefono.Text = "0";
                    }
                    if (TxtCelular.Text == "")
                    {
                        TxtCelular.Text = "0";
                    }
                    if (TxtCorreo.Text == "")
                    {
                        TxtCorreo.Text = "0";
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_proveedor_editar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSocial.Text);
                        cmd.Parameters.AddWithValue("@Ruc", TxtRuc.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Celular", TxtCelular.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarProveedores();
                        PanelRegistro.Visible = false;
                        TxtBusqueda.Visible = true;
                        menuStrip1.Visible = true;
                        BtnNuevo.Visible = true;
                        limpiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incompletos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void restaurarProveedor()
        {
            DialogResult result;
            result = MessageBox.Show("Este proveedor se encuentra eliminado, ¿Desea volver a Habilitarlo?", "Restauración de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datalistado.SelectedRows)
                {
                    int idProveedor = Convert.ToInt32(row.Cells["idProveedor"].Value);
                    try
                    {
                        SqlCommand cmd;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        cmd = new SqlCommand("sp_proveedor_restaurar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    mostrarProveedores();
                }
            }
        }
    }
}
