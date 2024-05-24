using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TourDuLich.Controllers
{
    public class TourController : Controller
    {
        //GET: Tour
        public ActionResult Index()
        {
            return View();
        }
        // GET: ShowList
        public ActionResult ShowList()
        {
            return View();
        }

        //GET: ShowDetail
        public ActionResult ShowDetail() { 
            return View();
        }

        //GET: Cancel
        public ActionResult Cancel()
        {
            return View();
        }
    }
}