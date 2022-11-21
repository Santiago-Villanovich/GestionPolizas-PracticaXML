using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPPER;
using BE;

namespace BLL
{
    public class BLLpAutomovil : BLLpoliza
    {
        public override double CalcularPrima(double PrecioBase)
        {
            double aux = PrecioBase + ((PrecioBase * 0.1) / 100);
            return aux;
        }

        MPPpAutomovil mpp = new MPPpAutomovil();

        public bool Agregar(BEPautomovil obj)
        {
            return mpp.agregar(obj);
        }

        public bool Eliminar(string id)
        {
            return mpp.Eliminar(id);
        }

        public bool Modificar(BEPautomovil obj)
        {
            return mpp.Modificar(obj);
        }

        public List<BEPautomovil> Listar()
        {
            return mpp.Listar();
        }
    }
}
