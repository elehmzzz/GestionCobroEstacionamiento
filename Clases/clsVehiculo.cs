using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionCobroEstacionamiento.Clases
{
    internal abstract class clsVehiculo
    {
        protected int horasEstancia;

        //constructor
        public clsVehiculo(int horasEstancia) {
            this.horasEstancia = horasEstancia;
        }
        public abstract float CalcularTarifa();
    }
}
