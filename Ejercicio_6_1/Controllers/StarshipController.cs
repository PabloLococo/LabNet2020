using Ejercicio_6_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_6_1.Controllers
{
    public class StarshipController : Controller
    {
        // GET: Starship
        public ActionResult Index()
        {
            var starshipViewModel = new StarshipViewModel();
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.dev/api/starships/");
            var responseTalk = client.GetAsync("9");
            responseTalk.Wait();
            var result = responseTalk.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<StarshipViewModel>();
                readTask.Wait();

                starshipViewModel = readTask.Result;
            }
            return View(starshipViewModel);
        }


        [HttpGet]
        public ActionResult GetStartship()
        {
            var starshipViewModel = new StarshipViewModel();
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.dev/api/starships/");
            var responseTalk = client.GetAsync("9");
            responseTalk.Wait();
            var result = responseTalk.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<StarshipViewModel>();
                readTask.Wait();
                
                starshipViewModel = readTask.Result;
            }
            return RedirectToAction("Starship");
        }
    }
}