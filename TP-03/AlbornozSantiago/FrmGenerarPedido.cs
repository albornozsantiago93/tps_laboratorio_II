using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AlbornozSantiago
{
    public partial class FrmGenerarPedido : Form
    {
        public List<Empleado> empleados;
        public List<Producto> productos;
        public List<Producto> productosDelCliente;
        public Venta venta;


        public FrmGenerarPedido()
        {
            InitializeComponent();
            productosDelCliente = new List<Producto>();
            
        }

        private void FrmGenerarPedido_Load(object sender, EventArgs e)
        {
            foreach (Producto producto in productos)
            {
                lstProductosEnStock.Items.Add(producto);
            }
            foreach (Empleado empleado in Empleados)
            {
                cmbEmpleadoACargo.Items.Add(empleado);
            }
            

            
        }

        private void btnAgregarProductoAListaCliente_Click(object sender, EventArgs e)
        {            

            if( lstProductosEnStock.SelectedItems != null)
            {
                Producto producto = (Producto)lstProductosEnStock.SelectedItem;

                if(producto.Cantidad > 0)
                {
                    producto.Cantidad--;
                    lstListaProductosCliente.Items.Add(producto);
                }
                else
                {
                    MessageBox.Show("Stock no disponible");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void btnQuitarProductoAListaCliente_Click(object sender, EventArgs e)
        {
            if (lstListaProductosCliente.SelectedItems != null)
            {
                Producto producto = (Producto)lstListaProductosCliente.SelectedItem;

                lstProductosEnStock.Items.Add(producto);
                lstListaProductosCliente.Items.Remove(producto);                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            Empleado empleado = (Empleado)cmbEmpleadoACargo.SelectedItem;

            if (this.ValidarCampos())
            {
                Cliente cliente = new Cliente(txtNobreCliente.Text, txtApellidoCliente.Text, txtNroDeTelefonoCliente.Text, txtDireccionCliente.Text, ProductosDelCliente);                
                Empleado empleadoAux = (Empleado)cmbEmpleadoACargo.SelectedItem;
                Venta venta = new Venta(cliente, empleado);
                venta.empleado.Caja = empleado.CalcularCaja();

                if (venta!=null)
                {
                    MessageBox.Show("Venta realizada con exito");
                    this.Venta = venta;
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("No se pudo realizar la venta");
            }
        }

        private bool ValidarCampos()
        {
            bool retorno = false;

            int nroDeTelefonoAux = Validaciones.ValidarNroDeTelfono(txtNroDeTelefonoCliente.Text);

            Empleado empleado = (Empleado)cmbEmpleadoACargo.SelectedItem;

            if (empleado == null) MessageBox.Show("Seleccioine vendedor");

            if(lstListaProductosCliente != null || empleado != null) 
            {
                foreach (Producto aux in lstListaProductosCliente.Items)
                {
                    ProductosDelCliente.Add(aux);
                }
                if(txtApellidoCliente.Text != string.Empty && txtNobreCliente.Text != string.Empty && txtDireccionCliente.Text != string.Empty)
                {
                    retorno = true;
                }
                else
                {
                    MessageBox.Show("Debe completar los campos primeros");
                }
            }
            else
            {
                MessageBox.Show("Debe agregar productos a la lista del cliente");
            }

            return retorno;
        }





        #region propiedades

        public List<Empleado> Empleados
        {
            get { return this.empleados; }
            set { this.empleados = value; }
        }

        public List<Producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }

        public List<Producto> ProductosDelCliente
        {
            get { return this.productosDelCliente; }
            set { this.productosDelCliente = value; }
        }

        public Venta Venta
        {
            get { return this.venta; }
            set { this.venta = value; }
        }
        #endregion
    }
}
