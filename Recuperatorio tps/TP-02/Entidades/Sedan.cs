﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base( marca, chasis, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : this(marca,chasis,color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"{base.Mostrar()}");          
            retorno.AppendLine(" TIPO : " + this.tipo);
            retorno.AppendLine("");
            retorno.AppendLine("---------------------");

            return retorno.ToString();
        }
    }
}
