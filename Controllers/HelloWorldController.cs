using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Semana16.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bienvenida(string name, int numTimes = 1)
        {
            ViewData["name"] = "Hola" + name;
            ViewData["numTime"]= numTimes;
            return View();
        }

        public string Parameters(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, su numeros de intentos es:{numTimes}");
        }
    }
}
