using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace aspnet_mvc5_lang.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //CultureInfo ptBr = new CultureInfo("es-ES");


            //// ou

            //CultureInfo ptBrLcid = new CultureInfo(1046);

            //Thread.CurrentThread.CurrentCulture = ptBr;
            //Thread.CurrentThread.CurrentUICulture = ptBr;




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
    }
}