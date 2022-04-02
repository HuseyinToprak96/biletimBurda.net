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
            context.Otobusler.Add(new Otobus { Plaka = "41 H 4125", OtobusResmi="/../images/bmw.jpg", SuanKiDurumu="Yolda", Marka="Mercedes", Model="Y", KoltukSayisi = 40, KoltukTipiId = 1 });
            context.Otobusler.Add(new Otobus { Plaka = "41 T 1225", OtobusResmi="/../images/audi.jpg", SuanKiDurumu="", Marka="BMW", Model="X", KoltukSayisi = 30, KoltukTipiId = 2 });
            context.SaveChanges();
            context.Sehirler.Add(new Sehir { SehirAdi = "Kocaeli" });
            context.Sehirler.Add(new Sehir { SehirAdi = "Karabük" });
            context.SaveChanges();
            context.Ilceler.Add(new Ilce { SehirId = 1, IlceAdi = "Gebze" });
            context.Ilceler.Add(new Ilce { SehirId = 2, IlceAdi = "Safranbolu" });
            context.SaveChanges();
            context.Uyeler.Add(new Uye { UyeAdi = "Mert", Soyad = "Dönmez", IlceId=1,SehirId=1, Telefon = 5314612454, Sifre="a1", Eposta = "mert@hotmail.com",Yetki=false });
            context.Uyeler.Add(new Uye { UyeAdi = "Mert", Soyad = "Dönmez", IlceId = 1, SehirId = 1, Telefon = 5314612152, Sifre = "a11", Eposta = "mert1@hotmail.com", Yetki = true });
            context.SaveChanges();
            context.Duraklar.Add(new Durak { IlceId = 1, DurakAdi = "Gebze Terminal" });
            context.Duraklar.Add(new Durak { IlceId = 2, DurakAdi = "Safranbolu Terminali" });
            context.SaveChanges();
            context.Rotalar.Add(new Rota { NeredenId = 1, NereyeId = 2, Ucret = 100 });
            context.Rotalar.Add(new Rota { NeredenId = 2, NereyeId = 1, Ucret = 120 });
            context.SaveChanges();
            Sefer sefer1 = new Sefer { OtobusId = 1, RotaId = 1, Saat = "12:00", Tarih = "29/03/2022" };
            context.Seferler.Add(sefer1);
            Sefer sefer2 = new Sefer { OtobusId = 2, RotaId = 2, Saat = "15:00", Tarih = "29/03/2022" };
            context.Seferler.Add(sefer2);
            context.SaveChanges();
            for (int i = 1; i <=sefer1.otobus.KoltukSayisi; i++)
            {
                context.Biletler.Add(new Bilet { SeferId = 1, KoltukNumarasi = i, Ucret=sefer1.rota.Ucret });
            }
            for (int i = 1; i <= sefer2.otobus.KoltukSayisi; i++)
            {
                context.Biletler.Add(new Bilet { SeferId = 2, KoltukNumarasi = i, UyeId=1, Ucret=sefer2.rota.Ucret});
            }
            context.SaveChanges();
           
        }
    }
}
