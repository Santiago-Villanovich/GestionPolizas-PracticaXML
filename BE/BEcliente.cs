using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEcliente
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Dni { get; set; }

        public BEcliente() { }

        public override string ToString()
        {
            return Apellido + " " + Nombre;
        }
    }
}
