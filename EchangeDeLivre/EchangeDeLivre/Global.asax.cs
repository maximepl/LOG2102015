using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EchangeDeLivre
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            //It's important to check whether session object is ready
            if (HttpContext.Current.Session != null)
            {
                CultureInfo informationsChoixLangue = (CultureInfo)this.Session["LanguageChoice"];
                // Vérifier si la requête ne vient pas du lien de la langue dans la page WEB 
                // car cet événement est délenché aussi au chargement du site la première fois.
                if (informationsChoixLangue == null)
                {
                    // Vérifier la langue préférée de l'utilisateur (celle de son navigateur)
                    if (Request.UserLanguages != null)
                    {
                        // Proposer par défaut la langue du navigateur du client.
                        Session["LanguageChoice"] = new CultureInfo(Request.UserLanguages[0]);
                    }
                    else
                    {
                        Session["LanguageChoice"] = new CultureInfo("fr-CA");
                    }
                }
                informationsChoixLangue = new CultureInfo(Session["LanguageChoice"].ToString());
                // Indiquer la langue à utiliser
                Thread.CurrentThread.CurrentUICulture = informationsChoixLangue;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(informationsChoixLangue.Name);
            }
        }
    }
}
