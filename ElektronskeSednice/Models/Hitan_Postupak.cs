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
    
    public partial class Hitan_Postupak
    {
        public int Id { get; set; }
        public Nullable<int> Korisnik { get; set; }
        public string Tekst { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<int> Sednice { get; set; }
        public string Link { get; set; }
        public string Naziv { get; set; }
    
        public virtual KORISNIK KORISNIK1 { get; set; }
    }
}
