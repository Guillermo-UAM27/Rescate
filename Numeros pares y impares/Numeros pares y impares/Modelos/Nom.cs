using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_pares_y_impares.Nombres
{
    public class Nom
    {

        public List<string> NombresConJ { get; set; }
        public List<string> OtrosNombres { get; set; }


        public Nom()
        {
            NombresConJ = new List<string>();
            OtrosNombres = new List<string>();
        }

        public void ProcesarNombres(List<string> nombres)
        {

            NombresConJ.Clear();
            OtrosNombres.Clear();


            foreach (var nombre in nombres)
            {
                if (nombre.StartsWith("J", StringComparison.OrdinalIgnoreCase))
                    NombresConJ.Add(nombre);
                else
                    OtrosNombres.Add(nombre);
            }
        }
    }
}
