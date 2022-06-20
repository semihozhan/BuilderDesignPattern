using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public class Mesaj
    {
        public string MesajBaslik { get; set; }
        public string MesajIcerik { get; set; }
        public string MesajImza { get; set; }

        private MesajTipi _mesajTipi;

        public Mesaj(MesajTipi mesajTipi)
        {
            _mesajTipi = mesajTipi;
        }

        public void Goster()
        {
            Console.WriteLine(MesajBaslik);
            Console.WriteLine(MesajIcerik);
            Console.WriteLine(MesajImza);
        }

    }
}
