using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivos
    {
        /// <summary>
        /// LEE EL CONTENIDO DEL FILEPATH
        /// </summary>
        public static string Leer(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    return sr.ReadToEnd();
                }
            }
            catch
            {
                throw new ErrorEnArchivosException("No se ha podido Leer archivo");
            }
        }

        /// <summary>
        /// GUARDA UN CONTENIDO STRING EN UN ARCHIVO
        /// </summary>
        public static void Guardar(string filePath, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(contenido);
                }
            }
            catch
            {
                throw new ErrorEnArchivosException("No se ha podido Escribir archivo");
            }
        }
    }
}
