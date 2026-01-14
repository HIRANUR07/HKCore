using ikYonetimNYPProjesi.DAL;
using ikYonetimNYPProjesi.ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ikYonetimNYPProjesi.BLL
{
    public class PersonelYoneticisi
    {
        private readonly PersonelDeposu _personelDeposu = new PersonelDeposu();
        private readonly KullaniciDeposu _kullaniciDeposu = new KullaniciDeposu();
        private readonly baglantiGetir _baglanti = new baglantiGetir();

        public List<Personel> TumPersonelleriGetir()
        {
            return _personelDeposu.TumPersoneller();
        }

        public Personel PersonelGetir(int personelId)
        {
            if (personelId <= 0)
                return null;

            return _personelDeposu.PersonelGetir(personelId);
        }

        public void PersonelEkle(Personel p)
        {
            Validate(p);
            _personelDeposu.PersonelEkle(p);
        }

        public void PersonelGuncelle(Personel p)
        {
            if (p == null || p.Id <= 0)
                throw new Exception("Güncellenecek personeli seç.");

            Validate(p);
            _personelDeposu.PersonelGuncelle(p);
        }

        public void PersonelSil(int id)
        {
            if (id <= 0)
                throw new Exception("Silinecek personeli seç.");

            _personelDeposu.PersonelSil(id);
        }

        private void Validate(Personel p)
        {
            if (p == null)
                throw new Exception("Personel bilgisi boş olamaz.");

            if (string.IsNullOrWhiteSpace(p.Ad))
                throw new Exception("Ad boş olamaz.");

            if (string.IsNullOrWhiteSpace(p.Soyad))
                throw new Exception("Soyad boş olamaz.");

            if (string.IsNullOrWhiteSpace(p.Departman))
                throw new Exception("Departman boş olamaz.");

            if (string.IsNullOrWhiteSpace(p.Pozisyon))
                throw new Exception("Pozisyon boş olamaz.");
        }

        public void PersonelVeKullaniciEkle(Personel p, string kullanici_adi, string rol)
        {
            Validate(p);

            if (string.IsNullOrWhiteSpace(kullanici_adi))
                throw new Exception("Kullanıcı Adı boş olamaz.");

            if (string.IsNullOrWhiteSpace(rol))
                throw new Exception("Rol seçilmelidir.");

            kullanici_adi = kullanici_adi.Trim();
            rol = rol.Trim();

            using (MySqlConnection conn = _baglanti.BaglantiGetir())
            using (MySqlTransaction tx = conn.BeginTransaction()) //Transaction yönetimi için connection BLL seviyesinde kontrol edilmektedir

            {
                try
                {
                    // 1) kullanıcı adı kontrol
                    if (_kullaniciDeposu.KullaniciAdiVarMi(kullanici_adi, conn, tx))
                        throw new Exception("Bu kullanıcı adı zaten kayıtlı.");

                    // 2) personel ekle ve ID al
                    int personelId = _personelDeposu.PersonelEkleVeIdDondur(p, conn, tx);

                    // 3) kullanıcı ekle
                    Kullanici k = new Kullanici
                    {
                        PersonelId = personelId,
                        KullaniciAdi = kullanici_adi,
                        Parola = "1234", // İlk Giriş için parola sonra değişecek.
                        Rol = rol,
                        Aktif = true
                    };

                    _kullaniciDeposu.KullaniciEkle(k, conn, tx);

                    tx.Commit();
                }
                catch
                {
                    try { tx.Rollback(); } catch { }
                    throw;
                }
            }
        }
        public void PersonelAktiflikDegistir(int personelId, bool aktif)
        {
            if (personelId <= 0)
                throw new Exception("Geçerli bir personel seçilmedi.");

            _personelDeposu.PersonelAktiflikGuncelle(personelId, aktif);
        }
        public List<Personel> AktifPersonelleriGetir()
        {
            return _personelDeposu.AktifPersonelleriGetir();
        }
    }


}
