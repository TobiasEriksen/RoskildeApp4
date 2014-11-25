using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.Model
{
    class Sevaerdigheder : StederBaseClass
    {
        public string Tema { get; set; }

        public Sevaerdigheder(string adresse, string kategori, int id, string navn, string tlf, string[] aabningstider,string tema)
            : base(adresse, kategori, id, navn, tlf, aabningstider)
        {
            Tema = tema;
        }
    }
}
