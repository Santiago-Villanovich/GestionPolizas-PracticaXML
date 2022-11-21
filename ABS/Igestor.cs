using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface Igestor< T > where T:IEntidad
    {
        bool Guardar(T obj);
        List<T> Leer();
        T BuscarObj();
    }
}
