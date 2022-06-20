using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    abstract class MesajBuilder
    {
        public abstract void MesajBasligiOlustur();
        public abstract void MesajIcerigiOlustur();
        public abstract void MesajImzaOlustur();

        private Mesaj _mesaj;

        public Mesaj Mesaj { get { return _mesaj; } }

        public MesajBuilder(MesajTipi mesaj)
        {
            _mesaj = new Mesaj(mesaj);
        }
    }
}
