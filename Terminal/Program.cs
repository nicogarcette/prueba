using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("\n---------------Terminal---------------");

            List<TransportePublico> transportePublicos = new List<TransportePublico>();

            bool entrar = false;

            int total = 0;
            int countT = 0;
            int countB = 0;
            Console.WriteLine("\nSe requiere registrar los pasajeros de los 5 Omnibus y 5 taxis en circulacion.");
            while (!entrar) {
                int opc = validarOpc();

                if (opc == 1 && countT < 5) {
                    countT++;
                    total++;
                    //Console.WriteLine($"opc taxi {countT}");
                    addTaxi(ref transportePublicos);
               

                } else if (opc == 2 && countB < 5) {
                    countB++;
                    total++;
                    //Console.WriteLine($"opc bondi {countB}");

                    addOmnibus(ref transportePublicos);
                }
                //Console.WriteLine($"el total es {total}");
                if (total==10) {
                    entrar = true;  
                }
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

        public static int validarOpc() {
            int opc=0;
            bool ok = false;
            while (!ok) {
                Console.WriteLine("\n1-ingresar taxi\n2-ingresar bondi\n");

                try {
                    opc = int.Parse(Console.ReadLine());
                } catch (FormatException) {
                    Console.WriteLine("** Solo numeros **");
                } catch (OverflowException) {
                    Console.WriteLine("** Numero fuera del limite **");
                }

                if (opc > 0  && opc < 3) {
                    ok = true;
                } else {
                    Console.WriteLine("Ingrese una opcion correcta");
                }
            }
            return opc;
        }

        public static int validarPasajerosOmnibus() {
            bool entrar = false;
            int pasajero = 0;
            while (!entrar) {
                try {
                     pasajero = int.Parse(Console.ReadLine());

                } catch (Exception) {

                    Console.Write("Solo numeros.");
                }

                if (pasajero > 0 && pasajero < 101) {
                    entrar = true;
                } else {
                    Console.WriteLine("Limite de pasajeros = 100");
                }
            }
            return pasajero;

        }
        public static int validarPasajerosTaxi() {
            bool entrar = false;
            int pasajero = 0;
            while (!entrar) {
                try {
                    pasajero = int.Parse(Console.ReadLine());

                } catch (Exception) {

                    Console.Write("Solo numeros.");
                }

                if (pasajero > 0 && pasajero < 5) {
                    entrar = true;
                } else {
                    Console.WriteLine("Limite de pasajeros = 4");
                }
            }
            return pasajero;

        }
        public static void addOmnibus(ref List<TransportePublico>lista) {

            Console.Write("Ingrese pasajeros:");
            int pasajeros = validarPasajerosOmnibus();
            lista.Add(new Omnibus(pasajeros));
        }
        public static void addTaxi(ref List<TransportePublico> lista) {

            Console.Write("Ingrese pasajeros:");
            int pasajeros = validarPasajerosTaxi();
            lista.Add(new Taxi(pasajeros));
        }
    }
}
