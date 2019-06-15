using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_control
{
    class Transport{
        public Transport(int wys, char kier, int v, char miasto_wylotu, char miasto_przylotu){
            wysokosc = wys;
            kierunek = kier;
            predkosc = v;
            trasa[0] = miasto_wylotu;
            trasa[1] = miasto_przylotu;
        }

        protected int wysokosc;
        protected char kierunek;
        protected int predkosc;
        protected char[] trasa = new char[2];

        public void zmien_trase(char nowy_cel) => trasa[1] = nowy_cel;

    }

    class Samolot : Transport {
        public Samolot(string symbol, int wys, char kier, int v, char miasto_wylotu, char miasto_przylotu) : base(wys, kier, v, miasto_wylotu, miasto_przylotu) {
            this.symbol = symbol;
        }
        private string symbol;
        //private string nazwa; nie wiem czy potrzebne
    }

    class Smiglowiec : Transport {
        public Smiglowiec(string symbol, int wys, char kier, int v, char miasto_wylotu, char miasto_przylotu) : base(wys, kier, v, miasto_wylotu, miasto_przylotu) {
            this.symbol = symbol;
        }
        private string symbol;
    }
    class Balon : Transport {
        public Balon(string symbol, int wys, char kier, int v, char miasto_wylotu, char miasto_przylotu) : base(wys, kier, v, miasto_wylotu, miasto_przylotu) {
            this.symbol = symbol;
        }
        private string symbol;
    }
     class Szybowiec : Transport {
        public Szybowiec(string symbol, int wys, char kier, int v, char miasto_wylotu, char miasto_przylotu) : base(wys, kier, v, miasto_wylotu, miasto_przylotu) {
            this.symbol = symbol;
        }
        private string symbol;
      }
}
