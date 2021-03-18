using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Knjiga
    {
        int id_knjiga;
        string naziv;
        string autor;
        int cena;
        int popust;
        int id_kategorija;
        string autornaziv;

        public Knjiga() { }
        public Knjiga(int id_knjiga, string naziv, string autor, int cena,int popust, int id_kategorija)
        {
            this.Id_knjiga = id_knjiga;
            this.Naziv = naziv;
            this.Autor = autor;
            this.Cena = cena;
            this.Id_kategorija = id_kategorija;
        }
        public int Popust { get => popust; set => popust = value; }
        public int Id_knjiga { get => id_knjiga; set => id_knjiga = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Cena { get => cena; set => cena = value; }
        public int Id_kategorija { get => id_kategorija; set => id_kategorija = value; }

        public string AutorNaziv {
            get => naziv + " " + autor;
         
            set => autornaziv = value;
        }
    }




    public class Kategorija
    {
        int id_kategorije;
        string naziv;
        public Kategorija() { }
        public Kategorija(int id_kategorije, string naziv)
        {
            this.Id_kategorije = id_kategorije;
            this.Naziv = naziv;
        }

        public int Id_kategorije { get => id_kategorije; set => id_kategorije = value; }
        public string Naziv { get => naziv; set => naziv = value; }
    }




    public class Racun {

        int id_racun;
        int cena;
        DateTime datum;
        string vreme;
        public Racun() { }

        public Racun(int id_racun, int cena, DateTime datum, string vreme)
        {
            this.id_racun = id_racun;
            this.cena = cena;
            this.datum = datum;
            this.vreme = vreme;
        }
        public Racun(int cena, DateTime datum, string vreme) {
            this.cena = cena;
            this.datum = datum;
            this.vreme = vreme;
        }
        public  string ToString()
        {
            return $"{Cena},{Datum},{Vreme}";
        }
        
        public int Id_racun { get => id_racun; set => id_racun = value; }
        public int Cena { get => cena; set => cena = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Vreme { get => vreme; set => vreme = value; }
    }



}
