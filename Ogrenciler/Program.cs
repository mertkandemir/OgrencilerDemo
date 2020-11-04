using Ogrenciler.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenciler
{
    class Program
    {
        static void Main(string[] args)
        {
            HafizaIslemleri hafizaIslemleri = new HafizaIslemleri();
            List<Ogrenci> ogrenciListesi = hafizaIslemleri.ListeyiGetir();

            OgrenciServis ogrenciServis = new OgrenciServis();
            ogrenciServis.Goster(ogrenciListesi);

            // Kullanıcıdan Yeni Öğrenci Kaydı Alımı

            Console.Write("\n" + "İyi = 3, Orta = 2, Kötü = 1, Belirsiz = 0" + "\n");
            Console.Write("Yeni Öğrenci Adı: ");
            string yeniOgrenciAdi = Console.ReadLine();
            Console.Write("Yeni Öğrenci Soyadı: ");
            string yeniOgrenciSoyadi = Console.ReadLine();
            Console.Write("Yeni Öğrenci Counter Strike Seviyesi: ");
            int yeniogrenciCsSeviye = Convert.ToInt32(Console.ReadLine());

            // Listeye Ekleme İşlemi

            Ogrenci yeniOgrenci = new Ogrenci()
            {
                Adi = yeniOgrenciAdi,
                Soyadi = yeniOgrenciSoyadi,
                CsSeviye = (CsSeviyeEnum)yeniogrenciCsSeviye
            };

            ogrenciServis.Ekle(yeniOgrenci, ogrenciListesi);
            ogrenciServis.Goster(ogrenciListesi);

            Console.ReadLine();
        }
    }
}
