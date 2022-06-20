using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    internal class DogumGunuMesaj : MesajBuilder
    {
        public DogumGunuMesaj() : base(MesajTipi.DogumGunu)
        {
        }

        public override void MesajBasligiOlustur()
        {
            this.Mesaj.MesajBaslik = "Nice Yıllara";
        }

        public override void MesajIcerigiOlustur()
        {
            this.Mesaj.MesajIcerik = "Doğum Gününüz Kutlu Olsun";
        }

        public override void MesajImzaOlustur()
        {
            this.Mesaj.MesajImza = "Sn...";
        }
    }
}
