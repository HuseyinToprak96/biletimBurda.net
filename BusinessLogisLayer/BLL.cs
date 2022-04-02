using BusinessLogisLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using System.Web.Mvc;
namespace BusinessLogisLayer
{
    public class BLL
    {
        Context db;
        public BLL()
        {
            db = new Context();
        }
       public VMOtobusEkle OtobusEkleme()
        {
            VMOtobusEkle otobusEkle = new VMOtobusEkle();
            otobusEkle.KoltukTipleri = new SelectList(db.KoltukTipleri, "KoltukTipiId", "KoltukTipiAdi");
            return otobusEkle;
        }
        public VMDurakEkle durakEkle()
        {
            VMDurakEkle ekle = new VMDurakEkle();
            ekle.Ilceler = new SelectList(db.Ilceler.OrderBy(i => i.IlceAdi), "IlceId", "IlceAdi");
            return ekle;
        }
        public VMUyeOl UyeOl()
        {
            VMUyeOl uyeOl = new VMUyeOl();
            uyeOl.Sehirler = new SelectList(db.Sehirler.OrderBy(s => s.SehirAdi), "SehirId", "SehirAdi");
            return uyeOl;
        }
        public Uye Giris(string mail, string sifre)
        {
            var uye = db.Uyeler.Where(u => u.Eposta == mail && u.Sifre == sifre).SingleOrDefault();
            if (uye != null)
                return uye;
            return null;
        }
       public VMseferEkle seferEkle()
        {
            VMseferEkle ekle = new VMseferEkle();
            ekle.Rotalar = new SelectList(db.Rotalar,"RotaId","RotaId");
            ekle.Otobusler = new SelectList(db.Otobusler, "OtobusId","Plaka");
            ekle.sefer = new Sefer();
            return ekle;
        }
        public VMseferAra seferAra()
        {
            VMseferAra ara = new VMseferAra();
            ara.Nereden = new SelectList(db.Duraklar.OrderBy(d => d.DurakAdi), "DurakId", "DurakAdi");
            ara.Nereye = new SelectList(db.Duraklar.OrderBy(d => d.DurakAdi), "DurakId", "DurakAdi");
            return ara;
        }
        public VM_SeferUye seferBul(VMseferAra ara)
        {
            VM_SeferUye seferUye = new VM_SeferUye();
            seferUye.Seferler = db.Seferler.Where(x => x.rota.NeredenId == ara.sefer.rota.NeredenId && x.rota.NereyeId == ara.sefer.rota.NereyeId).ToList();
            seferUye.biletler = db.Biletler.ToList();
            seferUye.bilet= new Bilet();
            seferUye.bilet.KoltukNumarasi = 0;
            return seferUye;
        }
        public void BiletEkle(Sefer sefer)
        {
            var otobus = db.Otobusler.Where(o => o.OtobusId == sefer.OtobusId).SingleOrDefault();
            for (int i = 1; i <=otobus.KoltukSayisi ; i++)
            db.Biletler.Add(new Bilet { KoltukNumarasi = i, SeferId = sefer.SeferId });
            db.SaveChanges();
        
        }
        public void BiletAl(int seferID,int koltuk,int uyeID)
        {
          var bilet=  db.Biletler.Where(b =>b.SeferId == seferID&&b.KoltukNumarasi==koltuk).SingleOrDefault();
            bilet.UyeId = uyeID;
            db.SaveChanges();
        }
        public VMRotaEkle RotaEkle()
        {
            VMRotaEkle vMRotaEkle = new VMRotaEkle();
            vMRotaEkle.Duraklar = new SelectList(db.Duraklar, "DurakId", "DurakAdi");
            return vMRotaEkle;
        }
    }
}
