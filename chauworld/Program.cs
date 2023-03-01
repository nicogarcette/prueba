using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

namespace chauworld {
    class Program {
        static void Main(string[] args) {

            Console.Write("buscando el porque se subio la carpeta properties");
            Console.WriteLine("de todas formas se subio la carpeta Properties. depende del proyecto.");

            int num = 10;

            int g = '2';// tomo el codigo ascii

            try {
                int valor = num /0; 
               
            } catch (DivideByZeroException) {
                Console.WriteLine("Divicion entre 0");
            }

            // probando break point
            int cadena = 0;
            for (int i = 0; i < g; i++) {
                cadena += i;
            }

            /* hola*/
            Console.Write(cadena);
            Console.ReadKey();
        }
    }
}
