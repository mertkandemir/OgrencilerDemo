using System.Collections.Generic;

namespace Ogrenciler.Classes
{
    class HafizaIslemleri
    {
        public List<Ogrenci> ListeyiGetir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    Id = 1,
                    Adi = "Yiğit",
                    Soyadi = "Memeci",
                    CsSeviye = CsSeviyeEnum.İyi
                },
                new Ogrenci()
                {
                    Id = 2,
                    Adi = "Bartu",
                    Soyadi = "Ünal",
                    CsSeviye = CsSeviyeEnum.Orta
                },
                new Ogrenci()
                {
                    Id = 3,
                    Adi = "Mert",
                    Soyadi = "Kandemir",
                    CsSeviye = CsSeviyeEnum.Belirsiz
                },
                new Ogrenci()
                {
                    Id = 4,
                    Adi = "Emre",
                    Soyadi = "Koç",
                    CsSeviye = CsSeviyeEnum.Kötü
                },
                new Ogrenci()
                {
                    Id = 5,
                    Adi = "Öztan",
                    Soyadi = "Özbağcı",
                    CsSeviye = CsSeviyeEnum.İyi
                }
            };
            return ogrenciler;
        }
    }
}
