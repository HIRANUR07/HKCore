using ikYonetimNYPProjesi.DAL;
using ikYonetimNYPProjesi.ENTITY;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ikYonetimNYPProjesi.DAL
{
    public class IzinDAL
    {
        private baglantiGetir _baglanti = new baglantiGetir();

        // 1 İZİN EKLE (User)
        public void IzinEkle(Izin izin)
        {
            using (MySqlConnection conn = _baglanti.BaglantiGetir())
            {
                string sql = @"
INSERT INTO leave_requests
(personel_id, baslangic, bitis, izin_turu, aciklama, durum)
VALUES
(@pid, @bas, @bit, @tur, @acik, 'Beklemede');";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", izin.PersonelId);
                    cmd.Parameters.AddWithValue("@bas", izin.BaslangicTarihi);
                    cmd.Parameters.AddWithValue("@bit", izin.BitisTarihi);
                    cmd.Parameters.AddWithValue("@tur", izin.IzinTuru);

                    //  aciklama NULL olabilir
                    if (string.IsNullOrWhiteSpace(izin.Aciklama))
                        cmd.Parameters.AddWithValue("@acik", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@acik", izin.Aciklama);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2 PERSONELE AİT TÜM İZİNLER (User sadece kendi)
        public List<Izin> PersonelIzinleriniGetir(int personelId)
        {
            List<Izin> izinler = new List<Izin>();

            using (MySqlConnection conn = _baglanti.BaglantiGetir())
            {
                string sql = @"
SELECT id, personel_id, baslangic, bitis, izin_turu, aciklama, durum
FROM leave_requests
WHERE personel_id = @pid
ORDER BY baslangic DESC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", personelId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            izinler.Add(new Izin
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                PersonelId = Convert.ToInt32(dr["personel_id"]),
                                BaslangicTarihi = Convert.ToDateTime(dr["baslangic"]),
                                BitisTarihi = Convert.ToDateTime(dr["bitis"]),
                                IzinTuru = dr["izin_turu"].ToString(),
                                //  NULL güvenli
                                Aciklama = dr["aciklama"] == DBNull.Value ? "" : dr["aciklama"].ToString(),
                                Durum = dr["durum"].ToString()
                            });
                        }
                    }
                }
            }

            return izinler;
        }

        //  TÜM İZİNLERİ GETİR (IK + Admin)
        public List<Izin> TumIzinleriGetir()
        {
            List<Izin> izinler = new List<Izin>();

            using (MySqlConnection conn = _baglanti.BaglantiGetir())
            {
                string sql = @"
SELECT id, personel_id, baslangic, bitis, izin_turu, aciklama, durum
FROM leave_requests
ORDER BY baslangic DESC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        izinler.Add(new Izin
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            PersonelId = Convert.ToInt32(dr["personel_id"]),
                            BaslangicTarihi = Convert.ToDateTime(dr["baslangic"]),
                            BitisTarihi = Convert.ToDateTime(dr["bitis"]),
                            IzinTuru = dr["izin_turu"].ToString(),
                            Aciklama = dr["aciklama"] == DBNull.Value ? "" : dr["aciklama"].ToString(),
                            Durum = dr["durum"].ToString()
                        });
                    }
                }
            }

            return izinler;
        }

        //  DURUM GÜNCELLE (Sadece Admin: Onayla / Reddet)
        public void IzinDurumGuncelle(int izinId, string yeniDurum)
        {
            using (MySqlConnection conn = _baglanti.BaglantiGetir())
            {
                string sql = @"
UPDATE leave_requests
SET durum = @durum
WHERE id = @id;";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@durum", yeniDurum);
                    cmd.Parameters.AddWithValue("@id", izinId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}