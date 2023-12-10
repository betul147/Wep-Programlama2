using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    // naming conversation = isimlendirme kuralı
    //syntax = yazım şekilleri
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string acıklama,double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }






}
