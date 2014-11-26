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
        private static ButikKatalog _butikKatalog;
        
        public ButikkerViewModel(ButikKatalog butikKatalog)
        {
            _butikKatalog = butikKatalog;
            ButikkerCollection = new ObservableCollection<Butikker>();
            UpdateListe();
        }

        private void UpdateListe()
        {
            var tempButikListe =
                from butik in _butikKatalog.ButikkerListe
                where butik.Test
                select butik;

            foreach (Butikker butik in tempButikListe)
                ButikkerCollection.Add(new Butikker(butik.Adresse, butik.Kategori, butik.Id, butik.Navn, butik.Tlf, butik.Aabningstider));
            
        }
    }
}
