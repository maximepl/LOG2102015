using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EchangeDeLivre.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ChangeLanguage(string linkBack, string languageCode)
        {
            Session["LanguageChoice"] = new CultureInfo(languageCode);

            return Redirect(linkBack);
        }
    }
}