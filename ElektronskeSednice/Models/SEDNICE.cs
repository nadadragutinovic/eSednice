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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class SEDNICE
    {
        public SEDNICE()
        {
            this.Izmene_DnReda = new HashSet<Izmene_DnReda>();
            this.Mails = new HashSet<Mail>();
            this.Pozvani_Korisnici = new HashSet<Pozvani_Korisnici>();
            this.Tacke_Dnevnog_Reda = new HashSet<Tacke_Dnevnog_Reda>();
            this.Zapisniks = new HashSet<Zapisnik>();
            Zavrsena = false;
        }
    
        public int ID { get; set; }

        [Helper.LocalizedDisplayName("BrojSednice", NameResourceType = typeof(ViewRes.SedniceStrings))]
        public string BROJ { get; set; }
        
        public Nullable<int> SUBJEKAT { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        [Helper.LocalizedDisplayName("Datum", NameResourceType = typeof(ViewRes.SharedStrings))]
        public Nullable<System.DateTime> DATUM { get; set; }

        public string Vreme_sat { get; set; }
        public string Vreme_minut { get; set; }
        public string username { get; set; }
        public Nullable<System.DateTime> date_time { get; set; }
        public Nullable<int> TIP_SEDNICE { get; set; }
        public Nullable<int> Predsedava { get; set; }
        public bool Zavrsena { get; set; }
        public Nullable<int> Brojac { get; set; }
        public Nullable<System.DateTime> datum_pretraga { get; set; }

        [DataType(DataType.MultilineText)]
        public string zavodni_broj { get; set; }

        [DataType(DataType.MultilineText)]
        public string mesto { get; set; }

        [DataType(DataType.MultilineText)]
        public string na_osnovu { get; set; }
    
        public virtual ICollection<Izmene_DnReda> Izmene_DnReda { get; set; }
        public virtual KORISNIK KORISNIK { get; set; }
        public virtual ICollection<Mail> Mails { get; set; }
        public virtual ICollection<Pozvani_Korisnici> Pozvani_Korisnici { get; set; }
        public virtual SUBJEKAT SUBJEKAT1 { get; set; }
        public virtual TIP_SEDNICE TIP_SEDNICE1 { get; set; }
        public virtual ICollection<Tacke_Dnevnog_Reda> Tacke_Dnevnog_Reda { get; set; }
        public virtual ICollection<Zapisnik> Zapisniks { get; set; }
    }
}