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
        DuLichDBEntities db = new DuLichDBEntities();
        //Lấy danh sách tour
        var listTour = db.TourDuLiches.ToList();
            return View(listTour);
        }
    }
}