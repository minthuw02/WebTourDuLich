using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TourDuLich.Models;

namespace TourDuLich.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
        DuLichDBEntities1 db = new DuLichDBEntities1();
        //Lấy danh sách tour
        var listTour = db.TourDuLiches.ToList();
            return View(listTour);
        }
        public ActionResult Search() {

            return View();
        }
    }
}