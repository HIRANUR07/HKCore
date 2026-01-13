using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikYonetimNYPProjesi.DAL
{
    public class baglantiGetir
    {
        public MySqlConnection BaglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Port=3306;Database=26_132430030;Uid=26_132430030;Pwd=İnif123.;");
            baglanti.Open();
            return baglanti;
        }

    }
}
