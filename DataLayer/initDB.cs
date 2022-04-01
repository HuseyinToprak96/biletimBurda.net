using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace DataLayer
{
   public class initDB:DropCreateDatabaseAlways<Context>
    {
        
        protected override void Seed(Context context)
        {
            context.KoltukTipleri.Add(new KoltukTipi { SagKoltuk = 2, SolKoltuk = 2, KoltukTipiAdi="2+2"});
            context.KoltukTipleri.Add(new KoltukTipi { SagKoltuk = 1, SolKoltuk = 2, KoltukTipiAdi = "1+2" });
            context.SaveChanges();
            context.Otobusler.Add(new Otobus { Plaka = "41 H 4125", SuanKiDurumu="Yolda", Marka="Mercedes", Model="Y", KoltukSayisi = 40, KoltukTipiId = 1 });
            context.Otobusler.Add(new Otobus { Plaka = "41 T 1225", Marka="BMW", Model="X", KoltukSayisi = 30, KoltukTipiId = 2 });
            context.SaveChanges();
            context.Sehirler.Add(new Sehir { SehirAdi = "Kocaeli" });
            context.Sehirler.Add(new Sehir { SehirAdi = "Karabük" });
            context.SaveChanges();
            context.Ilceler.Add(new Ilce { SehirId = 1, IlceAdi = "Gebze" });
            context.Ilceler.Add(new Ilce { SehirId = 2, IlceAdi = "Safranbolu" });
            context.SaveChanges();
            context.Uyeler.Add(new Uye { UyeAdi = "Mert", Soyad = "Dönmez", IlceId=1,SehirId=1, Telefon = 53146, Sifre="a1", Eposta = "mert@hotmail.com",Yetki=false });
            context.Uyeler.Add(new Uye { UyeAdi = "Mert", Soyad = "Dönmez", IlceId = 1, SehirId = 1, Telefon = 53146, Sifre = "a11", Eposta = "mert1@hotmail.com", Yetki = true });
            context.SaveChanges();
            context.Duraklar.Add(new Durak { IlceId = 1, DurakAdi = "Gebze Terminal" });
            context.Duraklar.Add(new Durak { IlceId = 2, DurakAdi = "Safranbolu Terminali" });
            context.SaveChanges();
            context.Seferler.Add(new Sefer { OtobusId = 1, neredenId = 1, nereyeId = 2, Saat = "12:00", Tarih = "29/03/2022" });

            context.Seferler.Add(new Sefer { OtobusId = 2, neredenId = 1, nereyeId = 2, Saat = "15:00", Tarih = "29/03/2022" });
            context.SaveChanges();
            for (int i = 1; i <=40; i++)
            {
                context.Biletler.Add(new Bilet { SeferId = 1, KoltukNumarasi = i });
            }
            for (int i = 1; i <= 30; i++)
            {
                context.Biletler.Add(new Bilet { SeferId = 2, KoltukNumarasi = i});
            }
            context.SaveChanges();
        }
    }
}
