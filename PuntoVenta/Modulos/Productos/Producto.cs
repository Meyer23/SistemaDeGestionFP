using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PuntoVenta.Modulos.Productos;

namespace PuntoVenta.Modulos.Productos
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void cargarCategorias()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                SqlCommand cmd = new SqlCommand("SELECT Descripcion FROM Categorias", con);
                con.Open();
                SqlDataReader reg = cmd.ExecuteReader();
                while (reg.Read())
                {
                    TxtCategoria.Items.Add(reg["Descripcion"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            datalistado.Visible = false;
            cargarCategorias();
            mostrarProductos();
        }

        private void CrearProducto(object sender, EventArgs e)
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
            TxtCodigoProd.Clear();
            TxtDescripcion.Clear();
            TxtCosto.Clear();
            TxtPrecio.Clear();
            TxtPrecioMayorista.Clear();
            TxtPorcUtilidad.Clear();
            TxtExistencia.Clear();
            BtnGuardar.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PanelRegistro.Visible = false;
            TxtBusqueda.Visible = true;
            menuStrip1.Visible = true;
            BtnNuevo.Visible = true;
        }

        private void GuardarProducto(object sender, EventArgs e)
        {
            try
            {
                if (TxtDescripcion.Text != "")
                {

                    if (TxtCodigoProd.Text == "")
                    {
                        TxtCodigoProd.Text = "0";
                    }
                    if (TxtCosto.Text == "")
                    {
                        TxtCosto.Text = "0";
                    }
                    if (TxtPrecio.Text == "")
                    {
                        TxtPrecio.Text = "0";
                    }
                    if (TxtPrecioMayorista.Text == "")
                    {
                        TxtPrecioMayorista.Text = "0";
                    }
                    if (TxtPorcUtilidad.Text == "")
                    {
                        TxtPorcUtilidad.Text = "0";
                    }
                    if (LblImpuesto.Text == "")
                    {
                        LblImpuesto.Text = "0";
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("sp_producto_insertar", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", TxtCodigoProd.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@Costo", TxtCosto.Text);
                        cmd.Parameters.AddWithValue("@Precio", TxtPrecio.Text);
                        cmd.Parameters.AddWithValue("@PrecioMayorista", TxtPrecioMayorista.Text);
                        cmd.Parameters.AddWithValue("@PorcUtilidad", TxtPorcUtilidad.Text);
                        cmd.Parameters.AddWithValue("@Impuesto", LblImpuesto.Text);
                        cmd.Parameters.AddWithValue("@idCategoria", TxtCategoria.Text);
                        cmd.Parameters.AddWithValue("@idUMedida", TxtUMedida.Text);
                        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                        cmd.Parameters.AddWithValue("@Existencia", 0);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        mostrarProductos();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mostrarProductos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("sp_producto_mostrar", con);
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

        private void BuscarProducto(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("sp_producto_buscar", con);
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
    }
}