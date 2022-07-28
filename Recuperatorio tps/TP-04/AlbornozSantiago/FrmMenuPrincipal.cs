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
    // DELEGATE
    // EVENTS

    public partial class FrmMenuPrincipal : Form
    {
        public List<Empleado> empleados;
        public List<Producto> productos;
        public List<Venta> ventas;



        public ProductoDAO productoDAO;
        public delegate void DAOHandler();
        public event DAOHandler OnSql;

        //SE INICIALIZAN LAS LISTAS Y AGREGA LA CARGA DE PRODUCTOS AL HANDLER
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.productos = new List<Producto>();
            this.empleados = new List<Empleado>();            
            this.ventas = new List<Venta>();
            this.productoDAO = new ProductoDAO();

            OnSql += CargarProductos;
        }

        // INICIALIZA Y MANENEJA EL FORMULARIO PARA GENERAR UN PEDIDO Y LUEGO ES ACUALIZA LA LISTA DE PRODUCTOS EN LA BASE DE DATOS
        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            FrmGenerarPedido frmPedido = new FrmGenerarPedido(this.productos, this.empleados);

            frmPedido.ShowDialog();

            if (frmPedido.Venta != null)
            {
                this.ventas.Add(frmPedido.Venta);
                this.productos = frmPedido.productos;

                foreach (Producto producto in frmPedido.ProductosDelCliente)
                {
                    if (producto != null)
                    {
                        if (this.productoDAO.Guardar(producto))
                        {
                            //MessageBox.Show("Guardado con exito");
                        }
                    }
                }
            }            
        }

        // INICIALIZA Y MANEJA EL FORMULARIO PARA AGREGAR UN NUEVO EMPLEADO A LA PANADERIA
        private void btnAgregarNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();

            frmEmpleado.ShowDialog(); 
            this.empleados.Add(frmEmpleado.Empleado);
        }

        // INICIALIZA Y MANEJA EL FORMULARIO PARA GENERAR UN INFORME DE LAS VENTAS
        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            FrmInforme frmInforme = new FrmInforme();
            frmInforme.Ventas = this.ventas;

            frmInforme.ShowDialog();
        }

        // INICIALIZA Y MANEJA EL FORMULARIO PARA EL MANEJO DE STOCK DE PRODUCTOS
        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(this.productos);
            frmProductos.ShowDialog();
            productos = frmProductos.Productos;

            if(frmProductos.Producto != null)
            {
                if(this.productoDAO.Guardar(frmProductos.Producto))
                {
                    MessageBox.Show("Guardado con exito");
                }
            }
        }

        // CARGA EL FORUMLARIO PRINCIPAL
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.empleados.Add(new Empleado("Santiago", "Albornoz", 39525111, "1122552211", "Calle falsa 123", DateTime.UtcNow, DateTime.UtcNow));
            this.empleados.Add(new Empleado("Rogelio", "Roberto", 39544111, "1122551111", "Calle falsa 123", DateTime.UtcNow, DateTime.UtcNow));

            this.CargarProductos();
        }

        // LANZA LA TEREA PARA CARGAR PRODUCOTS EN LA BASE DE DATOS
        private void CargarProductos()
        {
            Task.Run(() =>
            {
                this.productos = this.productoDAO.Leer();
            });
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
