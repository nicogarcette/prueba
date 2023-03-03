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
    
}
