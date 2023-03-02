using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases {
    public static class MyExtensions {

        public static decimal DivideBy(this decimal num, decimal num2) {
            decimal resu;
			try {
                resu = num / num2;  

			} catch (DivideByZeroException a) {
                throw a;
			}
            return resu;
        }

    }
}
