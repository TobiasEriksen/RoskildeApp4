using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.Model
{
    class Bruger
    {
        public string Email { get; private set; }
        public string Navn { get; private set; }
        public string Telefon { get; private set; }
        private string _brugerNavn { get; set; }
        private string _password { get; set; }
        
        public Bruger (string email, string navn, string telefon, string brugernavn, string password)
	{
            Email = email;
            Navn = navn;
            Telefon = telefon;
            _brugerNavn = brugernavn;
            _password = password;
	}
        // Metoderne beskrevet på Klassediagrammet hører til i katalog, ikke her. 
    }
}
