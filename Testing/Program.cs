using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing {
    public class Program {
        static void Main(string[] args) {

            Console.WriteLine("---UniTest---");



            Console.WriteLine(EsPrimo(5));

            Console.ReadKey();
        }

        public static bool EsPrimo(int num) {
            int d = 2;
            bool es = true;

            while (es && d < num) {
                if (num%d == 0) {
                    es = false;
                }

                d++;
            }

            return es;
        }
    }
}
