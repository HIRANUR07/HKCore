using MySql.Data.MySqlClient;
using System;

namespace ikYonetimNYPProjesi.DAL
{
    public class SifreDeposu
    {
        private readonly baglantiGetir _baglanti = new baglantiGetir();

        public string? PersonelinSifresiniGetir(int personelId)
        {
            using MySqlConnection conn = _baglanti.BaglantiGetir();
            using MySqlCommand cmd = new MySqlCommand(
                "SELECT parola FROM kullanici WHERE personel_id=@pid LIMIT 1", conn);
            cmd.Parameters.AddWithValue("@pid", personelId);

            object sonuc = cmd.ExecuteScalar();
            return sonuc == null ? null : sonuc.ToString();
        }

        public void PersonelinSifresiniGuncelle(int personelId, string yeniSifre)
        {
            using MySqlConnection conn = _baglanti.BaglantiGetir();
            using MySqlCommand cmd = new MySqlCommand(
                "UPDATE kullanici SET parola=@s WHERE personel_id=@pid", conn);
            cmd.Parameters.AddWithValue("@s", yeniSifre);
            cmd.Parameters.AddWithValue("@pid", personelId);

            int etkilenen = cmd.ExecuteNonQuery();
            if (etkilenen <= 0)
                throw new Exception("Şifre güncellenemedi.");
        }
    }
}
