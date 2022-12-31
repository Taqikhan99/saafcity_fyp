using saafcity_fyp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace saafcity_fyp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        //login get page
        public ActionResult Login()
        {

            return View();
        }

        //login post
        [HttpPost]
        public ActionResult Login(Users user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var context = new SaafCity_DatabaseEntities2())
                    {
                        //check if any username and password match to the one provided

                        bool isValid = context.Users.Any(x => x.User_ID == user.User_ID.ToString() && x.Password == user.Password.ToString());
                        if (isValid)
                        {
                            //setting auth cookie
                            FormsAuthentication.SetAuthCookie(user.User_ID, false);

                            TempData["message"] = "Login Successful!";

                            return RedirectToAction("Dashboard","Home");
                        }
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("ErrorPage");
            }
        }

        public ActionResult ErrorPage()
        {
            ViewBag.eMessage=TempData["message"];
            return View();
        }

        //register
        public ActionResult register()
        {


            return View();
        }

        //[HttpPost]
        //public ActionResult register(Employee employee)
        //{
        //    try
        //    {
        //        using (var context = new SaafCity_DatabaseEntities1())
        //        {


        //            context.Employees.Add(employee);
        //            context.SaveChanges();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["message"] = ex.Message;
        //    }

        //    return View();
        //}

    }
}