using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIUB_GamingFest_fatema.Controllers
{
    public class VolunteerController : Controller
    {
        // GET: Volunteer
        public ActionResult Conversation_with_managers()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }
    }
}