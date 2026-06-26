using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionCobroEstacionamiento.Clases
{
    internal class Automovil : clsVehiculo
    {
        public string Placa {get; set;}
        public Automovil(int horasEstancia,string placa):base(horasEstancia)
        {
            
            Placa= placa;
        }
        public override float CalcularTarifa()
        {
           return horasEstancia * 30.00f;
        }


    }
}
