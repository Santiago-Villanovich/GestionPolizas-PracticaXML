using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEpoliza
    {
        public int ID { get; set; }
        public string Estado { get; set; }
        public double Tasa { get; set; }
        public double Prima { get; set; }
        public BEcliente Cliente { get; set; }

    }
}
