//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineFanShop.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kosarica
    {
        public int ID_korisnik { get; set; }
        public int ID_ponuda { get; set; }
        public Nullable<int> kolicina { get; set; }
        public Nullable<int> popust { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Ponuda Ponuda { get; set; }
    }
}
