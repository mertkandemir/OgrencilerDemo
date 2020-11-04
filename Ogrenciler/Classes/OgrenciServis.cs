using System;
using System.Collections.Generic;
using System.Linq;

namespace Ogrenciler.Classes
{
    class OgrenciServis
    {
        public void Goster(List<Ogrenci> ogrenciler)
        {
            Console.WriteLine("\n" + "--- Öğrenci Listesi ---" + "\n");
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci.Id + " - " + ogrenci.Adi + " " + ogrenci.Soyadi + " - " + ogrenci.CsSeviye);
            }
        }

        public void Ekle(Ogrenci ogrenci, List<Ogrenci> ogrenciler)
        {
            List<int> Idler = new List<int>();
            foreach (var o in ogrenciler)
            {
                Idler.Add(o.Id);
            }

            int yeniId = Idler.Max();
            ogrenci.Id = yeniId + 1;
            ogrenciler.Add(ogrenci);
        }
    }
}
