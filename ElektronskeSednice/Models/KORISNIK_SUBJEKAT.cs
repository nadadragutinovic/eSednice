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
    
    public partial class KORISNIK_SUBJEKAT
    {
        public int ID { get; set; }
        public Nullable<int> ID_SUBJEKAT { get; set; }
        public Nullable<int> ID_KORISNIK { get; set; }
        public Nullable<bool> PRIPADA_GRUPI { get; set; }
        public Nullable<System.DateTime> DATUM { get; set; }
        public Nullable<bool> Prva { get; set; }
    
        public virtual KORISNIK KORISNIK { get; set; }
        public virtual SUBJEKAT SUBJEKAT { get; set; }
    }
}
