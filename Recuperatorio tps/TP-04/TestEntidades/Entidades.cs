using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestEntidades
{
    internal class Entidades
    {
        public void Test_OperatorPersona()
        {
            Empleado persona1 = new Empleado("Jose","Lopez",37358111,"1551352314","Alfred 245",DateTime.UtcNow, DateTime.UtcNow);
            Empleado persona2 = new Empleado("Jose", "Lopez", 37358111, "1551352314", "Alfred 245", DateTime.UtcNow, DateTime.UtcNow);
            
            Action.Equals(persona1, persona2);
        }
    }
}
