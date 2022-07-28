using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEntidades
{
    [TestClass]
    public class VentaTest
    {
        [TestMethod]
        public void ValidarVenta()
        {
            Cliente cliente = new Cliente();
            Empleado clienteEmpleado = new Empleado();
            Venta venta = new Venta(cliente, clienteEmpleado);
            Cliente cliente1 = new Cliente();            
            Venta venta1 = new Venta(cliente1, clienteEmpleado);
            Assert.AreNotEqual(venta1, venta);      
        }

    }
}