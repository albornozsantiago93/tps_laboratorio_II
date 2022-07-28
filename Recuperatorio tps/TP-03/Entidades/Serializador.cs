using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    // SE IMPLEMTAN LAS UNIDADES 12 Y 14
    // TIPOS GENERICOS
    // ARCHIVOS Y SERIALIZACION
    public class Serializador<T>
        where T : class, new()
    {
        /// <summary>
        /// Serializador en formato JSON
        /// </summary>
        public bool JsonSerializerSave(string filePath, T objetoASerializar)
        {
            //bool retorno = false;

            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            string serialazer = JsonSerializer.Serialize(objetoASerializar, typeof(T), opciones);
            Archivos.Guardar(filePath, serialazer);

            return true;
            //retorno = true;
        }

        /// <summary>
        /// Desserializa un objeto que se encuentra en formato JSON en un archivo
        /// </summary>
        public T LeerJson(string filePath)
        {
            string file = Archivos.Leer(filePath);
            return JsonSerializer.Deserialize<T>(file);
        }
    }
}
