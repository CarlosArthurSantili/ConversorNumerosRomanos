using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConversorDeNumeros
{
    public class ConversorRomanoParaIndo
    {
        public string numeroRomano;

        public ConversorRomanoParaIndo(string numeroRomano)
        {
            this.numeroRomano = numeroRomano;
        }

        public int Conversor()
        {
            int resultado = 0;
            string numeroRomanoNormalizado = NormalizarNumeroRomano();
            if (ValidaNumeroRomano())
            {                    
                foreach (var letra in numeroRomanoNormalizado)
                {
                    resultado += ConverterLetraParaNumero(letra);
                }
                //Casos de Subtração
                if (numeroRomano.Contains("IV") || numeroRomano.Contains("IX"))
                    resultado -= 2;
                
                if (numeroRomano.Contains("XL") || numeroRomano.Contains("XC"))
                    resultado -= 20;

                if (numeroRomano.Contains("CD") || numeroRomano.Contains("CM"))
                    resultado -= 200;

                if (numeroRomano.Contains("iv") || numeroRomano.Contains("ix"))
                    resultado -= 2000;

                return resultado;
            }
            else
                return -1;
        }

        private bool ValidaNumeroRomano()
        {
            if (ValidaNumeroRomanoLetrasLocalIncorreto() && ValidaNumeroRomanoQuantidadeLetras())
                return true;
            else
                return false;
        }
        
        private bool ValidaNumeroRomanoLetrasLocalIncorreto() 
        {
            if (numeroRomano.Length > 1)
            {
                if ((numeroRomano.Contains("IL"))||(numeroRomano.Contains("IC")) || (numeroRomano.Contains("ID")) || (numeroRomano.Contains("IM")))
                {
                    return false;
                }

                if ((numeroRomano.Contains("XD")) || (numeroRomano.Contains("XM")))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidaNumeroRomanoQuantidadeLetras()
        {
            if (numeroRomano.Length > 1)
            {
                if (Regex.Matches(numeroRomano, "i").Count > 3)
                {
                    return false;
                }

                if (Regex.Matches(numeroRomano, "v").Count > 1)
                {
                    return false;
                }

                if (Regex.Matches(numeroRomano, "x").Count > 3)
                {
                    return false;
                }
            }
            return true;
        }

        private int ConverterLetraParaNumero(char letra)
        {
            switch (letra)
            {
                case 'x':
                    {
                        return 10000;
                    }
                case 'v':
                    {
                        return 5000;
                    }
                case 'i':
                    {
                        return 1000;
                    }
                case 'M':
                    {
                        return 1000;
                    }

                case 'D':
                    {
                        return 500;
                    }

                case 'C':
                    {
                        return 100;
                    }

                case 'L':
                    {
                        return 50;
                    }

                case 'X':
                    {
                        return 10;
                    }

                case 'V':
                    {
                        return 5;
                    }

                case 'I':
                    {
                        return 1;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        private string NormalizarNumeroRomano() 
        {
            numeroRomano = numeroRomano.ToUpper();
            numeroRomano = numeroRomano.Replace("Ī", "i");
            numeroRomano = numeroRomano.Replace("V̄", "v");
            numeroRomano = numeroRomano.Replace("X̄", "x");

            return numeroRomano;
        }
    }
}
