using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookViewer.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Index()
        {
			ViewBag.Title = "Welcome to The Bookatorium";
			ViewBag.SubTitle = "Perveyors of peculiar books";
			ViewBag.Text = "Here you can find all sorts of books. Big ones, small ones, some as big as your head. I don't even know how many books live here, it'd take me years to go through them all and frankly I just don't have the time.";
			ViewBag.Authors = new string[]
			{
        		"Italo Calvino",
        		"Luigi Seraphini",
        		"Georges Perec"
			};

            return View ();
        }
    }
}
