using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal {
    public abstract class TransportePublico {

        //public int pasajeros { get; set; }
        protected int pasajeros;

        public TransportePublico(int pasajeros) {

            this.pasajeros = pasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }
    public class Omnibus : TransportePublico {

        public Omnibus(int pasajeros): base(pasajeros) {

        }

        public override void Avanzar() {

            Console.WriteLine($"Arranca el bondi con {pasajeros} pasajeros");
        }
        public override void Detenerse() { 
        
            Console.WriteLine($"frena el bondi con {pasajeros} pasajeros");
        }
    }
    public class Taxi : TransportePublico {

        public Taxi(int pasajeros) : base(pasajeros) {

        }

        public override void Avanzar() {

            Console.WriteLine($"Arranca el taxi con {pasajeros} pasajeros");
        }
        public override void Detenerse() {

            Console.WriteLine($"frena el taxi con {pasajeros} pasajeros");
        }
    }

}
