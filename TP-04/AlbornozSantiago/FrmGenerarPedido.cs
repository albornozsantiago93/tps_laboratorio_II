using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AlbornozSantiago
{
    // THREADS  
    public partial class FrmGenerarPedido : Form
    {
        public List<Empleado> empleados;
        public List<Producto> productos;
        public List<Producto> productosDelCliente;
        public Venta venta;

        //Task task;
        CancellationTokenSource source;
        CancellationToken token;


        public FrmGenerarPedido()
        {
            InitializeComponent();
            productosDelCliente = new List<Producto>();

            source = new CancellationTokenSource();
            token = source.Token;
        }

        public FrmGenerarPedido(List<Producto> productos, List<Empleado> empleados)
            :this()
        {
            this.productos = productos;
            this.empleados = empleados;
        }

        // CARGA LA LISTA DE LOS PRODUCTOS DISPONIBLES Y LOS EMPLEADOS A CARGO
        private void FrmGenerarPedido_Load(object sender, EventArgs e)
        {
            cmbEmpleadoACargo.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Producto producto in productos)
            {
                lstProductosEnStock.Items.Add(producto);
            }            

            foreach (Empleado empleado in Empleados)
            {
                if(empleado != null)
                {
                    cmbEmpleadoACargo.Items.Add(empleado);
                }           
            }

            Task.Run(() => IniciarHora(token));
        }

        // INICIALIZA LA HORA PARA MOSTRAR
        private void IniciarHora(CancellationToken token)
        {
            do
            {
                if (token.IsCancellationRequested)
                    return;

                AsignarHora();
                Thread.Sleep(1000);
            } while (true);
        }

        // ASGINA HORA AL LBLHORAACTUAL
        private void AsignarHora()
        {
            if (this.InvokeRequired)
            {
                Action delegado = AsignarHora;
                this.Invoke(delegado);
            }
            else
            {
                lblHoraActual.Text = DateTime.Now.ToString();
            }
        }
        
        // GENERA LA VENTA 
        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                List<Producto> lista = new List<Producto>();
                float importe = 0;
                foreach (Producto aux in this.lstListaProductosCliente.Items)
                {
                    lista.Add(aux);
                    importe += aux.Precio;
                }                

                Cliente cliente = new Cliente(txtNobreCliente.Text, txtApellidoCliente.Text, txtNroDeTelefonoCliente.Text, txtDireccionCliente.Text, lista, importe);
                Empleado empleado = (Empleado)cmbEmpleadoACargo.SelectedItem;
                empleado.Caja = CalcularCaja();
                this.venta = new Venta(cliente, empleado);

                if (venta != null)
                {
                    MessageBox.Show("Venta realizada con exito");
                    this.Venta = venta;
                    this.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Verifique la informacion de los campos");
            }
        }

        //AGREGA LOS PRODUCTOS A LA LISTA DEL CLIENTE
        private void btnAgregarProductoAListaCliente_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)lstProductosEnStock.SelectedItem;

            if (producto != null )
            {
                if(producto.Cantidad > 0)
                {
                    float importe = 0;

                    foreach (Producto aux in lstListaProductosCliente.Items)
                    {
                        importe += aux.Precio;

                        this.lblTotalAPagar.Text = "$ " + importe.ToString();
                    }
                    producto.Cantidad--;
                    
                    lstListaProductosCliente.Items.Add(producto);
                }
                else
                {
                    MessageBox.Show("Producto sin stock");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        // QUITA PRODUCTOS DE LA LISTA DEL CLIENTE QUE SE ARREPINTIO DE ESCOGER O POR ERROR
        private void btnQuitarProductoAListaCliente_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)lstListaProductosCliente.SelectedItem;

            if (producto != null)
            {

                lstProductosEnStock.Items.Add(producto);
                lstListaProductosCliente.Items.Remove(producto);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

        }

        // VALIDA QUE LOS CAMPOS AL GENERAR LA VENTA SEAN LOS CORRECTOS
        private bool ValidarCampos()
        {
            bool retorno = false;
            string nombre = this.txtNobreCliente.Text;
            string apellido = this.txtApellidoCliente.Text;
            string direccion = this.txtDireccionCliente.Text;
            int nroTelefono = Validaciones.ValidarNroDeTelfono(this.txtNroDeTelefonoCliente.Text);
            List<Producto> lista = new List<Producto>();
            Empleado empleado = (Empleado)cmbEmpleadoACargo.SelectedItem;


            foreach (Producto aux in this.lstListaProductosCliente.Items)
            {
                lista.Add(aux);
            }

            if(nombre != String.Empty && apellido!=String.Empty && direccion != String.Empty && nroTelefono !=0 && lista.Count>0 && empleado != null)
            {
                retorno = true;
            }

            return retorno;
        }
       
        // CALCULA EL MONTO DE PRECIO DE LA LISTA DE PRODUCTOS DEL CLIENTE
        private float CalcularCaja()
        {
            float cont = 0;

            foreach (Producto producto in this.lstListaProductosCliente.Items)
            {
                cont += producto.Precio;
            }

            return cont;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Propiedades

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

        //private void ActualizarStock(Producto producto)
        //{
        //    if(this.lstProductosEnStock.Items.Contains(producto))
        //    {
        //        Producto aux = (Producto)this.lstProductosEnStock.SelectedItem;
        //        int cantidad;

        //        cantidad = aux.Cantidad -= producto.Cantidad;

        //        if(cantidad <= 0)
        //        {
        //            aux.Cantidad = 0;
        //        }
        //        else
        //        {
        //            aux.Cantidad = cantidad;
        //        }
        //        this.lstProductosEnStock.Items.Remove(producto);
        //        this.lstProductosEnStock.Items.Add(aux);
        //    }
        //}

        #endregion
    }
}
