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
    public partial class FrmMenuPrincipal : Form
    {
        public List<Empleado> empleados;
        public List<Producto> productos;
        public List<Venta> ventas;


        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.productos = new List<Producto>();
            this.empleados = new List<Empleado>();
            this.ventas = new List<Venta>();
        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            FrmGenerarPedido frmPedido = new FrmGenerarPedido();
            frmPedido.productos = this.productos;
            frmPedido.empleados = this.empleados;

            frmPedido.ShowDialog();

            if (frmPedido.Venta != null)
            {
                this.ventas.Add(frmPedido.Venta);
                this.productos = frmPedido.productos;
            }            
        }

        private void btnAgregarNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();

            frmEmpleado.ShowDialog(); 
            this.empleados.Add(frmEmpleado.Empleado);
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            FrmInforme frmInforme = new FrmInforme();
            frmInforme.Ventas = this.ventas;

            frmInforme.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.productos = this.productos;
            frmProductos.ShowDialog();
            productos = frmProductos.Productos;


        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.empleados.Add(new Empleado("Santiago", "Albornoz", 39525111, "1122552211", "Calle falsa 123", DateTime.UtcNow, DateTime.UtcNow));
            this.empleados.Add(new Empleado("Josele", "Robert", 39544111, "1122551111", "Calle falsa 123", DateTime.UtcNow, DateTime.UtcNow));

            this.productos.Add(new Producto("Lemon pie", 440, DateTime.UtcNow, DateTime.UtcNow, 3));
            this.productos.Add(new Producto("Pepas", 300, DateTime.UtcNow, DateTime.UtcNow, 5));
            this.productos.Add(new Producto("Rosca", 350, DateTime.UtcNow, DateTime.UtcNow, 13));
            this.productos.Add(new Producto("Pan de campo", 200, DateTime.UtcNow, DateTime.UtcNow, 9));
            this.productos.Add(new Producto("Docena de medialunas", 550, DateTime.UtcNow, DateTime.UtcNow, 4));
        }
    }
}
