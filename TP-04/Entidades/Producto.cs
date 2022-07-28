using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //ENCAPSULAMIENTO
    public sealed class Producto
    {
        private int id;
        private string nombre;
        private float precio;
        private DateTime fechaDeElaboracion;
        private DateTime fechaVencimiento;
        private int cantidad;

        #region constructores
        public Producto()
        {
        }

        public Producto(string nombre, float precio, DateTime fechaElaboracion, DateTime fechaVencimiento, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.fechaDeElaboracion = fechaElaboracion;
            this.fechaVencimiento = fechaVencimiento;
            this.cantidad = cantidad;
        }

        public Producto(string nombre, float precio, DateTime fechaElaboracion, DateTime fechaVencimiento, int cantidad, int id)
            :this(nombre, precio, fechaElaboracion, fechaVencimiento, cantidad)
        {
            this.id = id;
        }
        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public DateTime FechaDeElaboracion
        {
            get { return this.fechaDeElaboracion; }
            set { this.fechaDeElaboracion = value; }
        }

        public DateTime FechaDeVencimiento
        {
            get { return this.fechaVencimiento; }
            set { this.fechaVencimiento = value; }
        }

        public int Cantidad
        {
            get { return this.cantidad;}
            set { this.cantidad = value; }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.Nombre);
            retorno.AppendLine(" $: " + this.Precio.ToString());
            retorno.AppendLine(" Venc: " + this.fechaVencimiento.ToString("M"));

            return retorno.ToString();
        }

        //public static bool operator ==(Producto producto , Producto producto1)
        //{
        //    bool retorno = false;   

        //    if (producto.Nombre == producto1.Nombre && producto.Precio == producto1.Precio)
        //    {
        //        retorno = true; 
        //    }
        //    return retorno;
        //}

        //public static bool operator !=(Producto producto, Producto producto1)
        //{
        //    return !(producto == producto1);
        //}

        //public static Producto operator +(Producto producto, Producto producto1)
        //{
        //    if(producto == producto1)
        //    {
        //        producto1.Cantidad += producto.Cantidad;
        //    }
        //    return producto1;
        //}
        #endregion 
    }
}
