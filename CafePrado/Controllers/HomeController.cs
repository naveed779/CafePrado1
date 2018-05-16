using CafePrado.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Configuration;

namespace CafePrado.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = "Data Source=DESKTOP-L4B6SHB;Initial Catalog=Managment;Integrated Security=True";
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
        public ActionResult AddCustomer()

        {


            return View(new AddCustomer());
        }
        [HttpPost]
        public ActionResult AddCustomer(AddCustomer model)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String query = "INSERT INTO AddCustomer VALUES (@CustomerID ,@Name,@CCell,@Status)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerID", model.CustomerID);
            cmd.Parameters.AddWithValue("@Name", model.Name);
            cmd.Parameters.AddWithValue("@CCell", model.CCell);
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

            return View(new AddNewItems());
        }

        [HttpPost]
        public ActionResult AddNewItems(AddNewItems itemsmodel)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String query = "INSERT INTO AddItem VALUES (@ID ,@ItemName,@Quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", itemsmodel.ID);
            cmd.Parameters.AddWithValue("@ItemName", itemsmodel.ItemName);
            cmd.Parameters.AddWithValue("@Quantity", itemsmodel.Quantity);

            cmd.ExecuteNonQuery();

            return RedirectToAction("Index");
        }
        public ActionResult AddAccountant()
        {
            return View(new AddAccountant());
        }
        [HttpPost]
        public ActionResult AddAccountant(AddAccountant Accountantmodel)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String query = "INSERT INTO AddAccountant VALUES (@AccountantID ,@AName,@AccountantCell,@AccountantSalary,@AEmail)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@AccountantID", Accountantmodel.AccountantID);
            cmd.Parameters.AddWithValue("@AName", Accountantmodel.AName);
            cmd.Parameters.AddWithValue("@AccountantCell", Accountantmodel.AccountantCell);
            cmd.Parameters.AddWithValue("@AccountantSalary", Accountantmodel.AccountantSalary);
            cmd.Parameters.AddWithValue("@AEmail", Accountantmodel.AEmail);



            cmd.ExecuteNonQuery();

            return View();
        }
        public ActionResult TakeOrder()
        {
            TakeOrder db = new TakeOrder();
            db.Orders = PopulateOrders();
            return View(db);
        }

        [HttpPost]
        public ActionResult TakeOrder(TakeOrder ordermodel)
        {
            ordermodel.Orders = PopulateOrders();
            var selectedItem = ordermodel.Orders.Find(p => p.Value == ordermodel.CustomerID.ToString());
            if (selectedItem != null)
            {
                selectedItem.Selected = true;
                ViewBag.Message = "CustomerName: " + selectedItem.Text;
                ViewBag.Message += "CCell: " + ordermodel.CCell;
            }

            return View("TakeOrder");
        }
        private List<SelectListItem> PopulateOrders()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            SqlConnection con = new SqlConnection(connectionString);

            string ord = " SELECT CustomerID, Name , CCell FROM AddCustomer";
            SqlCommand cmd = new SqlCommand(ord, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                items.Add(new SelectListItem
                {
                    Text = sdr["CustomerName"].ToString(),
                    Value = sdr["CustomerCell"].ToString()
                });
            }

            con.Close();
            return items;
        }
    }
}
            

        
    
    
