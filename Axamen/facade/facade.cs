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
        public void insertar(string V, string vehiculo, int capacidad, string combustible, string sindicato, string ruta, int kilometraje,ComboBox cb)
        {
            try
            {
                _EXE.ejecutar(_db.insertar(V, vehiculo, capacidad, combustible, sindicato, ruta, kilometraje));
                _pop.pop(cb, "select * from vehiculo", "vim");
                MessageBox.Show("Se ingreso exitosamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
        }
        public void update(string vehiculo, int capacidad, string combustible, string ruta, string grimo, int kilometraje, string vim,ComboBox cb)
        {
            try
            {
                _EXE.ejecutar(_upd.update(vehiculo, capacidad, combustible, ruta, grimo, kilometraje, vim));
                _pop.pop(cb, "select * from vehiculo", "vim");
                MessageBox.Show("Se actualizo los datos exitosamente");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void delete(string vehiculo,ComboBox cb)
        {
            try
            {
                _EXE.ejecutar(_del.delete(vehiculo));
                _pop.pop(cb, "select * from vehiculo", "vim");
                MessageBox.Show("Se borro de la base de datos");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void LP(ComboBox cbvehiculo,ComboBox cbtiporuta, ComboBox cbIgremio,ComboBox cbR)
        {
            _pop.pop(cbvehiculo, "select * from vehiculo", "vim");
            _pop.pop(cbtiporuta, "select * from grimos", "nombre");
            _pop.pop(cbIgremio, "select * from grimos", "nombre");
            _pop.pop(cbR, "select * from rutas", "nombre");
        }

    }
}
