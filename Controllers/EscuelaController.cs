using AspNet_CoreWeb.Models;
using Microsoft.AspNetCore.Mvc;


    public class EscuelaController : Controller
    {
        public IActionResult  Index() 
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2000;
            escuela.UniqueID = Guid.NewGuid().ToString();
            escuela.Nombre = "Buenos Aires";

            ViewBag.Dinamic = "Si nos comprometemos";
            return View();
        }
    }
