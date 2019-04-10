using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Web.Mvc;
using PlayGround.DAL;
using PlayGround.Models;

namespace PlayGround.Controllers
{

    public class HomeController : Controller
    {
        //private User user = new User();
        private Login login = new Login();
        private SchoolContext db = new SchoolContext();
        string query2;
        //PlayGroundLINQtoSQLClassDataContext dc = new PlayGroundLINQtoSQLClassDataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);



        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "LoginIdTxt,PasswordTxt")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }


        [HttpGet]
        public ActionResult Index()
        {

            return View(login);
        }


        [HttpPost]
        public ActionResult Index(Login login)
        {

            ViewBag.Message = login.LoginIdTxt;

            Login(login.LoginIdTxt,login.PasswordTxt);

            return View(login);
        }




        public void Login(string username, string password)
        {
            var users = db.Users;
            foreach (User u in users)
            {
                if (u.LoginIdTxt == username & u.PasswordTxt == password)
                {
                    Response.Redirect("~/Home/About");
                }


            }



        }


        public ActionResult About()
        {
            var users = db.Users;
            foreach (User u in users)
            {
                query2 = u.FirstName;
            }


            ViewBag.Message = "Your application description page." + query2;

            return View();
        }


         

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            //DataContexts context = new DataContexts("DefaultConnection");

            //var queryUsers = from FirstName in context.Users
            //                 select FirstName;


            ViewBag.Message = "Your application description page.";
            



            return View();
        }

        


    }
}