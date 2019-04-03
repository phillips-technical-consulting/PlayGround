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
        private User user = new User();
        private SchoolContext db = new SchoolContext();
        string query2;
        //PlayGroundLINQtoSQLClassDataContext dc = new PlayGroundLINQtoSQLClassDataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public ActionResult Index()
        {
            var queryUsers = user.FirstName;
            

            var users = db.Users;
            
            foreach(User u in users)
            {
                query2 = u.FirstName;
            }

            return View();
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