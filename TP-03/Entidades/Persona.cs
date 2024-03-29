﻿using System;
using System.Text;
using System.Text.Json.Serialization;

namespace Entidades
{
    public abstract class Persona
    {
        protected int dni;
        protected string nombre;
        protected string apellido;
        protected string nroTelefono;
        protected string direccion;


        public Persona()
        {

        }


        public Persona(string nombre, string apellido, int dni, string nroTelefono, string direccion)
            : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nroTelefono = nroTelefono;
            this.direccion = direccion;
        }

        #region propiedades

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
        [JsonIgnore]
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

        [JsonIgnore]
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


    }
}
