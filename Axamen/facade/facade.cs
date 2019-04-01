using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axamen.facade
{
  public  class facades
    {
        BasedeDatos _db;
        EXE _EXE;
        subsistemaUPD _upd;
        subsistemaDEL _del;
        Popular _pop;
        public facades()
        {
            _db = new BasedeDatos();
            _EXE = new EXE();
            _upd = new subsistemaUPD();
            _del = new subsistemaDEL();
            _pop = new Popular();
        }
        public void insertar(string V, string vehiculo, int capacidad, string combustible, string sindicato, string ruta, int kilometraje)
        {
          _EXE.ejecutar(_db.insertar(V,vehiculo,capacidad,combustible,sindicato,ruta,kilometraje));
            MessageBox.Show("Se ingreso exitosamente");
        }
        public void update(string vehiculo, int capacidad, string combustible, string ruta, string grimo, int kilometraje, string vim,ComboBox cb)
        {
            _EXE.ejecutar(_upd.update(vehiculo,capacidad,combustible,ruta,grimo,kilometraje,vim));
            _pop.pop(cb, "select * from vehiculo", "vim");
            MessageBox.Show("Se actualizo los datos exitosamente");
        }
        public void delete(string vehiculo)
        {
            _EXE.ejecutar(_del.delete(vehiculo));
            MessageBox.Show("Se borro de la base de datos");
        }

    }
}
