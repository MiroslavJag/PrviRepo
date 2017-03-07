using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojPjesama = Funkcije.UnosInt("Koliko pjesama se nalazi na Cd-u?");
            string[] nizPjesama = new string[brojPjesama];
            for (int i = 0; i < brojPjesama; i++)
            {
                nizPjesama[i] = Funkcije.UnosTekst("Unesite podatke o " + (i+1) + ". pjesmi");
            }

            int pocetnoStanje = Funkcije.UnosInt("Pocetno stanje muzicke linije (0-Stop, 1-Play)");

            if (pocetnoStanje == 1)
            {
                int brojPjesme = Funkcije.UnosInt("Prva pjesma (broj pjesme od koje zlite da lista krene)");
                MuzickaLinija muzickaLinija = new MuzickaLinija(nizPjesama, brojPjesme -1, pocetnoStanje);

                muzickaLinija++;
                muzickaLinija++;
                //muzickaLinija.BrPjesme += 2;

                muzickaLinija--;

                Funkcije.Ispis("\n" +muzickaLinija.Display() + "\n");

                MuzickaLinija linija2 = new MuzickaLinija(muzickaLinija.Pjesme, muzickaLinija.BrPjesme, muzickaLinija.Stanje);
                linija2.UkupanBrojPjesama -= 2;

                if (muzickaLinija > linija2)
                {
                    Funkcije.Ispis("\nLinija 1 ima vise pjesama.\n");

                }
                else {
                    Funkcije.Ispis("Linija 2 ima vise pjesama.\n");
                }

                linija2.NizPjesama();
                linija2.NizPjesama("Opila me tvoja ljepota");

            }

            Funkcije.Stop();


        }
    }
}
