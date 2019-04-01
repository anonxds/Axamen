using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axamen.vehiculo
{
  abstract  class Vehiculo
    {
        public abstract string Nombre { get; }
        public abstract int kilometrage { get; set; }
        public abstract int capacidad { get; set; }
        public abstract string combustible { get; set; }
        public abstract string VIN { get; set; }
    }
}
