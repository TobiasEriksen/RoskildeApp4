using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace Roskilde_Turist_v4.Model
{
    class Spisesteder : StederBaseClass
    {
        public string Pladser { get; set; }
        public string[] Menu { get; set; }

        public Spisesteder(string adresse, string kategori, int id, string navn, string tlf, string[] aabningstider, string pladser, string[] menu)
            : base(adresse, kategori, id, navn, tlf, aabningstider)
        {
            Pladser = Pladser;
            Menu = menu;
        }
    }
}
