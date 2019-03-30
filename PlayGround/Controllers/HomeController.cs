using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Collections.Specialized;
using System.Data.SqlClient;
//using PlayGround.Context;

namespace PlayGround.Controllers
{

    public class HomeController : Controller
    {
        string connectionString;

        //PlayGroundLINQtoSQLClassDataContext dc = new PlayGroundLINQtoSQLClassDataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public ActionResult Index()
        {
            var connectionManagerDatabaseServers = ConfigurationManager.GetSection("connectionStrings") as NameValueCollection;

            return View();
        }

        public ActionResult About()
        {




                ViewBag.Message = "Your application description page.";

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