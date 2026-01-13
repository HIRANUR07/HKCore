using MySql.Data.MySqlClient;
using ikYonetimNYPProjesi.ENTITY;

namespace ikYonetimNYPProjesi.DAL
{
    public class KullaniciDeposu
    {
        public Kullanici? GirisIcinKullaniciGetir(string kullaniciAdi, string parola)
        {
            var b = new baglantiGetir();
            using var conn = b.BaglantiGetir(); // Zaten Open() yapıyor

            const string sql = @"
                SELECT id, kullanici_adi, parola, rol, aktif, personel_id
                FROM kullanici
                WHERE kullanici_adi = @kadi AND parola = @parola AND aktif = 1
                LIMIT 1;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@parola", parola);

            using var dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;

            return new Kullanici
            {
                Id = dr.GetInt32("id"),
                KullaniciAdi = dr.GetString("kullanici_adi"),
                Parola = dr.GetString("parola"),
                Rol = dr.GetString("rol"),
                Aktif = dr.GetInt32("aktif") == 1,
                PersonelId = dr.IsDBNull(dr.GetOrdinal("personel_id")) ? (int?)null : dr.GetInt32("personel_id")
            };
        }
        public string? PersonelinRolunuGetir(int personelId)
        {
            var b = new baglantiGetir();
            using var conn = b.BaglantiGetir();

            const string sql = @"
        SELECT rol
        FROM kullanici
        WHERE personel_id = @pid AND aktif = 1
        LIMIT 1;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pid", personelId);

            var result = cmd.ExecuteScalar();
            return result == null ? null : result.ToString();
        }
        public bool KullaniciAdiVarMi(string kullaniciAdi, MySqlConnection conn, MySqlTransaction tx)
        {
            const string sql = @"SELECT COUNT(1) FROM kullanici WHERE kullanici_adi = @kadi;";
            using var cmd = new MySqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public void KullaniciEkle(Kullanici k, MySqlConnection conn, MySqlTransaction tx)
        {
            const string sql = @"
                INSERT INTO kullanici (kullanici_adi, parola, rol, aktif, personel_id)
                VALUES (@kadi, @parola, @rol, @aktif, @pid);";

            using var cmd = new MySqlCommand(sql, conn, tx);
            cmd.Parameters.AddWithValue("@kadi", k.KullaniciAdi);
            cmd.Parameters.AddWithValue("@parola", k.Parola);
            cmd.Parameters.AddWithValue("@rol", k.Rol);
            cmd.Parameters.AddWithValue("@aktif", k.Aktif ? 1 : 0);
            cmd.Parameters.AddWithValue("@pid", k.PersonelId);

            cmd.ExecuteNonQuery();
        }
    }
}
