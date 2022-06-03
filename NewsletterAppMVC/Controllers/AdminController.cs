using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities()) {
                var signups = db.SignUps.Where(x => x.removed == null).ToList(); ;

                List<SignUpVM> signUpVMs = new List<SignUpVM>();
                foreach (var signup in signups) {
                    var signupVM = new SignUpVM();
                    signupVM.Id = signup.Id;
                    signupVM.firstName = signup.firstName;
                    signupVM.lastName = signup.lastName;
                    signupVM.emailAddress = signup.emailAddress;
                    signUpVMs.Add(signupVM);
                }

                return View(signUpVMs);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities()) {
                var signup = db.SignUps.Find(Id);
                signup.removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}