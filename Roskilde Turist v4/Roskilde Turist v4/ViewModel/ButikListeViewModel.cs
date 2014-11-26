using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.ViewModel
{
    using Model;
    class ButikListeViewModel
    {
        public ButikkerViewModel RoskildeButikker { get; set; }

        string[] _aabningstider = new string[] { "Mandag-Fredag: 10.00 - 18.00", "Lørdag: 10.00 - 18.00"};

        public ButikListeViewModel()
        {
            ButikKatalog roskildeButikker = new ButikKatalog(SetButik());
            RoskildeButikker = new ButikkerViewModel(roskildeButikker);

        }

        private IEnumerable<Butikker> SetButik()
        {
            List<Butikker> butik = new List<Butikker>()
            {
                new Butikker("Ro's Torv", "Elektronik", 1, "Fona", "22334455", _aabningstider),
                new Butikker("Ro's Torv", "Elektronik", 2, "GameStop", "22334455", _aabningstider),
                new Butikker("Algade 28", "Elektronik", 3, "3 Butik", "33333333", _aabningstider),
            };
            return butik;
        }
    }
}
