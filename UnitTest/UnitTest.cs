using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using exz02;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual(Convert.ToString(class1.MassaGruza(5,4,6,2)), Convert.ToString(240));
        }
    }
}
