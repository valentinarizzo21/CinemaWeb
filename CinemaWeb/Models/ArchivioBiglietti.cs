using System.Collections.Generic;

namespace CinemaWeb.Models
{
    public static class ArchivioBiglietti
    {
        public static List<Biglietto> Biglietti = new List<Biglietto>();

        public static Dictionary<string, int> BigliettiVenduti = new Dictionary<string, int>
        {
            { "SALA NORD", 0 },
            { "SALA EST", 0 },
            { "SALA SUD", 0 }
        };

        public static Dictionary<string, int> RidottiVenduti = new Dictionary<string, int>
        {
            { "SALA NORD", 0 },
            { "SALA EST", 0 },
            { "SALA SUD", 0 }
        };
    }
}
