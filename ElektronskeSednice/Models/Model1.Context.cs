﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class E_Sednice_Indjija_newEntities1 : DbContext
    {
        public E_Sednice_Indjija_newEntities1()
            : base("name=E_Sednice_Indjija_newEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Amandman> Amandmen { get; set; }
        public virtual DbSet<AmandmanDok_pomocna> AmandmanDok_pomocna { get; set; }
        public virtual DbSet<Amandmani_pomocna> Amandmani_pomocna { get; set; }
        public virtual DbSet<DOKUMENTA> DOKUMENTAs { get; set; }
        public virtual DbSet<Dokumenta_Subjekat> Dokumenta_Subjekat { get; set; }
        public virtual DbSet<Hitan_Postupak> Hitan_Postupak { get; set; }
        public virtual DbSet<Izmene_DnReda> Izmene_DnReda { get; set; }
        public virtual DbSet<Klase_dnevnog_reda> Klase_dnevnog_reda { get; set; }
        public virtual DbSet<Komentar> Komentars { get; set; }
        public virtual DbSet<Komentar_Tacka> Komentar_Tacka { get; set; }
        public virtual DbSet<KORISNIK> KORISNIKs { get; set; }
        public virtual DbSet<KORISNIK_SUBJEKAT> KORISNIK_SUBJEKAT { get; set; }
        public virtual DbSet<Logovi> Logovis { get; set; }
        public virtual DbSet<Mail> Mails { get; set; }
        public virtual DbSet<Masovna> Masovnas { get; set; }
        public virtual DbSet<Masovna_poruka> Masovna_poruka { get; set; }
        public virtual DbSet<MasovniMail> MasovniMails { get; set; }
        public virtual DbSet<MasovniMail_Poruka> MasovniMail_Poruka { get; set; }
        public virtual DbSet<Poruke> Porukes { get; set; }
        public virtual DbSet<Pozvani_Korisnici> Pozvani_Korisnici { get; set; }
        public virtual DbSet<Pristup_Korisnik> Pristup_Korisnik { get; set; }
        public virtual DbSet<SEDNICE> SEDNICEs { get; set; }
        public virtual DbSet<STATUS_AKATA> STATUS_AKATA { get; set; }
        public virtual DbSet<Status_dokumenta> Status_dokumenta { get; set; }
        public virtual DbSet<SUBJEKAT> SUBJEKATs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tacke_Dnevnog_Reda> Tacke_Dnevnog_Reda { get; set; }
        public virtual DbSet<TIP_SEDNICE> TIP_SEDNICE { get; set; }
        public virtual DbSet<ZakljucakAmandman> ZakljucakAmandmen { get; set; }
        public virtual DbSet<Zapisnik> Zapisniks { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
    }
}
