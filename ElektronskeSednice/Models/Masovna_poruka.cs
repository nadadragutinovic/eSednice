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
    
    public partial class Masovna_poruka
    {
        public Masovna_poruka()
        {
            this.Masovnas = new HashSet<Masovna>();
        }
    
        public int ID { get; set; }
        public string Tekst { get; set; }
        public Nullable<System.DateTime> Vreme { get; set; }
        public Nullable<bool> Poslat { get; set; }
        public Nullable<int> Salje { get; set; }
    
        public virtual ICollection<Masovna> Masovnas { get; set; }
    }
}
