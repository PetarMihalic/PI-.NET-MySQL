using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFanShop.Klase
{
    public class PopisPonude
    {
        public int ID_ponuda { get; set; }
        public string nazivProizvoda { get; set; }
         public string nazivVrste { get; set; }
        public string nazivFransize { get; set; }
        public string nazivVelicine { get; set; }
        public double ocjena { get; set; }
        public int kolicina { get; set; }
        public Nullable<double> cijena { get; set; }
        
    }
}
