using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    internal class MesajUret
    {
        private MesajBuilder _builder;

        public void Uret(MesajBuilder mesajBuilder)
        {
            _builder = mesajBuilder;
            _builder.MesajBasligiOlustur();
            _builder.MesajIcerigiOlustur();
            _builder.MesajImzaOlustur();
        }

        public void Goster()
        {
            _builder.Mesaj.Goster();
        }
    }
}
