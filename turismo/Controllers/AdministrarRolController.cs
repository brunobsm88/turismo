using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using turismo.ViewModel.AdministrarRol;

namespace turismo.Controllers
{
    public class AdministrarRolController : Controller
    {
        
        //
        // GET: /AdministrarRol/
        public turismo_uvmEntities db;
       
        public ActionResult panelAdministrativo()
        {   
            //(en constructor)
            db = new turismo_uvmEntities();
            //los view
            ViewBag.roles = db.rol.ToList();
            ViewBag.programas = db.programa.ToList();
            ViewBag.personas = db.persona.ToList();
            ViewBag.suscripciones = db.suscripcion.ToList();
            return View();
        }

    }
}
