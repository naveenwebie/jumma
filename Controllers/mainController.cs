//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace hrapp.Controllers
//{
//    public class mainController : Controller
//    {
//        // GET: main
//        public ActionResult Index()
//        {
//            return View();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using hrapp.Models;



namespace HR_APPLICATION.Controllers
{
    public class mainController : Controller
    {
        LoginnewEntities db = new LoginnewEntities();



        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public ActionResult Loginpage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loginpage(Login log)
        {
            ViewData["Message"] = string.Empty;
            // To check if the username and password is equal in db and user and take count.
            int user = db.Logins.Where(x => x.username == log.username && x.password == log.password).Count();
            if (user > 0)
            {
                return RedirectToAction("dashboard");
            }
            else
            {
                ViewData["Message"] = "*Login ID or Password is incorrect";
                return View();
            }
        }
        public ActionResult dashboard()
        {
            return View();
        }
        public ActionResult SaveEmployee()
        {
            ViewData["Message"] = "*Login ID or Password is incorrect";
            return View();
        }

        [HttpPost]
        public ActionResult SaveEmp(SaveEmployee emp)
        {
            if (ModelState.IsValid) {
                db.SaveEmployee.Add(emp);
                db.SaveChanges();
                ViewBag.message = "Registered Successfully";
            }
            return View();
        }
        public ActionResult FindEmployee(SaveEmployee log)
        {
            return View();
            if (ModelState.IsValid)
            {
                int ver = from emp in db where log.Emp_ID == Loginnew.SaveEmployee
            }
        }
    }
}