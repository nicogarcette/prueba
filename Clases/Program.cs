using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("hola");

            Console.ReadKey();


        }
    }

    public abstract class Triangulo{
        
        abstract public decimal Perimetro();// el metodo abstracto va sin las llaves
    }
    public class escaleno:Triangulo {

        public override decimal Perimetro() {

            return 10;
        
        }
    }
}
