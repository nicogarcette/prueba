using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("\n------Terminal------\n");

            List<TransportePublico> transportePublicos = new List<TransportePublico>();

            for (int i = 0; i < 5; i++) {
                transportePublicos.Add(new Taxi(i + 1));
                transportePublicos.Add(new Omnibus((i + 2)*10));
            }

            foreach (var transporte in transportePublicos) {
                transporte.Avanzar();
            }
            Console.WriteLine("\n....accidente en mitre y josePerez\n");
            foreach (var transporte in transportePublicos) {
                transporte.Detenerse();
            }

            Console.ReadKey();
        }
    }
}
