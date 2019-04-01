using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axamen.facade
{
    class BasedeDatos
    {

        public string insertar(string V,string vehiculo,int capacidad,string combustible,string sindicato,string ruta,int kilometraje)
        {
            string A = string.Format("INSERT INTO vehiculo (`vim`, `tipo`, `capacidad`, `combustible`, `grimo`, `ruta`,`Kilometraje`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}')",
                V, vehiculo, capacidad, combustible, sindicato, ruta, kilometraje);
            return A;
            
        }
    }
    class EXE
    {
        ADB dbs = new ADB();
        public void ejecutar(string dato)
        {
            dbs.Exe(dato);
            
        }
        public void ejecutarCB(ComboBox cb,string dato,string tipo)
        {
            dbs.populate(cb, dato, tipo);
        }
    }
}
