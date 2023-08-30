using AIUB_GamingFest_fatema.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIUB_GamingFest_fatema.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Overview()
        {



            return View();
        }


        public JsonResult Overview_dashboard()
        {
            try
            {
                string[] Overview_dashboard = new string[2];
                string ConnectionString = null;
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select count (gender) as male,(select count(gender)from users where Gender='female')as female from users where Gender='male'");
                DataTable dt = new DataTable();
                SqlDataAdapter cmd1 = new SqlDataAdapter(cmd);
                cmd1.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    Overview_dashboard[0] = "0";
                    Overview_dashboard[1] = "0";
                }
                else
                {
                    Overview_dashboard[0] = dt.Rows[0]["male"].ToString();
                    Overview_dashboard[1] = dt.Rows[0]["female"].ToString();
                }

                return Json(new { Overview_dashboard }, JsonRequestBehavior.AllowGet);






            }

            catch (Exception a)
            {
                throw a;
            }



        }



        






        public ActionResult Users_info()
        {
            finaltermEntities1 db = new finaltermEntities1();
            var data = db.users.ToList();

            return View(data);


        }



        public ActionResult useredit()
        {
            return View();
        }

        public ActionResult userdelete(int id)
        {
            using (finaltermEntities1 a = new finaltermEntities1())
            {
                var v = (from vt in a.users
                         where vt.id == id
                         select vt).FirstOrDefault();

                return View();
            }
        }


        public ActionResult usercreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult usercreate(user av)
        {
            finaltermEntities1 a = new finaltermEntities1();
            a.users.Add(av);
            a.SaveChanges();
            return RedirectToAction("Users_info");

        }






        public ActionResult Volunteers_info()
        {
            finaltermEntities1 db = new finaltermEntities1();
            var data = db.volunteers.ToList();

            return View(data);

        }


        public ActionResult volunteercreate(volunteer av) {
            finaltermEntities1 a = new finaltermEntities1();
            a.volunteers.Add(av);
            a.SaveChanges();
            return RedirectToAction("Volunteers_info");

        }

        public ActionResult volunteeredit(int id)
        {
            finaltermEntities1 a = new finaltermEntities1();
            var volunteer = (from vt in a.volunteers
                             where vt.id == id
                             select vt).First();

            return View(volunteer);

        }

        [HttpPost]
        public ActionResult vedit(volunteer av)
        {
            using (finaltermEntities1 a = new finaltermEntities1())
            {
                var entity = (from vt in a.volunteers
                              where vt.id== av.id
                              select vt).FirstOrDefault();

                a.Entry(entity).CurrentValues.SetValues(av);
                a.SaveChanges();
                return RedirectToAction("Volunteers_info");

            }
        }


        public ActionResult volunteerdelete(int id)
        {
            using (finaltermEntities1 a = new finaltermEntities1())
            {
                var v = (from vt in a.volunteers
                         where vt.id == id
                         select vt).FirstOrDefault();

                return View();
            }
        }





        public ActionResult Managers_info()
            {
                finaltermEntities1 db = new finaltermEntities1();
                var data = db.managers.ToList();

                return View(data);

            }
            public ActionResult managercreate(manager av)
            {
                finaltermEntities1 a = new finaltermEntities1();
                a.managers.Add(av);
                a.SaveChanges();
                return RedirectToAction("Managers_info");
            }

        public ActionResult managerdelete(int id)
        {
            using (finaltermEntities1 a = new finaltermEntities1())
            {
                var v = (from vt in a.managers
                         where vt.id == id
                         select vt).FirstOrDefault();

                return View();
            }
        }




        public ActionResult Logout()
            {
                return View();
            }
        }
    }