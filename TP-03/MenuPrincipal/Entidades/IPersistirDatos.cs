using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal interface IPersistirDatos<T>
        where T : class
    {

        void Guardar(string path, string nombreArchivo, T contenido);


        T Leer(string path, string nombreArchivo);
    }
}
