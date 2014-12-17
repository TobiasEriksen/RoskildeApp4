using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace Roskilde_Turist_v4.Model
{
    public class StederBaseClass
    {
        public string Adresse { get; set; }
        public string Kategori { get; set; }
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Tlf { get; set; }
        public string[] Aabningstider { get; set; }
        public bool Test { get; set; }
        public string Img { get; set; }

        public StederBaseClass(string adresse, string kategori, int id, string navn, string tlf, string[] aabningstider, string img)
        {
            Adresse = adresse;
            Kategori = kategori;
            Id = id;
            Navn = navn;
            Tlf = tlf;
            Aabningstider = aabningstider;
            Img = img;
            Test = true;
        }

        public StederBaseClass(string adresse, string kategori, int id, string navn, string tlf, string[] aabningstider)
        {
            Adresse = adresse;
            Kategori = kategori;
            Id = id;
            Navn = navn;
            Tlf = tlf;
            Aabningstider = aabningstider;
            Test = true;
        }
    }
}
