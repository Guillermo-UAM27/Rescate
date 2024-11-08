using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_pares_y_impares
{
    internal class Numeros
    {

        public List<int> Pares { get; private set; }
        public List<int> Impares { get; private set; }

        
        public Numeros()
        {
            Pares = new List<int>();
            Impares = new List<int>();
        }

       
        public void ProcesarNumeros(List<int> numeros)
        {
            
            Pares.Clear();
            Impares.Clear();

            
            foreach (var numero in numeros)
            {
                if (numero % 2 == 0)
                    Pares.Add(numero);
                else
                    Impares.Add(numero);
            }
        }

    }
}
