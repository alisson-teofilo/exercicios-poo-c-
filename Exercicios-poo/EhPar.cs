using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_poo
{
    internal class EhPar
    {
        public string IdentificarNumero(int numero)
        {
            if (numero % 2 == 0)
            {
              return "É PAR";
            }
            else
            {
               return "É IMPAR";
            }
        }
    }
}
