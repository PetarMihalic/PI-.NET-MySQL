using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineFanShop.Klase;
using OnlineFanShop.Entities;
using System;
using System.Collections.Generic;

namespace Testovi
{
    [TestClass]
    public class SviTestovi
    {
        [TestMethod]
        public void FanKviz_TocanOdgovorNaPitanje_VracaTrue()
        {
            RepozitorijFanKviz repozitorijFanKviz = new RepozitorijFanKviz();

            Assert.IsTrue(repozitorijFanKviz.ProvjeriTočnostOdgovora("Kako se zove mac Arye Stark?", "Needle"));
        }

        [TestMethod]
        public void FanKviz_NetocanOdgovorNaPitanje_VracaFalse()
        {
            RepozitorijFanKviz repozitorijFanKviz = new RepozitorijFanKviz();

            Assert.IsFalse(repozitorijFanKviz.ProvjeriTočnostOdgovora("Kako se zove mac Arye Stark?", "Ice"));
        }

        [TestMethod]
        public void FanKviz_DohvacanjePitanjaZaFransizu_VracaListuOdTriPitanja()
        {
            RepozitorijFanKviz repozitorijFanKviz = new RepozitorijFanKviz();

            Assert.AreEqual(repozitorijFanKviz.DohvatiPitanjaZaFransizu(1).Count, 3);
        }

        [TestMethod]
        public void Ponuda_PretrazivanjeProizvodaKojiNePostoje_VracaPraznuListu()
        {
            RepozitorijPonuda repozitorijPonuda = new RepozitorijPonuda();

            Assert.IsTrue(repozitorijPonuda.Pretrazi("kapa").Count == 0);
        }

        [TestMethod]
        public void Ponuda_FiltriranjeUnesenaVecaMinOdMax_VracaPraznuListu()
        {
            RepozitorijPonuda repozitorijPonuda = new RepozitorijPonuda();

            Assert.IsTrue(repozitorijPonuda.Filtriraj(150, 140, "","","").Count == 0);
        }

        [TestMethod]
        public void Ponuda_PretrazivanjeProizvodaKojiPostoje_VracaListuProizvoda()
        {
            RepozitorijPonuda repozitorijPonuda = new RepozitorijPonuda();

            Assert.IsTrue(repozitorijPonuda.Pretrazi("majica").Count > 0);
        }

        [TestMethod]
        public void Korisnici_ProvjeraZeliLiKorisnikObavijesti_VracaTrue()
        {
            RepozitorjKorisnici repozitorjKorisnici = new RepozitorjKorisnici();

            Assert.IsTrue(repozitorjKorisnici.KorisnikZeliObavijesti(1));
        }
    }
}
