using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikYonetimNYPProjesi.ENTITY
{
    
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; } = "";
        public string Parola { get; set; } = "";
        public string Rol { get; set; } = "";      // "Admin" | "IK" | "User"
        public bool Aktif { get; set; }
        public int? PersonelId { get; set; }        // Admin için null olabilir
    }
}
