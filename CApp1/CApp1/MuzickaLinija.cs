using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp1
{
    public class MuzickaLinija
    {
        private int ukupanBrojPjesama;

        public int UkupanBrojPjesama {
            get { return ukupanBrojPjesama; }
            set { ukupanBrojPjesama = value; }
        }

        private int brPjesme;
        
        public int BrPjesme
        {
            get { return brPjesme; }
            set {
                if (value > 0 && value < UkupanBrojPjesama) {
                    brPjesme = value;
                }
            }
        }

        private int stanje;
        public int Stanje
        {
            get { return stanje; }
            set { stanje = value; }
        }

        private string[] pjesme;

        public int TrenutnoStanjeMuzickeLinije
        {
            get
            {
                return stanje;
            }
        }

        public string[] Pjesme
        {
            get { return pjesme; }
            set {
                if (value.Length <= 100)
                {
                    pjesme = value;
                }
              }

        }

        public MuzickaLinija(string[] nizPjesmi)
        {
            UkupanBrojPjesama = nizPjesmi.Length;
            BrPjesme = 0;
            Stanje = StanjeEnum.Play.ID;
            Pjesme = nizPjesmi;
            
        }

        public MuzickaLinija(string[] nizPjesmi, int pocetnaPjesma, int pocetnoStanje)
        {
            Pjesme = nizPjesmi;
            UkupanBrojPjesama = nizPjesmi.Length;
            BrPjesme = pocetnaPjesma;
            Stanje = pocetnoStanje;
            

        }

        public MuzickaLinija(string[] nizPjesmi, int pocetnaPjesma, StanjeEnum pocetnoStanje)
        {
            Pjesme = nizPjesmi;
            UkupanBrojPjesama = nizPjesmi.Length;
            BrPjesme = pocetnaPjesma;
            Stanje = pocetnoStanje.ID;
            

        }

        public string Display() {

            string ispis = "";
            if (Stanje == 0)
            {
                ispis = "Play";
            }
            else if (Stanje == 1)
            {
                ispis = "Play";
            }
            else if (Stanje == 2)
            {
                ispis = "Play";
            }
            else if (Stanje == 3)
            {
                ispis = "Play";
            }
            else if (Stanje == 4)
            {
                ispis = "Play";
            }

            ispis += (this.brPjesme + 1) + "." + Pjesme[this.brPjesme];

            return ispis;

        }

        public void Stop()
        {
            Stanje = StanjeEnum.Stop.ID;
            BrPjesme = 0;
        }

        public string this[int index]
        {
            get
            {
                return pjesme[index];
            }
        }

        public static MuzickaLinija operator ++(MuzickaLinija mz)
        {
            mz.brPjesme += 2;
            return mz;
        }

        public static MuzickaLinija operator --(MuzickaLinija mz)
        {
            mz.brPjesme -= 3;
            return mz;
        }

        public static bool operator >(MuzickaLinija linija1, MuzickaLinija linija2)
        {
            if (linija1.UkupanBrojPjesama > linija2.UkupanBrojPjesama) {
                return true;
            }
            return false;
        }

        public static bool operator <(MuzickaLinija linija1, MuzickaLinija linija2)
        {
            if (linija1.UkupanBrojPjesama < linija2.UkupanBrojPjesama)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(MuzickaLinija linija1, MuzickaLinija linija2)
        {
            if (linija1.UkupanBrojPjesama != linija2.UkupanBrojPjesama)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(MuzickaLinija linija1, MuzickaLinija linija2)
        {
            if (linija1.UkupanBrojPjesama == linija2.UkupanBrojPjesama)
            {
                return true;
            }
            return false;
        }

    }
}
