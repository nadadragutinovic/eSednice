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
    
    public partial class Tacke_Dnevnog_Reda
    {
        public Tacke_Dnevnog_Reda()
        {
            this.Komentar_Tacka = new HashSet<Komentar_Tacka>();
        }
    
        public int id { get; set; }
        public string Naziv_tacke { get; set; }
        public Nullable<int> Dokument { get; set; }
        public Nullable<int> Sednica { get; set; }
        public Nullable<int> Redni_broj { get; set; }
        public Nullable<bool> Verzija { get; set; }
        public string Link_Dokumenta { get; set; }
        public Nullable<bool> prva { get; set; }
        public Nullable<bool> hitna { get; set; }
        public Nullable<int> predlagac { get; set; }
    
        public virtual DOKUMENTA DOKUMENTA { get; set; }
        public virtual ICollection<Komentar_Tacka> Komentar_Tacka { get; set; }
        public virtual SEDNICE SEDNICE { get; set; }
        public virtual SUBJEKAT SUBJEKAT { get; set; }
    }
}
