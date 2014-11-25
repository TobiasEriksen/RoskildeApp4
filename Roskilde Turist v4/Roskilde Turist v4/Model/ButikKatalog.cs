using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.Model
{
    class ButikKatalog
    {
        private List<Butikker> _butikkerListe = new List<Butikker>();

        public IEnumerable<Butikker> ButikkerListe
        {
            get { return new List<Butikker>(_butikkerListe); }
        }


        public ButikKatalog(IEnumerable<Butikker> butikker)
        {
            _butikkerListe.AddRange(butikker);
        }
    }
}
