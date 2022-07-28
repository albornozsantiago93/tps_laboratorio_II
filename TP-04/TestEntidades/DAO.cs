using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace TestEntidades
{
    internal class DAO
    {
        /// <summary>
        /// Testea el metodo Guardar de la clase PersonaDAO
        /// </summary>
        [TestMethod]
        public void Test_GuardarProducto()
        {
            ProductoDAO sql = new ProductoDAO();
            Producto producto = new Producto("Panchitas", 50, DateTime.Now, DateTime.UtcNow, 2);

            Assert.IsTrue(sql.Guardar(producto));
        }
    }
}
