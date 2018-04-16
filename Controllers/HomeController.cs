using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BirthdayCard.Models;

namespace BirthdayCard.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult HappyBirthday()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Index(Models.BirthdayInfo birthdayinfo)
        {
            if (ModelState.IsValid)
            {
                return View("HappyBirthday", birthdayinfo);
            }
            else
            {
                return View();
            }
        }
    }
}