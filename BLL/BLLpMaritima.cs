using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPPER;
using BE;

namespace BLL
{
    public class BLLpMaritima : BLLpoliza
    {
        public override double CalcularPrima(double PrecioBase)
        {
            double aux = PrecioBase + ((PrecioBase * 0.3)/100);
            return aux;

        }

        MPPpMaritima mpp = new MPPpMaritima();

        public bool Agregar(BEPmaritima obj)
        {
            return mpp.agregar(obj);
        }

        public bool Eliminar(string id)
        {
            return mpp.Eliminar(id);
        }

        public bool Modificar(BEPmaritima obj)
        {
            return mpp.Modificar(obj);
        }

        public List<BEPmaritima> Listar()
        {
            return mpp.Listar();
        }

    }
}
