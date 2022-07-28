using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEntidades
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorEnArchivosException))]
        public void SerializarJson()
        {
            Serializador<Empleado> serializador = new Serializador<Empleado>();
            Empleado empleado = new Empleado();

            serializador.JsonSerializerSave("/zzzzzzz/", empleado);
        }

        


    }
}