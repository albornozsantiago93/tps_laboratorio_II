using System;
using System.Text;

namespace Entidades
{
    // ABSTRACCION
    public abstract class Persona
    {
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected string nroTelefono;
        protected string direccion;

        #region Constructores
        public Persona()
        {

        }
        

        public Persona(string nombre, string apellido, int dni, string nroTelefono, string direccion)
            :this()
        {
            this.nombre = nombre;  
            this.apellido = apellido;
            this.dni = dni;
            this.nroTelefono = nroTelefono;
            this.direccion = direccion; 
        }

        #endregion

        #region Sobrecarga

        //public static bool operator ==(Persona p1 , Persona p2)
        //{
        //    bool retorno = false;

        //    if(p1.Nombre == p2.Nombre && p1.Dni== p2.Dni)
        //    {
        //        retorno = true;
        //    }
        //    return retorno;
        //}

        //public static bool operator != (Persona p1, Persona p2)
        //{ 
        //    return !(p1 == p2);
        //}

        #endregion

        #region Metodos
        public virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.Nombre + " " +  this.Apellido);
            retorno.AppendLine(", Dni: " + this.Dni.ToString());
            retorno.AppendLine(", Direccion: " + this.Direccion);
            retorno.AppendLine(", Numero de Telefono: " + this.NroTelefono);

            return retorno.ToString();
        }

        public abstract float CalcularCaja();

        #endregion

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        /// <summary>
        /// lee y setea nombre de persona
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// lee y setea dni de persona
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string NroTelefono
        {
            get { return this.nroTelefono; }
            set { this.nroTelefono = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        #endregion


    }
}
