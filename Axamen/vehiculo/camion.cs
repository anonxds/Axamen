using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axamen.vehiculo
{
    class camion : Vehiculo
    {
        private readonly string _tipovehiculo;
        private int _capacidad;
        private int _kilometraje;
        private string _combustible;
        private string _vin;
        public camion(int kilometraje, int capacidad, string combustible, string vin)
        {
            _capacidad = capacidad;
            _kilometraje = kilometraje;
            _tipovehiculo = "devuelve";
            _combustible = combustible;
            _vin = vin;
        }

        public override string Nombre { get { return _tipovehiculo; } }

        public override int kilometrage
        {
            get { return _kilometraje; }
            set { _kilometraje = value; }
        }

        public override int capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }

        public override string combustible { get => _combustible; set => _combustible = value; }
        public override string VIN { get => _vin; set => _vin = value; }
    }
}
