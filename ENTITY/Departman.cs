using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ikYonetimNYPProjesi.ENTITY
{
    public class Departman
    {
        public int Id { get; set; }
        public string DepartmanAdi { get; set; } = string.Empty;

        public bool Aktif { get; set; }
    }
}
