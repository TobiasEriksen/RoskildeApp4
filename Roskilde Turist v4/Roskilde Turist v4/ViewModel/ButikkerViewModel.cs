using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.ViewModel
{
    using Model;
    class ButikkerViewModel
    {
        public static ObservableCollection<Butikker> ButikkerCollection { get; set; }
        public static List<Butikker> ButikKatalog;
        public string[] _aabningstider = new string[] { "Mandag-Fredag: 10.00 - 18.00", "Lørdag: 10.00 - 18.00" };


        public ButikkerViewModel()
        {
            ButikKatalog = new List<Butikker>();
            SetButik();
            ButikkerCollection = new ObservableCollection<Butikker>();
            UpdateListe();
        }

        public void SetButik()
        {
            ButikKatalog.Add(new Butikker("Ro's Torv", "Elektronik", 1, "Fona", "22334455", _aabningstider));
            ButikKatalog.Add(new Butikker("Ro's Torv", "Elektronik", 2, "GameStop", "22334455", _aabningstider));
            ButikKatalog.Add(new Butikker("Algade 28", "Elektronik", 3, "3 Butik", "33333333", _aabningstider));
            ButikKatalog.Add(new Butikker("Stationen", "Kiosk", 4, "7-Eleven", "07110711", _aabningstider));
        }

        public void UpdateListe()
        {
            var tempButikListe =
                from butik in ButikKatalog
                where butik.Test
                select butik;

            foreach (Butikker butik in tempButikListe)
                ButikkerCollection.Add(new Butikker(butik.Adresse, butik.Kategori, butik.Id, butik.Navn, butik.Tlf, butik.Aabningstider));
            
        }
    }
}
