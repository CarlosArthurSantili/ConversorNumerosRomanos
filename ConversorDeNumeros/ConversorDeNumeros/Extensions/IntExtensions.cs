using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeNumeros.Extensions
{
    public static class IntExtensions
    {
        public static int ObterUnidade(this int unidade)
        {
            return (unidade % 100) % 10;
        }

        public static int ObterDezena(this int dezena)
        {
            return (dezena % 100) / 10;
        }

        public static int ObterCentena(this int centena)
        {
            return (centena % 1000) / 100;
        }

        public static int ObterMilhar(this int milhar)
        {
            return (milhar % 10000) / 1000;
        }

        public static int ObterDezenaMilhar(this int dezenaMilhar)
        {
            return (dezenaMilhar % 100000) / 10000;
        }
    }
}
