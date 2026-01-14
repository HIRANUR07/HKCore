using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikYonetimNYPProjesi.ENTITY
{

    public class Personel
    {
        public int Id { get; set; }
        public int UserId { get; set; }   
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Departman { get; set; } = string.Empty;
        public string Pozisyon { get; set; } = string.Empty;

        public bool Aktif { get; set; }
        public int YillikIzinHakki { get; set; }
    }
}
