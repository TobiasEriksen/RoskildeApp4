using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roskilde_Turist_v4.Model
{
    class Rating
    {
        public int Id { get; private set; }
        public int Score { get; private set; }
        public string Navn { get; private set; }
        public string Bedoemmelse { get; private set; }

        public Rating (int id, string navn, int score, string bedoemmelse)
	{
            Id = id;
            Score = score;
            Navn = navn;
            Bedoemmelse = bedoemmelse;
	}

        // GivBedoemmelse og Hent.. er ikke nødvendig da vi opretter dem som et objekt
        // Der skal dog tilføjes en metode til at give hver bedømmelse(objekt) et unikt ID foruden stedets ID. 
    }
}
