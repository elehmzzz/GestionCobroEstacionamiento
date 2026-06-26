using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCobroEstacionamiento.Clases
{
    internal class Motocicleta : clsVehiculo
    {
        private int cilindrada;

        // Constructor: Pasa las horas al constructor base público y asigna la cilindrada
        public Motocicleta(int horasEstancia, int cilindrada) : base(horasEstancia)
        {
            this.cilindrada = cilindrada;
        }

        // Propiedad encapsulada para acceder o modificar la cilindrada
        public int Cilindrada
        {
            get{ return cilindrada; }
            set { cilindrada = value;}
        }

        // Polimorfismo: Sobrescritura de CalcularTarifa con la tarifa económica ($15.00)
        public override float CalcularTarifa()
        {
            return this.horasEstancia * 15.00f;
        }
    }
}
