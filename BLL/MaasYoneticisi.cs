
using ikYonetimNYPProjesi.DAL;
using ikYonetimNYPProjesi.ENTITY;
using System;
using System.Collections.Generic;

namespace ikYonetimNYPProjesi.BLL
{
    public class MaasYoneticisi
    {
        private readonly MaasDeposu _depo = new MaasDeposu();

        public decimal NetMaasHesapla(decimal brut, decimal prim, decimal mesai, decimal kesintiToplam)
        {
            return brut + prim + mesai - kesintiToplam;
        }

        public void Kaydet(Maas maas)
        {
            if (!OturumYoneticisi.GirisYapildiMi)
                throw new ArgumentException("Oturum bulunamadı. Lütfen tekrar giriş yapın.");

            if (maas.PersonelId <= 0) throw new ArgumentException("Personel seçilmelidir.");
            if (maas.Yil < 2000 || maas.Yil > 2100) throw new ArgumentException("Yıl geçersiz.");
            if (maas.Ay < 1 || maas.Ay > 12) throw new ArgumentException("Ay geçersiz.");

            if (maas.BrutMaas < 0 || maas.Prim < 0 || maas.Mesai < 0 || maas.KesintiToplam < 0)
                throw new ArgumentException("Tutarlar negatif olamaz.");

            maas.NetMaas = NetMaasHesapla(maas.BrutMaas, maas.Prim, maas.Mesai, maas.KesintiToplam);
            if (maas.NetMaas < 0)
                throw new ArgumentException("Net maaş negatif olamaz.");

            // Oturumdan hesaplayan kişi ID'si set edilsin (boşsa)
            if (maas.HesaplayanUserId == null || maas.HesaplayanUserId <= 0)
                maas.HesaplayanUserId = OturumYoneticisi.KullaniciId;



            if (maas.HesaplamaTarihi == default(DateTime))
                maas.HesaplamaTarihi = DateTime.Now;

            _depo.Upsert(maas);
        }

        public List<Maas> PersonelGecmisi(int personelId)
        {
            return _depo.PersonelinMaaslari(personelId);
        }

        public List<Maas> TumKayitlar()
        {
            return _depo.TumMaaslar();
        }

        public void Sil(int maasId)
        {
            if (maasId <= 0) throw new ArgumentException("Silinecek maaş kaydı seçilmedi.");
            _depo.Sil(maasId);
        }

    }
}