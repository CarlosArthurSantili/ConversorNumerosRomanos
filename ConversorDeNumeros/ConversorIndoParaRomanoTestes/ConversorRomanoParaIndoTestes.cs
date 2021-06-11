using ConversorDeNumeros;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorIndoParaRomanoTestes
{
    [TestClass]
    public class ConversorRomanoParaIndoTestes
    {
        [TestMethod]
        public void ConversorNumeroRomanoParaIndoI()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("I");

            Assert.AreEqual(1, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoXI()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("XI");

            Assert.AreEqual(11, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoXIV()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("XIV");

            Assert.AreEqual(14, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoMIX()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("MIX");

            Assert.AreEqual(1009, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoĪV̄()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("ĪV̄");

            Assert.AreEqual(4000, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoĪV̄ĪV̄()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("ĪV̄ĪV̄");

            Assert.AreEqual(-1, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoCL()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("CL");

            Assert.AreEqual(150, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoĪV̄CML()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("ĪV̄CML");

            Assert.AreEqual(4950, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoĪV̄X()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("ĪV̄X");

            Assert.AreEqual(4010, teste.Conversor());
        }

        [TestMethod]
        public void ConversorNumeroRomanoParaIndoX̄X̄X̄()
        {
            ConversorRomanoParaIndo teste = new ConversorRomanoParaIndo("X̄X̄X̄");

            Assert.AreEqual(30000, teste.Conversor());
        }
    }
}
