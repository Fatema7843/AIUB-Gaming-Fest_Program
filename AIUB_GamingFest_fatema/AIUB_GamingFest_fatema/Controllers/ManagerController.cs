using AIUB_GamingFest_fatema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIUB_GamingFest_fatema.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Volunteer_info()
        {
            finaltermEntities1 db = new finaltermEntities1();
            var data = db.volunteers.ToList();

            return View(data);
           
        }

        public ActionResult Conversation_with_Admin()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }

    }
}