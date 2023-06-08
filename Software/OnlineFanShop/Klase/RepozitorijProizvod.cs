using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijProizvod
    {
        public void DodajNoviProizvod(string naziv, int fransiza, int velicina, int vrsta)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                Proizvod proizvod = new Proizvod()
                {
                    nazivProizvoda = naziv,
                    ID_fransiza_FK = fransiza,
                    ID_velicina_FK = velicina,
                    ID_vrsta_FK = vrsta

                };

                context.Proizvod.Add(proizvod);
                context.SaveChanges();
            }
        }

        public List<Proizvod> DohvatiSveProizvode()
        {
            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from p in context.Proizvod
                            select p;

                List<Proizvod> proizvodi = new List<Proizvod>();
                proizvodi = query.ToList();
                return proizvodi;
            }
        }
    }
}
