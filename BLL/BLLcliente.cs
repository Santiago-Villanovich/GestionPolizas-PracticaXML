using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPPER;
using BE;


namespace BLL
{
    public class BLLcliente
    {

        MPPcliente mpp = new MPPcliente();

        public bool AgregarCliente(BEcliente obj)
        {
            return mpp.Agregar(obj);
        }
        
        public bool Eliminar(string id)
        {
            return mpp.Eliminar(id);
        }

        public bool Modificar(BEcliente obj)
        {
            return mpp.Modificar(obj);
        }

        public List<BEcliente> Listar()
        {
            return mpp.Listar();
        }

        public List<BEcliente> BuscarID(string id)
        {
            return mpp.buscar(id);
        }
    }
}
