using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axamen.vehiculo
{
    class concretefactory : vehiculofabrica
    {
        private int _kilometraje;
        private int _capacida;
        private string _combustible;
        private string _vin;
        public concretefactory(int kilometraje, int capacida,string combustible,string vin)
        {
            _kilometraje = kilometraje;
            _capacida = capacida;
            _combustible = combustible;
            _vin = vin;
        }

        public override Vehiculo GetVehiculo()
        {
            return new taxi(_kilometraje, _capacida,_combustible,_vin);
        }
    }
}
