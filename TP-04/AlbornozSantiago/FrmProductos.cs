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
    public partial class FrmProductos : Form
    {
        public List<Producto> productos;
        public Producto producto;


        public FrmProductos()
        {
            InitializeComponent();
            this.productos = new List<Producto>();  
        }
        public FrmProductos(List<Producto> productos)
            :this()
        {
            this.productos = productos;
        }

        // AGREGA UN PRODUCTO A LA LISTA DE PRODUCTOS EN STOCK
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            float precio = Validaciones.ValidarPrecio(txtPrecioProducto.Text);
            DateTime fechaElaboracion = dtTimeElaboracion.MinDate;
            DateTime fechaVencimiento = dtTimeVencimiento.MinDate;


            if (int.Parse(numCantidad.Value.ToString()) == 0)
            {
                MessageBox.Show("Debe insertar una cantidad valida");
            }
            else if(precio == 0)
            {
                MessageBox.Show("Debe insertar un precio valido");
            }
            else if (txtNombreProducto.Text != string.Empty)
            {
                Producto producto = new Producto(txtNombreProducto.Text, precio, fechaElaboracion, fechaVencimiento, int.Parse(numCantidad.Value.ToString()));

                this.producto = producto;

                productos.Add(producto);
                MessageBox.Show(txtNombreProducto.Text.ToUpper() + "\nAGREGADO A LA LISTA");
                lstProductos.Items.Add(producto);
            }
            else
            {
                MessageBox.Show("Ingrese toda la informacion necesaria");
            }       
        }

        #region Propiedades
        public List<Producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }

        public Producto Producto
        {
            get { return this.producto; }
            set { this.producto = value; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            foreach(Producto producto in productos)
            {

                this.lstProductos.Items.Add(producto);
            }
        }
        #endregion
    }
}
