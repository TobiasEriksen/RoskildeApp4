using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Roskilde_Turist_v4.Annotations;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.ViewModel
{
    using Model;
    class ButikkerViewModel : INotifyPropertyChanged
    {
        public static ObservableCollection<Butikker> Collection { get; set; }
        public static List<Butikker> Katalog;
        private readonly string[] _aabningstider = { "Mandag-Fredag: 10.00 - 18.00", "Lørdag: 10.00 - 18.00" };


        public ButikkerViewModel()
        {
            Katalog = new List<Butikker>();
            SetButik();

            // Sorterer Kataloget i alfabetisk rækkefølge!!
            Katalog.Sort((a, b) => System.String.Compare(a.Navn, b.Navn, System.StringComparison.Ordinal));

            Collection = new ObservableCollection<Butikker>();
            UpdateCollection();
        }

        public void SetButik()
        {
            Katalog.Add(new Butikker("Ro's Torv", "Elektronik", 1, "Fona", "22334455", _aabningstider));
            Katalog.Add(new Butikker("Ro's Torv", "Elektronik", 2, "GameStop", "22334455", _aabningstider));
            Katalog.Add(new Butikker("Algade 28", "Elektronik", 3, "3 Butik", "33333333", _aabningstider));
            Katalog.Add(new Butikker("Stationen", "Kiosk", 4, "7-Eleven", "07110711", _aabningstider));
            Katalog.Add(new Butikker("Algade 36", "Tøj", 5, "Oda's Minde", "46351920", _aabningstider));
            Katalog.Add(new Butikker("Allehelgensgade 7 st", "Tøj", 6, "ID Lingeri", "46366301", _aabningstider));

        }

        public void UpdateCollection()
        {
            var tempButikListe =
                from butik in Katalog
                where butik.Test
                select butik;

            foreach (Butikker butik in tempButikListe)
                Collection.Add(new Butikker(butik.Adresse, butik.Kategori, butik.Id, butik.Navn, butik.Tlf, butik.Aabningstider));
            
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
