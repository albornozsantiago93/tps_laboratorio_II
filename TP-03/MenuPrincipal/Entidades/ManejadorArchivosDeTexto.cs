using System;
using System.IO;

namespace Entidades
{
    public class ManejadorArchivosDeTexto : IPersistirDatos<string>
    {

        /// <summary>
        /// Guarda el string que recibe como parametro en la ruta especificada
        public void Guardar(string path, string nombreArchivo, string contenido)
        {
            try
            {
                //Pat.Combine combina dos string en una ruta
                string rutaCompleta = Path.Combine(path, nombreArchivo);

                using (StreamWriter streamWriter = new StreamWriter(rutaCompleta))
                {
                    streamWriter.WriteLine(contenido);
                }
            }
            catch (DirectoryNotFoundException ex)
            {

                throw new ArchivoException("El directorio no existe", ex);
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Lee el archivo en la ruta especificada
        public string Leer(string path, string nombreArchivo)
        {
            try
            {
                //Pat.Combine combina dos string en una ruta
                string rutaCompleta = Path.Combine(path, nombreArchivo);
                using (StreamReader streamReader = new StreamReader(rutaCompleta))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new ArchivoException("El directorio no existe", ex);
            }
            catch (FileNotFoundException ex)
            {
                throw new ArchivoException("El archivo no existe", ex);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}