using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace INSS.Tests
{
    [TestClass]
    public class Testes2012
    {
        DateTime date2012 = Convert.ToDateTime("2012-01-01 00:00:00");
        [TestMethod]
        public void ANO2012MARGEM1()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 1000);
            Assert.AreEqual(70, valorDesconto2012);
        }
        [TestMethod]
        public void ANO2012MARGEM2()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 1000.01m);
            Assert.AreEqual(80, valorDesconto2012);
        }
        [TestMethod]
        public void ANO2012MARGEM3()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 1500);
            Assert.AreEqual(120, valorDesconto2012);
        }
        [TestMethod]
        public void ANO2012MARGEM4()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 1500.01m);
            Assert.AreEqual(135, valorDesconto2012);
        }
        [TestMethod]
        public void ANO2012MARGEM5()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 3000);
            Assert.AreEqual(270, valorDesconto2012);
        }
        [TestMethod]
        public void ANO2012MARGEM6()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 3000.01m);
            Assert.AreEqual(330, valorDesconto2012);
        }
        [TestMethod]
        public void ANO2012MARGEM7()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 4000);
            Assert.AreEqual(440, valorDesconto2012);
        }
        [TestMethod]
        public void ANO2012MARGEM8()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 4000.01m);
            Assert.AreEqual(500, valorDesconto2012);
        }
        [TestMethod]
        public void ANO2012MARGEM9()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2012 = CalculadorInss.CalcularDesconto(date2012, 10000);
            Assert.AreEqual(500, valorDesconto2012);
        }
    }
}
