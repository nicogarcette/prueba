using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("hola");
            Escaleno a = new Escaleno();
            Console.WriteLine(a.Perimetro());

            decimal n = 1, d = 0, result = 0;
            try {
                result = n.DivideBy(d);
                Console.WriteLine($"{n} / {d} = {result}");


            } catch (Exception) {

                Console.WriteLine("divicion por 0");

            } finally {
                Console.WriteLine("chau");
            }



            Console.ReadKey();
        }
    }

    public abstract class Triangulo{
        
        abstract public decimal Perimetro();// el metodo abstracto va sin las llaves
    }
    public class Escaleno:Triangulo {

        public override decimal Perimetro() {

            return 10;
        
        }
    }
}
