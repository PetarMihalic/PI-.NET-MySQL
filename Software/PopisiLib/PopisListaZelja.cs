using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFanShop.Klase
{
    public class PopisListaZelja
    {
        public int id_ponuda { get; set; }
        public string nazivProizvoda { get; set; }
        public string velicina { get; set; }
        public string fransiza { get; set; }
        public DateTime? datumStavljanja { get; set; }
        public double? cijena { get; set; }
    }
}
