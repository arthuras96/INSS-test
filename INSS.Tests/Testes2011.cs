using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace INSS.Tests
{
    [TestClass]
    public class Testes2011
    {
        DateTime date2011 = Convert.ToDateTime("2011-01-01 00:00:00");
        [TestMethod]
        public void ANO2011MARGEM1()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2011 = CalculadorInss.CalcularDesconto(date2011, 1106.9m);
            Assert.AreEqual(88.55m, valorDesconto2011);
        }
        [TestMethod]
        public void ANO2011MARGEM2()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2011 = CalculadorInss.CalcularDesconto(date2011, 1106.91m);
            Assert.AreEqual(99.62m, valorDesconto2011);
        }
        [TestMethod]
        public void ANO2011MARGEM3()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2011 = CalculadorInss.CalcularDesconto(date2011, 1844.83m);
            Assert.AreEqual(166.03m, valorDesconto2011);
        }
        [TestMethod]
        public void ANO2011MARGEM4()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2011 = CalculadorInss.CalcularDesconto(date2011, 1844.84m);
            Assert.AreEqual(202.93m, valorDesconto2011);
        }
        [TestMethod]
        public void ANO2011MARGEM5()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2011 = CalculadorInss.CalcularDesconto(date2011, 3689.66m);
            Assert.AreEqual(405.86m, valorDesconto2011);
        }
        [TestMethod]
        public void ANO2011MARGEM6()
        {
            var CalculadorInss = new CalculadorInss();
            var valorDesconto2011 = CalculadorInss.CalcularDesconto(date2011, 10000);
            Assert.AreEqual(405.86m, valorDesconto2011);
        }
    }
}
