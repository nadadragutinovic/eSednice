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
    
    public partial class TIP_SEDNICE
    {
        public TIP_SEDNICE()
        {
            this.SEDNICEs = new HashSet<SEDNICE>();
        }
    
        public int ID { get; set; }
        public string OPIS { get; set; }
    
        public virtual ICollection<SEDNICE> SEDNICEs { get; set; }
    }
}