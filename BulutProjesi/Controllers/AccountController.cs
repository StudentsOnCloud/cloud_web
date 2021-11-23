using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BulutProjesi.Models;
using System.Data.SqlClient;

namespace BulutProjesi.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            // Bağlanacak bilgisayardaki database adını giriniz.
            con.ConnectionString = "data source=DESKTOP-00A7JNL; database=Bulut; integrated security=SSPI;" ;
        }
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from aspnet_Users where UserName'" + acc.Name + "' and aspnet_Membership where Password='" + acc.Password +"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                return View();
            }
            

            
        }
    }
}