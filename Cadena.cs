using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Beca
{
    public class Cadena
    {
        private string texto;
        public Cadena()
        {
        }

        public Cadena(string txt)
        {
            texto = txt;
        }

        public string getCadena()
        {
            return texto;
        }
        public void setCadena(string txt)
        {
            texto = txt;
        }

        public bool findIni(string cadena)
        {
            if (texto.IndexOf(cadena) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int findText(string cadena)
        {
            return texto.IndexOf(cadena);
            
        }

        public string sustituir(string original, string sustituta)
        {
            string aux = texto.Replace(original, sustituta);
            setCadena(aux);
            return aux;
        }

    }
}
