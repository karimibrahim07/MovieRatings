using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRatingsDB;

namespace MovieRatings.Controllers
{
    public class RatingController : Controller
    {
        // GET: Rating
        public ActionResult Index()
        {
            var cust = DB.GetMovies();
            ViewBag.Movies = cust;
            return View();
        }

        public ActionResult Detail(int id)
        {
            //get model from database
            ViewBag.Movie = DB.GetRating(id);
            return View();
        }
    }
}