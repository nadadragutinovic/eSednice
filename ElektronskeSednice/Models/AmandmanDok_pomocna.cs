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
    
    public partial class AmandmanDok_pomocna
    {
        public int Id { get; set; }
        public string Amandman { get; set; }
        public Nullable<int> Dokument { get; set; }
        public string KorisniKU { get; set; }
    
        public virtual DOKUMENTA DOKUMENTA { get; set; }
    }
}