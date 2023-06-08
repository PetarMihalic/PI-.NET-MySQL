using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijKosarica
    {
        public RepozitorijKosarica()
        {

        }

        public List<Kosarica> DohvatiSadrzajKosarice(int korisnikID)
        {
            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Kosarica
                            where k.ID_korisnik == korisnikID
                            select k;
                List<Kosarica> sadrzajKosarice = new List<Kosarica>();
                sadrzajKosarice = query.ToList();
                return sadrzajKosarice;
            }
        }

        public int DohvatiFransizuProizvodaIzKosarice(Kosarica selektiraniRedak)
        {
            int ponudaID = selektiraniRedak.ID_ponuda;

            using(var context = new EntitiesOnlineFanShop())
            {
                var query = from pon in context.Ponuda
                            from pro in context.Proizvod
                            where pon.ID_proizvod_FK == pro.ID_proizvod
                            where pon.ID_ponuda == ponudaID
                            select pro.ID_fransiza_FK;

                return query.Single();
            }
        }

        internal void DodajPopust(int korisnikID)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from k in context.Kosarica
                            where k.ID_korisnik == korisnikID
                            select k;
                foreach (var item in query)
                {
                    item.popust = 10;
                }
                context.SaveChanges();
            }
        }
    }
}
