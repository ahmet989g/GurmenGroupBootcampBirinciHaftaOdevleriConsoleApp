using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class ArabayiCalistir
    {
        private readonly Debriyaj _debriyaj;
        private readonly Vites _vites;
        private readonly Kontak _kontak;
        private readonly Fren _fren;
        private readonly ElFreni _elFreni;
        private readonly DebriyajGazIliskisi _debriyajGazIliskisi;

        public ArabayiCalistir()
        {
            _debriyaj = new Debriyaj();
            _vites = new Vites();
            _kontak = new Kontak();
            _fren = new Fren();
            _elFreni = new ElFreni();
            _debriyajGazIliskisi = new DebriyajGazIliskisi();
        }

        public void Calistir()
        {
            _debriyaj.Bas();
            _vites.BosaAl();
            _kontak.Cevir();
            _fren.Bas();
            _elFreni.Indir();
            _vites.Vites1();
            _fren.Kaldir();
            _debriyajGazIliskisi.DebriyajdanKaldirGazaBas();
        }
    }
}
