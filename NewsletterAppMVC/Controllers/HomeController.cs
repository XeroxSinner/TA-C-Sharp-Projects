using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress)) {
                return View("~/Views/Shared/Error.cshtml");
            }
            else {

                //DB utilizing Entity Framework
                using (NewsletterEntities db = new NewsletterEntities()) {
                    var signup = new SignUp();
                    signup.firstName = firstName;
                    signup.lastName = lastName;
                    signup.emailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }

                //DB Management without Entity
                //string queryString = @"INSERT INTO SignUps (firstName, lastName, emailAddress) VALUES
                //            (@firstName, @lastName, @emailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand cmd = new SqlCommand(queryString, connection);
                //    cmd.Parameters.Add("@firstName", SqlDbType.VarChar);
                //    cmd.Parameters.Add("@lastName", SqlDbType.VarChar);
                //    cmd.Parameters.Add("@emailAddress", SqlDbType.VarChar);

                //    cmd.Parameters["@firstName"].Value = firstName;
                //    cmd.Parameters["@lastName"].Value = lastName;
                //    cmd.Parameters["@emailAddress"].Value = emailAddress;

                //    connection.Open();
                //    cmd.ExecuteNonQuery();
                //    connection.Close();
            }


            return View("Success");
        }
    }
}