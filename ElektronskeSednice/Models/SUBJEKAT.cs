//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElektronskeSednice.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUBJEKAT
    {
        public SUBJEKAT()
        {
            this.Dokumenta_Subjekat = new HashSet<Dokumenta_Subjekat>();
            this.KORISNIK_SUBJEKAT = new HashSet<KORISNIK_SUBJEKAT>();
            this.SEDNICEs = new HashSet<SEDNICE>();
            this.Tacke_Dnevnog_Reda = new HashSet<Tacke_Dnevnog_Reda>();
        }
    
        public int ID { get; set; }


        public string NAZIV { get; set; }
        public string KOMENTAR { get; set; }
        public Nullable<bool> AKTIVAN { get; set; }
        public Nullable<bool> Predlagac { get; set; }
    
        public virtual ICollection<Dokumenta_Subjekat> Dokumenta_Subjekat { get; set; }
        public virtual ICollection<KORISNIK_SUBJEKAT> KORISNIK_SUBJEKAT { get; set; }
        public virtual ICollection<SEDNICE> SEDNICEs { get; set; }
        public virtual ICollection<Tacke_Dnevnog_Reda> Tacke_Dnevnog_Reda { get; set; }
    }
}