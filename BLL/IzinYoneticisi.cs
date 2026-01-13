using ikYonetimNYPProjesi.DAL;
using ikYonetimNYPProjesi.ENTITY;
using System;
using System.Collections.Generic;

namespace ikYonetimNYPProjesi.BLL
{
    public class IzinYoneticisi
    {
        private readonly IzinDAL _izinDal = new IzinDAL();
        public List<Izin> TumIzinler()
        {
            return _izinDal.TumIzinleriGetir();
        }

        // ✅ users izin talebi
        public void IzinTalepEt(Izin izin)
        {
            // PersonelId UI'dan gelmesin, oturumdan gelsin
            if (OturumYoneticisi.PersonelId <= 0)
                throw new Exception("Personel bilgisi yok.");

            if (izin.BaslangicTarihi > izin.BitisTarihi)
                throw new Exception("Tarih aralığı hatalı.");

            izin.PersonelId = OturumYoneticisi.PersonelId;

            _izinDal.IzinEkle(izin);
        }

        // ✅ Rol'e göre listeleme
        public List<Izin> Listele()
        {
            // admin + IK: tüm izinleri görür
            if (OturumYoneticisi.Rol == "admin" || OturumYoneticisi.Rol == "IK")
                return _izinDal.TumIzinleriGetir();

            // users: sadece kendi izinleri
            return _izinDal.PersonelIzinleriniGetir(OturumYoneticisi.PersonelId);
        }

        // ✅ Sadece admin onay/red yapar
        public void DurumGuncelle(int izinId, string yeniDurum)
        {
            if (OturumYoneticisi.Rol != "admin")
                throw new Exception("Bu işlem için yetkin yok.");

            _izinDal.IzinDurumGuncelle(izinId, yeniDurum);
        }

        // (Opsiyonel) users için kısayol
        public List<Izin> KendiIzinlerim()
        {
            return _izinDal.PersonelIzinleriniGetir(OturumYoneticisi.PersonelId);
        }
    }
}
