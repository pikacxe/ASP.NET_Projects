using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Osoba
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Struka { get; set; }
        public Osoba(int iD, string ime, string prezime, string struka)
        {
            ID = iD;
            Ime = ime;
            Prezime = prezime;
            Struka = struka;
        }
        public Osoba()
        {
            ID = 0;
            Ime = null;
            Prezime = null;
            Struka = null;
        }
    }
}