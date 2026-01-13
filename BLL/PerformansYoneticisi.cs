using ikYonetimNYPProjesi.DAL;
using ikYonetimNYPProjesi.ENTITY;
using System;
using System.Collections.Generic;

namespace ikYonetimNYPProjesi.BLL
{
    public class PerformansYoneticisi
    {
        private PerformansDeposu _depo = new PerformansDeposu();
        private readonly KullaniciDeposu _kullaniciDeposu = new KullaniciDeposu();


        public void PerformansEkle(Performans p)
        {
            if (p.PersonelId <= 0) throw new Exception("Personel seçilmedi.");
            if (p.DegerlendirenId <= 0) throw new Exception("Değerlendiren bilgisi zorunlu.");
            if (p.Puan < 1 || p.Puan > 100) throw new Exception("Puan 1-100 arasında olmalı.");

            // ✅ 1) Kendi kendini değerlendirme engeli
            if (p.PersonelId == p.DegerlendirenId)
                throw new Exception("Kendi kendini değerlendiremezsiniz.");

            // ✅ 2) IK → Admin/IK değerlendiremesin (IK sadece users değerlendirsin)
            if (string.Equals(OturumYoneticisi.Rol, "IK", StringComparison.OrdinalIgnoreCase))
            {
                var hedefRol = _kullaniciDeposu.PersonelinRolunuGetir(p.PersonelId);

                // Kullanıcı kaydı yoksa, normal personel gibi davran (users kabul et)
                if (string.IsNullOrWhiteSpace(hedefRol))
                    hedefRol = "users";

                if (!string.Equals(hedefRol, "users", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("İK yalnızca normal kullanıcıları (users) değerlendirebilir.");

            }
           
            _depo.PerformansEkle(p);
        }


        public void PerformansGuncelle(Performans p)
        {
            if (p.Id <= 0) throw new Exception("Geçersiz kayıt.");
            if (p.PersonelId <= 0) throw new Exception("Personel seçilmedi.");
            if (p.DegerlendirenId <= 0) throw new Exception("Değerlendiren bilgisi zorunlu.");
            if (p.Puan < 1 || p.Puan > 100) throw new Exception("Puan 1-100 arasında olmalı.");

            // ✅ 1) Kendi kendini değerlendirme engeli
            if (p.PersonelId == p.DegerlendirenId)
                throw new Exception("Kendi kendini değerlendiremezsiniz.");

            // ✅ 2) IK → Admin/IK değerlendiremesin
            if (string.Equals(OturumYoneticisi.Rol, "IK", StringComparison.OrdinalIgnoreCase))
            {
                var hedefRol = _kullaniciDeposu.PersonelinRolunuGetir(p.PersonelId);

                if (string.IsNullOrWhiteSpace(hedefRol))
                    throw new Exception("Seçilen personelin rol bilgisi bulunamadı. (kullanici.personel_id eşleşmesi yok)");

                if (!string.Equals(hedefRol, "users", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("İK yalnızca normal kullanıcıları (users) değerlendirebilir.");
            }

            _depo.PerformansGuncelle(p);
        }


        public List<Performans> TumPerformanslar()
            => _depo.TumPerformanslariGetir();

        public List<Performans> PersonelinPerformanslari(int personelId)
            => _depo.PersonelinPerformanslariniGetir(personelId);

       public void PerformansPasifeAl(int performansId)
        {
            if (performansId <= 0)
                throw new Exception("Geçersiz kayıt.");

            var kayit = _depo.PerformansGetirById(performansId); // bunu ekle/varsa kullan
            if (kayit == null)
                throw new Exception("Kayıt bulunamadı.");

            // Yetki: sadece kendi yazdığı değerlendirmeyi silebilir
            if (kayit.DegerlendirenId != OturumYoneticisi.PersonelId)
                throw new Exception("Bu performansı silemezsiniz. Sadece değerlendirmeyi yapan kişi silebilir.");

            _depo.PerformansPasifeAl(performansId);
        }


        public void PerformansAktifeAl(int id)
        {
            if (id <= 0) throw new Exception("Geçersiz kayıt.");
            _depo.PerformansAktifeAl(id);
        }

    }
}