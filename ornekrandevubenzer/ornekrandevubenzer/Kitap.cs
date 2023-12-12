using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekrandevubenzer
{
    internal class Kitap
    {
        int id;
        string kitapAdi;
        string yazar;
        int sayfaSayisi;
        string tur;
        bool cilt;
        DateTime basimTarih;

       

        public int Id { get => id; set => id = value; }
        public string KitapAdı { get => kitapAdi; set => kitapAdi = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public int SayfaSayisi { get => sayfaSayisi; set => sayfaSayisi = value; }
        public string Tur { get => tur; set => tur = value; }
        public bool Cilt { get => cilt; set => cilt = value; }
        public DateTime BasimTarih { get => basimTarih; set => basimTarih = value; }

        public Kitap(int id, string kitapAdı, string yazar, int sayfaSayisi, string tur, bool cilt, DateTime basimTarih)
        {
            this.id = id;
            this.kitapAdi = kitapAdı;
            this.yazar = yazar;
            this.sayfaSayisi = sayfaSayisi;
            this.tur = tur;
            this.cilt = cilt;
            this.basimTarih = basimTarih;
        }
    }
}
