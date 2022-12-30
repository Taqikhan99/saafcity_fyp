using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace saafcity_fyp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Dashboard()
        {
            ViewBag.Title = "Dashboard";

            return View();
        }
        public ActionResult log()
        {
            ViewBag.Title = "log";

            return View();
        }
        public ActionResult register()
        {


            return View();
        }
        public ActionResult Settings()
        {
            ViewBag.Title = "Settings";

            return View();
        }
        public ActionResult Employees()
        {
            ViewBag.Title = "Employees";

            return View();
        }
        public ActionResult homepage_Garbage()
        {
            ViewBag.Title = "homepage_Garbage";

            return View();
        }
        public ActionResult homepage_Sewage()
        {
            ViewBag.Title = "homepage_Sewage";

            return View();
        }
        public ActionResult done_comsewage()
        {
            ViewBag.Title = "done_comsewage";

            return View();
        }
        public ActionResult done_comgarbage()
        {
            ViewBag.Title = "done_comgarbage";

            return View();
        }
        public ActionResult in_prog_garbage()
        {
            ViewBag.Title = "in_prog_garbage";

            return View();
        }
        public ActionResult in_prog_sewage()
        {
            ViewBag.Title = "in_prog_sewage";

            return View();
        }
        public ActionResult Total_complaints_garbage()
        {
            ViewBag.Title = "Total_complaints_garbage";

            return View();
        }
        public ActionResult Total_complaints_sewage()
        {
            ViewBag.Title = "Total_complaints_sewage";

            return View();
        }
        public ActionResult unver_com_garbage()
        {
            ViewBag.Title = "unver_com_garbage";

            return View();
        }
        public ActionResult var_com_garbage()
        {
            ViewBag.Title = "var_com_garbage";

            return View();
        }
        public ActionResult unver_com_sewage()
        {
            ViewBag.Title = "unver_com_sewage";

            return View();
        }
        public ActionResult var_com_sewage()
        {
            ViewBag.Title = " var_com_sewage";

            return View();
        }
    }


}
