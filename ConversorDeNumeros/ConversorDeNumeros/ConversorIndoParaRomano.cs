using ConversorDeNumeros.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeNumeros
{
    public class ConversorIndoParaRomano
    {
        public int valorIndo;

        public ConversorIndoParaRomano(int valorIndo) 
        {
            this.valorIndo = valorIndo;
        }

        public string Conversor()
        {
            string numeroRomano = "";
            numeroRomano = numerosRomanosDezenaMilhar() + numerosRomanosMilhar() + numerosRomanosCentena() + numerosRomanosDezena() + numerosRomanosUnidade();
            
            return numeroRomano;
        }

        public string numerosRomanosUnidade()
        {
            switch (valorIndo.ObterUnidade())
            {
                default: return "";
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
            }
        }

        public string numerosRomanosDezena()
        {
            switch(valorIndo.ObterDezena())
            {
                default: return "";
                case 1: return "X";
                case 2: return "XX";
                case 3: return "XXX";
                case 4: return "XL";
                case 5: return "L";
                case 6: return "LX";
                case 7: return "LXX";
                case 8: return "LXXX";
                case 9: return "XC";
            }
        }

        public string numerosRomanosCentena()
        {
            switch (valorIndo.ObterCentena())
            {
                default: return "";
                case 1: return "C";
                case 2: return "CC";
                case 3: return "CCC";
                case 4: return "CD";
                case 5: return "D";
                case 6: return "DC";
                case 7: return "DCC";
                case 8: return "DCCC";
                case 9: return "CM";
            }
        }

        public string numerosRomanosMilhar()
        {
            switch (valorIndo.ObterMilhar())
            {
                default: return "";
                case 1: return "M";
                case 2: return "MM";
                case 3: return "MMM";
                case 4: return "ĪV̄";
                case 5: return "V̄";
                case 6: return "V̄Ī";
                case 7: return "V̄ĪĪ";
                case 8: return "V̄ĪĪĪ";
                case 9: return "ĪX̄";
            }
        }

        public string numerosRomanosDezenaMilhar()
        {
            switch (valorIndo.ObterDezenaMilhar())
            {
                default: return "";
                case 1: return "X̄";
            }
        }
    }
}
