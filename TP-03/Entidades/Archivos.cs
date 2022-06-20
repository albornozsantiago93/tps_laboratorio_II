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
        /// Lee contenido del archivo 
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
        /// Guarda un contenido (string) en un archivo
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
