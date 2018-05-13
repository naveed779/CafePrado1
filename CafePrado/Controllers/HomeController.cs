using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafePrado.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignIN()
        {
          
            return View();
        }
        public ActionResult SignUP()
        {

            return View();
        }
        public ActionResult TakeOrder()
        {

            return View();
        }
        public ActionResult CustomerPayment()
        {

            return View();
        }
        public ActionResult VenderOrder()
        {

            return View();
        }
        public ActionResult VenderPayment()
        {

            return View();
        }
        public ActionResult HireEmployee()
        {

            return View();
        }
        public ActionResult EmployeeSalary()
        {

            return View();
        }
        public ActionResult AddNewItems()
        {

            return View();
        }
    }
}