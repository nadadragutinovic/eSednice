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
    
    public partial class MasovniMail
    {
        public int Id { get; set; }
        public Nullable<int> Poruka { get; set; }
        public Nullable<int> Prima { get; set; }
    
        public virtual KORISNIK KORISNIK { get; set; }
        public virtual MasovniMail_Poruka MasovniMail_Poruka { get; set; }
    }
}