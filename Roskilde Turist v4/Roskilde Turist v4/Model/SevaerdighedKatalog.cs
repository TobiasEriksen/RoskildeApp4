using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.Model
{
    class SevaerdighedKatalog
    {
        private List<Sevaerdigheder> _sevaerdighedersListe = new List<Sevaerdigheder>();

        public IEnumerable<Sevaerdigheder> SevaerdighedersListe
        {
            get { return new List<Sevaerdigheder>(_sevaerdighedersListe); }
        }

        public SevaerdighedKatalog(IEnumerable<Sevaerdigheder> sevaerdigheder)
        {
            _sevaerdighedersListe.AddRange(sevaerdigheder);
        }
    }
}
