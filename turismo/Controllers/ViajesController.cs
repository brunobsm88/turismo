using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace turismo.Controllers
{
    public class ViajesController : Controller
    {
        //
        // GET: /Viajes/
        public ActionResult Categoria()
        {
            return View();
        }
        public ActionResult listaViajes()
        {
            return View();
        }
        public ActionResult caracteristicas()
        {
            return View();
        }
        
        public ActionResult lugar()
        {
            return View();
        }
        public ActionResult AmericaLatina()
        {
            return View();
        }
    }
}
