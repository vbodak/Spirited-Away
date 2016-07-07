using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        private Helper.Helper service = new Helper.Helper();
        public async Task<ActionResult> Index()
        {
            MovieDetails movie = await service.GetMovieAsync("Spirited Away");
            ViewBag.movie = movie;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}