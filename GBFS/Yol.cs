using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFS
{
    class Yol
    {
        public Yol() { }
        public Yol(String Baslangic, String Bitis, int Uzaklik)
        {
            this.Baslangic = Baslangic;
            this.Bitis = Bitis;
            this.Uzaklik = Uzaklik;
        }
        public String Baslangic { get; set; }
        public String Bitis { get; set; }
        public int Uzaklik { get; set; }
    }
}
