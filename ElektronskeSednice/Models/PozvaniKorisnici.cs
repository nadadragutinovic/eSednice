using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElektronskeSednice.Models
{
    public class PozvaniKorisnici
    {
        public IEnumerable<KORISNIK_SUBJEKAT> Korisnik_Subjekat { get; set; }
        public IEnumerable<Pozvani_Korisnici> Pozvani_Korisnici { get; set; }
    }
}