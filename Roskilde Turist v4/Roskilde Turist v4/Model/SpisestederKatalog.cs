using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.Model
{
    class SpisestederKatalog
    {
        private List<Spisesteder> _spisestedersListe = new List<Spisesteder>();

        public List<Spisesteder> SpisestedersListe
        {
            get { return new List<Spisesteder>(_spisestedersListe); }
        }

        public SpisestederKatalog(IEnumerable<Spisesteder> spisesteder)
        {
            _spisestedersListe.AddRange(spisesteder);
        }
    }
}
