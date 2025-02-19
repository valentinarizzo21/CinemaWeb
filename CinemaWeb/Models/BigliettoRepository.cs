using System.Collections.Generic;
using System.Linq;

namespace CinemaWeb.Models
{
    public static class BigliettoRepository
    {
        public static List<Biglietto> Biglietti { get; set; } = new List<Biglietto>();

        public static int GetBigliettiVenduti(string sala) =>
            Biglietti.Count(b => b.Sala == sala);

        public static int GetRidottiVenduti(string sala) =>
            Biglietti.Count(b => b.Sala == sala && b.TipoBiglietto == "Ridotto");

        // aggiungo il controllo sui 120 posti di sala
        public static bool AggiungiBiglietto(Biglietto biglietto)
        {
            if (GetBigliettiVenduti(biglietto.Sala) < 120)
            {
                Biglietti.Add(biglietto);
                return true;
            }
            return false;
        }
    }
}
