using Microsoft.AspNetCore.Mvc;
using CinemaWeb.Models;

namespace CinemaWeb.Controllers
{
    public class BigliettiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.BigliettiVenduti = ArchivioBiglietti.BigliettiVenduti;
            ViewBag.RidottiVenduti = ArchivioBiglietti.RidottiVenduti;
            return View();
        }

        [HttpPost]
        public IActionResult Acquista(Biglietto biglietto)
        {
            if (ArchivioBiglietti.BigliettiVenduti[biglietto.Sala] < 120)
            {
                ArchivioBiglietti.Biglietti.Add(biglietto);
                ArchivioBiglietti.BigliettiVenduti[biglietto.Sala]++;

                if (biglietto.TipoBiglietto == "Ridotto")
                {
                    ArchivioBiglietti.RidottiVenduti[biglietto.Sala]++;
                }
            }
            return RedirectToAction("Index");
        }
    }
}
