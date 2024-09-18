using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upisivanjapodataka_u_csv
{
    internal class osoba
    {
        string ime, prezime, email;
        int godinaRodjenja;
        public osoba() { }
        public osoba(string ime, string prezime, string email, int godinaRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.godinaRodjenja = godinaRodjenja;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public int GodinaRodjenja { get => godinaRodjenja; set => godinaRodjenja = value; }
    }
}
