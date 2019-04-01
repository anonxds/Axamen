using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axamen.facade
{
   public class subsistemaUPD
    {
        public string update(string vehiculo,int capacidad, string combustible,string ruta,string grimo,int kilometraje,string vim)
        {
            string up = string.Format("update vehiculo set tipo ='{0}',capacidad = '{1}',combustible='{2}',ruta='{3}',grimo='{4}',Kilometraje='{5}' where vim ='{6}'",
                vehiculo, capacidad, combustible, ruta, grimo, kilometraje, vim);
            return up;
        }
    }
    public class subsistemaDEL
    {
        public string delete(string vehiculo)
        {
            string del = string.Format("delete from vehiculo where vim = '{0}'", vehiculo);
            return del;
        }
    }
    public class Popular
    {
        ADB dbs = new ADB();
        public void pop(ComboBox cb,string dato,string tipo)
        {

            dbs.populate(cb,dato,tipo);
        }
    }
}
