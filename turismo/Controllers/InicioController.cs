using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using turismo.ViewModel.Registro;


namespace turismo.Controllers
{
    public class InicioController : Controller
    {
        //
        // GET: /Inicio/
        public turismo_uvmEntities db;
        public InicioController() {

            db = new turismo_uvmEntities();

        }
        
        public ActionResult Portada()
        {
         
            //ViewBag.personas = db.persona.ToList();
            return View();
        }

        public ActionResult Plantilla()
        {
            return View();
        }
    }
}
