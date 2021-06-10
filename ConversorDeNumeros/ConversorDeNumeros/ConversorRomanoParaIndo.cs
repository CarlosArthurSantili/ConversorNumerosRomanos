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

        public ConversorRomanoParaIndo(string valorRomano)
        {
            this.numeroRomano = valorRomano;
        }

        public int Conversor()
        {
            numeroRomano = numeroRomano.ToUpper();
            var resultado = 0;

            if (ValidaNumeroRomano())
            {
                if (numeroRomano.Contains("ĪV̄"))
                {
                    numeroRomano = numeroRomano.Substring(3);
                    resultado += 4000;
                }
                else if (numeroRomano.Contains("V̄"))
                {
                    numeroRomano = numeroRomano.Substring(1);
                    resultado += 5000;
                }
                else if (numeroRomano.Contains("V̄Ī"))
                {
                    numeroRomano = numeroRomano.Substring(3);
                    resultado += 6000;
                }
                else if (numeroRomano.Contains("V̄ĪĪ"))
                {
                    numeroRomano = numeroRomano.Substring(5);
                    resultado += 7000;
                }
                else if (numeroRomano.Contains("V̄ĪĪĪ"))
                {
                    numeroRomano = numeroRomano.Substring(7);
                    resultado += 8000;
                }
                else if (numeroRomano.Contains("ĪX̄")) 
                {
                    numeroRomano = numeroRomano.Substring(3);
                    resultado += 9000;
                }
                else if (numeroRomano.Contains("X̄"))
                {
                    numeroRomano = numeroRomano.Substring(1);
                    resultado += 10000;
                }
                    
                foreach (var letra in numeroRomano)
                {
                    resultado += ConverterLetraParaNumero(letra);
                }

                if (numeroRomano.Contains("IV") || numeroRomano.Contains("IX"))
                    resultado -= 2;

                if (numeroRomano.Contains("XL") || numeroRomano.Contains("XC"))
                    resultado -= 20;

                if (numeroRomano.Contains("CD") || numeroRomano.Contains("CM"))
                    resultado -= 200;
                
                return resultado;
            }
            else
                return -1;
        }

        private bool ValidaNumeroRomano() 
        {
            if (Regex.Matches(numeroRomano, "ĪV̄").Count > 1)
            {
                return false;
            }

            if (Regex.Matches(numeroRomano, "V̄").Count > 1)
            {
                return false;
            }

            if (Regex.Matches(numeroRomano, "V̄Ī").Count > 1)
            {
                return false;
            }

            if (Regex.Matches(numeroRomano, "V̄ĪĪ").Count > 1)
            {
                return false;
            }

            if (Regex.Matches(numeroRomano, "V̄ĪĪĪ").Count > 1)
            {
                return false;
            }

            if (Regex.Matches(numeroRomano, "ĪX̄").Count > 1)
            {
                return false;
            }

            if (Regex.Matches(numeroRomano, "X̄").Count > 1)
            {
                return false;
            }

            return true;
        }

        private int ConverterLetraParaNumero(char letter)
        {
            switch (letter)
            {
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
    }
}
