using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        protected float importe;
        protected List<Producto> productos;

        public Cliente()
            : base()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Cliente(string nombre, string apellido, string nroTelefono, string direccion, List<Producto>productos)
            :this()
        {
            this.direccion = direccion;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.productos = productos;
        }

        public override float CalcularCaja()
        {
            float retorno = 0;

            foreach(Producto aux in productos)
            {
                retorno += aux.Precio;
            }

            return retorno;
        }

        public List<Producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }

        public float  Importe
        {
            get { return this.importe; }
            set { this.importe = CalcularCaja(); }
        }
    }
}
