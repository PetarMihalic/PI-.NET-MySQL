using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFanShop.Klase
{
    public class DetaljiZaprimanja
    {
        public int sifraProizvoda { get; set; }
        public string nazivProizvoda { get; set; }
        public string velicinaProizvoda { get; set; }
        public int sifraPrimke { get; set; }
        public string imeDobavljaca { get; set; }
        public DateTime datumZaprimanja { get; set; }
        public int kolicina { get; set; }
    }
}
