using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.Model
{
    class HotelKatalog
    {
        private List<HotelOgOvernatning> _hotelOgOvernatningsListe = new List<HotelOgOvernatning>();

        public IEnumerable<HotelOgOvernatning> HotelOgOvernatningsListe
        {
            get { return new List<HotelOgOvernatning>(_hotelOgOvernatningsListe); }
        }

        public HotelKatalog(IEnumerable<HotelOgOvernatning> hoteller)
        {
            _hotelOgOvernatningsListe.AddRange(hoteller);
        }
    }
}
