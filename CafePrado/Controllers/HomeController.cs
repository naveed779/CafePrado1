using CafePrado.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
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
         

            return View(new TakeOrder());
        }
        [HttpPost]
        public ActionResult TakeOrder(TakeOrder model)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-L4B6SHB;Initial Catalog=Managment;Integrated Security=True");
            con.Open();
            String query = "INSERT INTO TakeOrder VALUES (@CustomerID ,@Name,@Cell,@Status)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerID", model.CustomerID);
            cmd.Parameters.AddWithValue("@Name", model.Name);
            cmd.Parameters.AddWithValue("@Cell", model.Cell);
            cmd.Parameters.AddWithValue("@Status", model.Status);
         
            cmd.ExecuteNonQuery();
            

            

            /*TakeOrder tb1 = new TakeOrder();
            tb1.CustomerID = model.CustomerID;
            tb1.Name = model.Name;
            tb1.Cell = model.Cell;
            tb1.Status = model.Status;
            db.Orders.Add(tb1);
            db.SaveChanges();*/

            return RedirectToAction("Index");

        }



        public ActionResult CustomerPayment()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-L4B6SHB;Initial Catalog=Managment;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string query1 = "SELECT * from TakeOrder";
            SqlDataAdapter sda = new SqlDataAdapter(query1, con);
            sda.Fill(dt);
            return View(dt);


          
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