using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP
{
    class Koer : Koduloom
    {
        public enum toug { Pitbull, Korgi, sobaka, mastif};
        public toug Toug;
        public Koer(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = Toug;
        }
        public Koer(Koer koer)//kloonimiseks
        {
            this.Toug = koer.Toug;
            this.nimi = koer.nimi;
            this.varv = koer.varv;
            this.loomaSugu = koer.loomaSugu;
            this.kaal = koer.kaal;
            this.vanus = koer.vanus;
            this.elav = koer.elav;
        }

        public override void print_Haal()
        {
            Console.WriteLine("Auf");
        }

        public override void print_Info()
        {
            Console.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} kg. ja ta on {5} aastat vana", Toug, varv, nimi, loomaSugu, kaal, vanus);
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaKaal(int uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
    }
}
