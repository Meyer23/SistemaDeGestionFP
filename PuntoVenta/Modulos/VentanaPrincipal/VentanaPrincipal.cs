using PuntoVenta.Modulos.Compras;
using PuntoVenta.Modulos.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PuntoVenta.Modulos.VentanaPrincipal
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosOk frm_usuarios = new UsuariosOk();

            frm_usuarios.ShowDialog();
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            Proveedores frm_proveedores = new Proveedores();

            frm_proveedores.ShowDialog();
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            Clientes frm_clientes = new Clientes();

            frm_clientes.ShowDialog();
        }

        private void MenuProductos_Click(object sender, EventArgs e)
        {
            Producto frm_productos = new Producto();

            frm_productos.ShowDialog();
        }

        private void MenuCategorias_Click(object sender, EventArgs e)
        {
            Categoria frm_categorias = new Categoria();

            frm_categorias.ShowDialog();
        }

        private void MenuUnidadesMedidas_Click(object sender, EventArgs e)
        {
            UnidadesMedidas frm_umedidas = new UnidadesMedidas();

            frm_umedidas.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}