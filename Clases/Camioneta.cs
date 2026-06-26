using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCobroEstacionamiento.Clases
{
    internal class Camioneta : clsVehiculo
    {
        //ATRIBUTO ESPECIFICO DE CAMIONETA - NUMERO DE EJES
        private int numeroEjes;

        //PROPIEDAD PARA VER Y CAMBIAR EL NUMERO DE EJES
        public int NumeroEjes
        {
            get { return numeroEjes; }
            set { numeroEjes = value; }
        }

        //CONSTRUCTOR - RECIBE LAS HORAS Y LOS EJES
        //USA "base" PARA MANDAR LAS HORAS A LA CLASE PADRE
        public Camioneta(int horasEstancia, int numeroEjes) : base(horasEstancia)
        {
            this.numeroEjes = numeroEjes;
        }

        //CALCULA LA TARIFA DE LA CAMIONETA
        public override float CalcularTarifa()
        {
            //alexa cambios: MULTIPLICA HORAS POR $45.00
            return horasEstancia * 45.00f;
        }

        //INFORMACION DE LA CAMIONETA
        public override string ToString()
        {
            return "Camioneta - Ejes: " + numeroEjes + " - Total: $" + CalcularTarifa();
        }
    }
}
