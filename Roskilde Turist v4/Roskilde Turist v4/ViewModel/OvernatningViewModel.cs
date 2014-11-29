using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roskilde_Turist_v4.Model;

namespace Roskilde_Turist_v4.ViewModel
{
    class OvernatningViewModel
    {
        public ObservableCollection<HotelOgOvernatning> Collection { get; set; }

        public List<HotelOgOvernatning> Katalog;
        private readonly string[] _aabningstider = {"Reception: Døgnåbent"};

        public OvernatningViewModel()
        {
            Katalog = new List<HotelOgOvernatning>();
            SetHotel();
            Collection = new ObservableCollection<HotelOgOvernatning>();
            UpdateCollection();
        }

        private void UpdateCollection()
        {
            var tempListe =
                from unit in Katalog
                where unit.Test
                select unit;

            foreach (HotelOgOvernatning unit in tempListe)
                Collection.Add(new HotelOgOvernatning(unit.Adresse, unit.Kategori, unit.Id, unit.Navn, unit.Tlf, unit.Aabningstider, unit.Pladser));
        }


        private void SetHotel()
        {
            Katalog.Add(new HotelOgOvernatning("Vindeboder 7", "Hotel", 1150, "Danhostel Roskilde", "46322184", _aabningstider, 40));
            Katalog.Add(new HotelOgOvernatning("Langagervej 19a", "B&B", 1170, "Bed & Breakfast Roskilde", "24469623", _aabningstider, 2));
            Katalog.Add(new HotelOgOvernatning("Vestre Kirkevej 12", "Hotel", 1151, "Comwell Roskilde", "46323131", _aabningstider, 50));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
            Katalog.Add(new HotelOgOvernatning("Algade 13", "Hotel", 1152, "Prindsen", "46309100", _aabningstider, 30));
        }
    }
}
