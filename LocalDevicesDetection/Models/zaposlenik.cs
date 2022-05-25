using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDevicesDetection.Models
{
    public abstract class zaposlenik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Uloga { get; set; }
    }

    public class voditelj : zaposlenik
    {
        public string objekt { get; set; }
    }

    public class zastitar : zaposlenik
    {
        public int broj_zatvorenika { get; set; }
    }
}
