using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFanShop.Entities;

namespace OnlineFanShop.Klase
{
    public class RepozitorijPonuda
    {
        public List<PopisPonude> PopuniPonudaDGV()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from ponuda in context.Ponuda
                            from proizvod in context.Proizvod
                            from vrsta in context.VrstaProizvoda
                            from fransiza in context.FransizaProizvoda
                            from velicina in context.VelicinaProizvoda
                            where ponuda.ID_proizvod_FK == proizvod.ID_proizvod
                            && proizvod.ID_fransiza_FK == fransiza.ID_fransiza
                            && proizvod.ID_velicina_FK == velicina.ID_velicina
                            && proizvod.ID_vrsta_FK == vrsta.ID_vrsta
                            select new PopisPonude
                            {
                                ID_ponuda = proizvod.ID_proizvod,
                                nazivProizvoda = proizvod.nazivProizvoda,
                                nazivVrste = vrsta.nazivVrste,
                                nazivFransize = fransiza.nazivFransize,
                                nazivVelicine = velicina.nazivVelicine,
                                ocjena = ponuda.ocjena,
                                kolicina = ponuda.kolicina,
                                cijena = ponuda.cijena
                            };

                List<PopisPonude> popisPonude = new List<PopisPonude>();
                popisPonude = query.ToList();
                return popisPonude;
            }
        }

        public List<FransizaProizvoda> PopuniFransizaCMB()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from fransiza in context.FransizaProizvoda
                            select fransiza;

                List<FransizaProizvoda> fransizaProizvoda = new List<FransizaProizvoda>();
                fransizaProizvoda = query.ToList();
                return fransizaProizvoda;
            }
        }

        public List<VelicinaProizvoda> PopuniVelicinaCMB()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from velicina in context.VelicinaProizvoda
                            select velicina;

                List<VelicinaProizvoda> veicinaProizvoda = new List<VelicinaProizvoda>();
                veicinaProizvoda = query.ToList();
                return veicinaProizvoda;
            }
        }

        public List<VrstaProizvoda> PopuniVrstaCMB()
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from vrsta in context.VrstaProizvoda
                            select vrsta;

                List<VrstaProizvoda> vrstaProizvoda = new List<VrstaProizvoda>();
                vrstaProizvoda = query.ToList();
                return vrstaProizvoda;
            }
        }

        public List<PopisPonude> Filtriraj(float cijenaMin, float cijenaMax, string fransizaProizvoda, string velicinaProizvoda, string vrstaProizvoda)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from ponuda in context.Ponuda
                            from proizvod in context.Proizvod
                            from vrsta in context.VrstaProizvoda
                            from fransiza in context.FransizaProizvoda
                            from velicina in context.VelicinaProizvoda
                            where ponuda.ID_proizvod_FK == proizvod.ID_proizvod
                            && proizvod.ID_fransiza_FK == fransiza.ID_fransiza
                            && proizvod.ID_velicina_FK == velicina.ID_velicina
                            && proizvod.ID_vrsta_FK == vrsta.ID_vrsta
                            && ponuda.cijena >= cijenaMin
                            && ponuda.cijena <= cijenaMax
                            && vrsta.nazivVrste.Contains(vrstaProizvoda)
                            && velicina.nazivVelicine.Contains(velicinaProizvoda)
                            && fransiza.nazivFransize.Contains(fransizaProizvoda)

                            select new PopisPonude
                            {
                                ID_ponuda = proizvod.ID_proizvod,
                                nazivProizvoda = proizvod.nazivProizvoda,
                                nazivVrste = vrsta.nazivVrste,
                                nazivFransize = fransiza.nazivFransize,
                                nazivVelicine = velicina.nazivVelicine,
                                ocjena = ponuda.ocjena,
                                kolicina = ponuda.kolicina,
                                cijena = ponuda.cijena
                            };

                List<PopisPonude> popisPonude = new List<PopisPonude>();
                popisPonude = query.ToList();
                return popisPonude;
            }
        }

        public List<PopisPonude> Sortiraj(string sortiranjePrema)
        {
            if (sortiranjePrema == "Po vrsti")
            {
                using (var context = new EntitiesOnlineFanShop())
                {
                    var query = from ponuda in context.Ponuda
                                from proizvod in context.Proizvod
                                from vrsta in context.VrstaProizvoda
                                from fransiza in context.FransizaProizvoda
                                from velicina in context.VelicinaProizvoda
                                where ponuda.ID_proizvod_FK == proizvod.ID_proizvod
                                && proizvod.ID_fransiza_FK == fransiza.ID_fransiza
                                && proizvod.ID_velicina_FK == velicina.ID_velicina
                                && proizvod.ID_vrsta_FK == vrsta.ID_vrsta
                                orderby vrsta.nazivVrste

                                select new PopisPonude
                                {
                                    ID_ponuda = proizvod.ID_proizvod,
                                    nazivProizvoda = proizvod.nazivProizvoda,
                                    nazivVrste = vrsta.nazivVrste,
                                    nazivFransize = fransiza.nazivFransize,
                                    nazivVelicine = velicina.nazivVelicine,
                                    ocjena = ponuda.ocjena,
                                    kolicina = ponuda.kolicina,
                                    cijena = ponuda.cijena
                                };


                    List<PopisPonude> popisPonude = new List<PopisPonude>();
                    popisPonude = query.ToList();
                    return popisPonude;
                }
            }
            else if (sortiranjePrema == "Po franšizi")
            {
                using (var context = new EntitiesOnlineFanShop())
                {
                    var query = from ponuda in context.Ponuda
                                from proizvod in context.Proizvod
                                from vrsta in context.VrstaProizvoda
                                from fransiza in context.FransizaProizvoda
                                from velicina in context.VelicinaProizvoda
                                where ponuda.ID_proizvod_FK == proizvod.ID_proizvod
                                && proizvod.ID_fransiza_FK == fransiza.ID_fransiza
                                && proizvod.ID_velicina_FK == velicina.ID_velicina
                                && proizvod.ID_vrsta_FK == vrsta.ID_vrsta
                                orderby fransiza.nazivFransize

                                select new PopisPonude
                                {
                                    ID_ponuda = proizvod.ID_proizvod,
                                    nazivProizvoda = proizvod.nazivProizvoda,
                                    nazivVrste = vrsta.nazivVrste,
                                    nazivFransize = fransiza.nazivFransize,
                                    nazivVelicine = velicina.nazivVelicine,
                                    ocjena = ponuda.ocjena,
                                    kolicina = ponuda.kolicina,
                                    cijena = ponuda.cijena
                                };


                    List<PopisPonude> popisPonude = new List<PopisPonude>();
                    popisPonude = query.ToList();
                    return popisPonude;
                }
            }
            else if (sortiranjePrema == "Po ocjeni")
            {
                using (var context = new EntitiesOnlineFanShop())
                {
                    var query = from ponuda in context.Ponuda
                                from proizvod in context.Proizvod
                                from vrsta in context.VrstaProizvoda
                                from fransiza in context.FransizaProizvoda
                                from velicina in context.VelicinaProizvoda
                                where ponuda.ID_proizvod_FK == proizvod.ID_proizvod
                                && proizvod.ID_fransiza_FK == fransiza.ID_fransiza
                                && proizvod.ID_velicina_FK == velicina.ID_velicina
                                && proizvod.ID_vrsta_FK == vrsta.ID_vrsta
                                orderby ponuda.ocjena

                                select new PopisPonude
                                {
                                    ID_ponuda = proizvod.ID_proizvod,
                                    nazivProizvoda = proizvod.nazivProizvoda,
                                    nazivVrste = vrsta.nazivVrste,
                                    nazivFransize = fransiza.nazivFransize,
                                    nazivVelicine = velicina.nazivVelicine,
                                    ocjena = ponuda.ocjena,
                                    kolicina = ponuda.kolicina,
                                    cijena = ponuda.cijena
                                };


                    List<PopisPonude> popisPonude = new List<PopisPonude>();
                    popisPonude = query.ToList();
                    return popisPonude;
                }
            }
            else 
            {
                using (var context = new EntitiesOnlineFanShop())
                {
                    var query = from ponuda in context.Ponuda
                                from proizvod in context.Proizvod
                                from vrsta in context.VrstaProizvoda
                                from fransiza in context.FransizaProizvoda
                                from velicina in context.VelicinaProizvoda
                                where ponuda.ID_proizvod_FK == proizvod.ID_proizvod
                                && proizvod.ID_fransiza_FK == fransiza.ID_fransiza
                                && proizvod.ID_velicina_FK == velicina.ID_velicina
                                && proizvod.ID_vrsta_FK == vrsta.ID_vrsta
                                orderby ponuda.cijena

                                select new PopisPonude
                                {
                                    ID_ponuda = proizvod.ID_proizvod,
                                    nazivProizvoda = proizvod.nazivProizvoda,
                                    nazivVrste = vrsta.nazivVrste,
                                    nazivFransize = fransiza.nazivFransize,
                                    nazivVelicine = velicina.nazivVelicine,
                                    ocjena = ponuda.ocjena,
                                    kolicina = ponuda.kolicina,
                                    cijena = ponuda.cijena
                                };


                    List<PopisPonude> popisPonude = new List<PopisPonude>();
                    popisPonude = query.ToList();
                    return popisPonude;
                }
            }
        }

        public List<PopisPonude> Pretrazi(string naziv)
        {
            using (var context = new EntitiesOnlineFanShop())
            {
                var query = from ponuda in context.Ponuda
                            from proizvod in context.Proizvod
                            from vrsta in context.VrstaProizvoda
                            from fransiza in context.FransizaProizvoda
                            from velicina in context.VelicinaProizvoda
                            where ponuda.ID_proizvod_FK == proizvod.ID_proizvod
                            && proizvod.ID_fransiza_FK == fransiza.ID_fransiza
                            && proizvod.ID_velicina_FK == velicina.ID_velicina
                            && proizvod.ID_vrsta_FK == vrsta.ID_vrsta
                            && proizvod.nazivProizvoda.Contains(naziv)
                            select new PopisPonude
                            {
                                ID_ponuda = proizvod.ID_proizvod,
                                nazivProizvoda = proizvod.nazivProizvoda,
                                nazivVrste = vrsta.nazivVrste,
                                nazivFransize = fransiza.nazivFransize,
                                nazivVelicine = velicina.nazivVelicine,
                                ocjena = ponuda.ocjena,
                                kolicina = ponuda.kolicina,
                                cijena = ponuda.cijena
                            };

                List<PopisPonude> popisPonude = new List<PopisPonude>();
                popisPonude = query.ToList();
                return popisPonude;
            }
        }

    }
}
