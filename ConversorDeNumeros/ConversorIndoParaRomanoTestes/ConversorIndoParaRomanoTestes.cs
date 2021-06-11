using ConversorDeNumeros;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConversorIndoParaRomanoTestes
{
    [TestClass]
    public class ConversorIndoParaRomanoTestes
    {
        [TestMethod]
        public void NumeroRomanoUnidade1()
        {
            ConversorIndoParaRomano teste = new ConversorIndoParaRomano(1);

            Assert.AreEqual("I", teste.numerosRomanosUnidade());
        }

        [TestMethod]
        public void NumeroRomanoDezena10()
        {
            ConversorIndoParaRomano teste = new ConversorIndoParaRomano(10);

            Assert.AreEqual("X", teste.numerosRomanosDezena());
        }

        [TestMethod]
        public void NumeroRomanoCentena100()
        {
            ConversorIndoParaRomano teste = new ConversorIndoParaRomano(100);

            Assert.AreEqual("C", teste.numerosRomanosCentena());
        }

        [TestMethod]
        public void NumeroRomanoMilhar1000()
        {
            ConversorIndoParaRomano teste = new ConversorIndoParaRomano(1000);

            Assert.AreEqual("M", teste.numerosRomanosMilhar());
        }

        [TestMethod]
        public void NumeroRomanoDezenaMilhar10000()
        {
            ConversorIndoParaRomano teste = new ConversorIndoParaRomano(10000);

            Assert.AreEqual("X̄", teste.numerosRomanosDezenaMilhar());
        }

        [TestMethod]
        public void ConversorIndoParaRomano11a15()
        {
            ConversorIndoParaRomano teste1 = new ConversorIndoParaRomano(11);
            ConversorIndoParaRomano teste2 = new ConversorIndoParaRomano(12);
            ConversorIndoParaRomano teste3 = new ConversorIndoParaRomano(13);
            ConversorIndoParaRomano teste4 = new ConversorIndoParaRomano(14);
            ConversorIndoParaRomano teste5 = new ConversorIndoParaRomano(15);
            Assert.AreEqual("XI", teste1.Conversor());
            Assert.AreEqual("XII", teste2.Conversor());
            Assert.AreEqual("XIII", teste3.Conversor());
            Assert.AreEqual("XIV", teste4.Conversor());
            Assert.AreEqual("XV", teste5.Conversor());
        }

        [TestMethod]
        public void ConversorIndoParaRomano16a20()
        {
            ConversorIndoParaRomano teste1 = new ConversorIndoParaRomano(16);
            ConversorIndoParaRomano teste2 = new ConversorIndoParaRomano(17);
            ConversorIndoParaRomano teste3 = new ConversorIndoParaRomano(18);
            ConversorIndoParaRomano teste4 = new ConversorIndoParaRomano(19);
            ConversorIndoParaRomano teste5 = new ConversorIndoParaRomano(20);
            Assert.AreEqual("XVI", teste1.Conversor());
            Assert.AreEqual("XVII", teste2.Conversor());
            Assert.AreEqual("XVIII", teste3.Conversor());
            Assert.AreEqual("XIX", teste4.Conversor());
            Assert.AreEqual("XX", teste5.Conversor());
        }

        [TestMethod]
        public void ConversorIndoParaRomano21a25()
        {
            ConversorIndoParaRomano teste1 = new ConversorIndoParaRomano(21);
            ConversorIndoParaRomano teste2 = new ConversorIndoParaRomano(22);
            ConversorIndoParaRomano teste3 = new ConversorIndoParaRomano(23);
            ConversorIndoParaRomano teste4 = new ConversorIndoParaRomano(24);
            ConversorIndoParaRomano teste5 = new ConversorIndoParaRomano(25);
            Assert.AreEqual("XXI", teste1.Conversor());
            Assert.AreEqual("XXII", teste2.Conversor());
            Assert.AreEqual("XXIII", teste3.Conversor());
            Assert.AreEqual("XXIV", teste4.Conversor());
            Assert.AreEqual("XXV", teste5.Conversor());
        }

        [TestMethod]
        public void ConversorIndoParaRomano26a30()
        {
            ConversorIndoParaRomano teste1 = new ConversorIndoParaRomano(26);
            ConversorIndoParaRomano teste2 = new ConversorIndoParaRomano(27);
            ConversorIndoParaRomano teste3 = new ConversorIndoParaRomano(28);
            ConversorIndoParaRomano teste4 = new ConversorIndoParaRomano(29);
            ConversorIndoParaRomano teste5 = new ConversorIndoParaRomano(30);
            Assert.AreEqual("XXVI", teste1.Conversor());
            Assert.AreEqual("XXVII", teste2.Conversor());
            Assert.AreEqual("XXVIII", teste3.Conversor());
            Assert.AreEqual("XXIX", teste4.Conversor());
            Assert.AreEqual("XXX", teste5.Conversor());
        }

        [TestMethod]
        public void ConversorIndoParaRomano56a60()
        {
            ConversorIndoParaRomano teste1 = new ConversorIndoParaRomano(56);
            ConversorIndoParaRomano teste2 = new ConversorIndoParaRomano(57);
            ConversorIndoParaRomano teste3 = new ConversorIndoParaRomano(58);
            ConversorIndoParaRomano teste4 = new ConversorIndoParaRomano(59);
            ConversorIndoParaRomano teste5 = new ConversorIndoParaRomano(60);
            Assert.AreEqual("LVI", teste1.Conversor());
            Assert.AreEqual("LVII", teste2.Conversor());
            Assert.AreEqual("LVIII", teste3.Conversor());
            Assert.AreEqual("LIX", teste4.Conversor());
            Assert.AreEqual("LX", teste5.Conversor());
        }

        [TestMethod]
        public void ConversorIndoParaRomano101a105()
        {
            ConversorIndoParaRomano teste1 = new ConversorIndoParaRomano(101);
            ConversorIndoParaRomano teste2 = new ConversorIndoParaRomano(102);
            ConversorIndoParaRomano teste3 = new ConversorIndoParaRomano(103);
            ConversorIndoParaRomano teste4 = new ConversorIndoParaRomano(104);
            ConversorIndoParaRomano teste5 = new ConversorIndoParaRomano(105);
            Assert.AreEqual("CI", teste1.Conversor());
            Assert.AreEqual("CII", teste2.Conversor());
            Assert.AreEqual("CIII", teste3.Conversor());
            Assert.AreEqual("CIV", teste4.Conversor());
            Assert.AreEqual("CV", teste5.Conversor());
        }

        [TestMethod]
        public void ConversorIndoParaRomano1001a1005()
        {
            ConversorIndoParaRomano teste1 = new ConversorIndoParaRomano(1001);
            ConversorIndoParaRomano teste2 = new ConversorIndoParaRomano(1002);
            ConversorIndoParaRomano teste3 = new ConversorIndoParaRomano(1003);
            ConversorIndoParaRomano teste4 = new ConversorIndoParaRomano(1004);
            ConversorIndoParaRomano teste5 = new ConversorIndoParaRomano(1005);

            Assert.AreEqual("MI", teste1.Conversor());
            Assert.AreEqual("MII", teste2.Conversor());
            Assert.AreEqual("MIII", teste3.Conversor());
            Assert.AreEqual("MIV", teste4.Conversor());
            Assert.AreEqual("MV", teste5.Conversor());
        }

        [TestMethod]
        public void ConversorIndoParaRomano10001a10005()
        {
            ConversorIndoParaRomano teste1 = new ConversorIndoParaRomano(10001);
            ConversorIndoParaRomano teste2 = new ConversorIndoParaRomano(10002);
            ConversorIndoParaRomano teste3 = new ConversorIndoParaRomano(10003);
            ConversorIndoParaRomano teste4 = new ConversorIndoParaRomano(10004);
            ConversorIndoParaRomano teste5 = new ConversorIndoParaRomano(10005);
             
            Assert.AreEqual("X̄I", teste1.Conversor());
            Assert.AreEqual("X̄II", teste2.Conversor());
            Assert.AreEqual("X̄III", teste3.Conversor());
            Assert.AreEqual("X̄IV", teste4.Conversor());
            Assert.AreEqual("X̄V", teste5.Conversor());
        }
    }
}
