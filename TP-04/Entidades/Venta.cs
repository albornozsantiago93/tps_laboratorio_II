using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public Guid id;
        public DateTime fecha;
        public Cliente cliente;
        public Empleado empleado;

        public Venta()
        {

        }

        public Venta(Cliente cliente, Empleado empleado)
        {
            this.id = Guid.NewGuid();
            this.cliente = cliente;
            this.empleado = empleado;
            this.fecha = DateTime.UtcNow;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.empleado.Nombre + " " + this.empleado.Apellido);
            retorno.AppendLine("Caja: $" + this.empleado.Caja.ToString());
            retorno.AppendLine("Cantidad productos vendidos: " + this.cliente.Productos.Count);
            retorno.AppendLine("Fecha " + this.fecha);

            return retorno.ToString();
        }

        #region Propiedades

        public Guid Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        public Empleado Empleado
        {
            get { return this.empleado; }
            set { this.empleado = value; }
        }
        #endregion

    }
}
