using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kordamine_OOP.Koduloom;

namespace Kordamine_OOP
{
    class Cats : Koduloom
    {
        public enum toug { cat1, cat2, cat3, cat4, cat5 };
        public toug Toug;


        public Cats(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = Toug;
        }
        public Cats(Cats cats)
        {
            this.Toug = cats.Toug;
            this.nimi = cats.nimi;
            this.varv = cats.varv;
            this.loomaSugu = cats.loomaSugu;
            this.kaal = cats.kaal;
            this.vanus = cats.vanus;
            this.elav = cats.elav;

        }
        public Cats(string nimi,string varv)
        {
            this.nimi=nimi;
            this.varv = varv;
        }
        public override void print_Haal()
        {
            Console.WriteLine("Meow");
        }

        public override void print_Info()
        {
            Console.WriteLine("{0} cats. Nimi: {1} {2} ta on {3} ja tema kaal on {4} kg ja ta on {5} aastat vana", Toug, nimi, varv, loomaSugu, kaal, vanus);
        }

        public void muudatNimi(string uusNimi) { nimi = uusNimi; }
        public void muudatVarv(string uusVarv) { varv = uusVarv; }
        public void muudatKaal(int uusKaal) { kaal = uusKaal; }
        public void muudatVanus(int uusVanus) { vanus = uusVanus; }
    }

}

