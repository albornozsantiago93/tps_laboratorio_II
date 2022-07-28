using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private float precio;
        private DateTime fechaDeElaboracion;
        private DateTime fechaVencimiento;
        private int cantidad;

        public Producto(string nombre, float precio, DateTime fechaElaboracion, DateTime fechaVencimiento, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.fechaDeElaboracion = fechaElaboracion;
            this.fechaVencimiento = fechaVencimiento;
            this.cantidad = cantidad;
        }

        #region propiedades

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

        [JsonIgnore]
        public int Cantidad
        {
            get { return this.cantidad;}
            set { this.cantidad = value; }
        }
        #endregion

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.Nombre);
            retorno.AppendLine(" $: " + this.Precio.ToString());
            retorno.AppendLine(" Venc: " + this.fechaVencimiento.ToString("M"));

            return retorno.ToString();
        }

    }
}
