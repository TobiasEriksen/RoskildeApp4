using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.Model
{
    public class Butikker : StederBaseClass
    {
        public Butikker(string adresse, string kategori, int id, string navn, string tlf, string[] aabningstider)
	    : base(adresse, kategori, id, navn, tlf, aabningstider)
        {
            
        } 

    }
}
