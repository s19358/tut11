using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }


        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;  //The ViewData dictionary object contains data that will be passed to the view.
            ViewData["NumTimes"] = numTimes;  //bunlari burda isimlendiriyor ayni isimle viewde bunlara erisiyor

            return View();
        }
    }
}