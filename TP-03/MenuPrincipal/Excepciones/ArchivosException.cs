using System;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        private string mensaje;

        public ArchivosException()
            : base()
        {

        }

        public ArchivosException(Exception e)
            : this()
        {
            this.mensaje = e.Message;
        }

    }
}