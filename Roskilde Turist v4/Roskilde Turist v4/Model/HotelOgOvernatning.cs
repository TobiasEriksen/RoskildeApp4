using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace Roskilde_Turist_v4.Model
{
    class HotelOgOvernatning : StederBaseClass
    {
        public int Pladser { get; set; }

        public HotelOgOvernatning(string adresse, string kategori, int id, string navn, string tlf, string[] aabningstider, int pladser)
            : base(adresse,kategori,id,navn,tlf,aabningstider)
        {
            Pladser = pladser;
        }

    }
}
