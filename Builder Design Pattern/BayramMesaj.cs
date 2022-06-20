using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    internal class BayramMesaj : MesajBuilder
    {
        public BayramMesaj() : base(MesajTipi.Bayram)
        {
        }

        public override void MesajBasligiOlustur()
        {
            this.Mesaj.MesajBaslik = "Bayram Mesajı";
        }

        public override void MesajIcerigiOlustur()
        {
            this.Mesaj.MesajBaslik = "İyi Bayramlar";
        }

        public override void MesajImzaOlustur()
        {
            this.Mesaj.MesajBaslik = "Sn....";
        }
    }
}
