using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializador<T>
        where T : class, new()
    {
        /// <summary>
        /// Serializa en formato JSON un objeto y lo guarda en un archivo
        /// </summary>
        /// <param name="filePath">Ruta del directorio donde se encuentra el archivo</param>
        /// <param name="objetoASerializar">Objeto a serializar en formato JSON</param>
        public void SerializarJsonYGuardar(string filePath, T objetoASerializar)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            string serialazer = JsonSerializer.Serialize(objetoASerializar, typeof(T), opciones);
            Archivos.Guardar(filePath, serialazer);
        }

        /// <summary>
        /// Des-serializa un objeto que se encuentra en formato JSON en un archivo
        /// </summary>
        /// <param name="filePath">Ruta del directorio donde se encuentra el archivo</param>
        /// <returns>Instancia del objeto des-serializado</returns>
        public T LeerJson(string filePath)
        {
            string file = Archivos.Leer(filePath);
            return JsonSerializer.Deserialize<T>(file);
        }
    }
}
