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
    
    public partial class DOKUMENTA
    {
        public DOKUMENTA()
        {
            this.Amandmen = new HashSet<Amandman>();
            this.AmandmanDok_pomocna = new HashSet<AmandmanDok_pomocna>();
            this.Dokumenta_Subjekat = new HashSet<Dokumenta_Subjekat>();
            this.Dokumenta_Subjekat1 = new HashSet<Dokumenta_Subjekat>();
            this.Komentars = new HashSet<Komentar>();
            this.Tacke_Dnevnog_Reda = new HashSet<Tacke_Dnevnog_Reda>();
        }
    
        public int ID { get; set; }
        public string NAZIV { get; set; }
        public string BROJ { get; set; }
        public Nullable<System.DateTime> DATUM_USVAJANJA { get; set; }
        public Nullable<int> POSTAVIO { get; set; }
        public string TEKST { get; set; }
        public string LINK { get; set; }
        public string LINK_ZAVRSEN { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<System.DateTime> DATUM_POCETKA_PRIMENE { get; set; }
        public Nullable<bool> Osnovni_dokument { get; set; }
        public string ID_Osnovnog_Dokumenta { get; set; }
    
        public virtual ICollection<Amandman> Amandmen { get; set; }
        public virtual ICollection<AmandmanDok_pomocna> AmandmanDok_pomocna { get; set; }
        public virtual Status_dokumenta Status_dokumenta { get; set; }
        public virtual ICollection<Dokumenta_Subjekat> Dokumenta_Subjekat { get; set; }
        public virtual ICollection<Dokumenta_Subjekat> Dokumenta_Subjekat1 { get; set; }
        public virtual ICollection<Komentar> Komentars { get; set; }
        public virtual ICollection<Tacke_Dnevnog_Reda> Tacke_Dnevnog_Reda { get; set; }
    }
}
