using ikYonetimNYPProjesi.DAL;
using ikYonetimNYPProjesi.ENTITY;
using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace ikYonetimNYPProjesi.BLL
{
    public static class OturumYoneticisi
    {
        // 🔹 Oturum bilgileri (senin eski kodundan)
       
        public static int KullaniciId { get; private set; }
        public static int PersonelId { get; private set; }
        public static string Rol { get; private set; } = "";
        public static string KullaniciAdi { get; private set; } = "";

        // 🔹 İsteğe bağlı: Login olan kullanıcı nesnesini de tut (pratik olur)
        public static Kullanici CurrentUser { get; private set; }

        // DAL
        private static readonly KullaniciDeposu _kullaniciDeposu = new KullaniciDeposu();

        // ✅ Giriş yapma (senin gönderdiğin kodun email'e uyarlanmış hali)
        public static bool GirisYap(string KullanıcıAdı, string parola, out string hataMesaji)
        {
            hataMesaji = "";

            if (string.IsNullOrWhiteSpace(KullanıcıAdı) || string.IsNullOrWhiteSpace(parola))
            {
                hataMesaji = "Kullanıcı Adı ve parola boş olamaz.";
                return false;
            }

            // DAL: GirisIcinKullaniciGetir(email, parola) -> Users döndürüyor
            var user = _kullaniciDeposu.GirisIcinKullaniciGetir(KullanıcıAdı.Trim(), parola);
            if (user == null)
            {
                hataMesaji = "Hatalı Kullanıcı Adı/parola veya kullanıcı pasif.";
                return false;
            }

            // Oturum başlat (senin eski OturumBaslat'ın yaptığı işi burada yapıyoruz)
            CurrentUser = user;
            KullaniciId = user.Id;
            PersonelId = user.PersonelId ?? 0; // Admin için null olabilir
            Rol = user.Rol ?? "";
            KullaniciAdi = user.KullaniciAdi;


            return true;
        }

        // ✅ Oturumu kapat
        public static void CikisYap()
        {
            CurrentUser = null;
            KullaniciId = 0;
            PersonelId = 0;
            Rol = "";
            KullaniciAdi  = "";
        }

        // ✅ Oturum var mı? (Form açılışlarında çok işe yarar)
        public static bool GirisYapildiMi => KullaniciId > 0;

        // ✅ Rol kontrol yardımcıları (opsiyonel ama çok pratik)
        public static bool YetkiliMi(params string[] roller)
        {
            if (!GirisYapildiMi) return false;
            if (roller == null || roller.Length == 0) return true;

            foreach (var r in roller)
            {
                if (string.Equals(Rol, r, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}