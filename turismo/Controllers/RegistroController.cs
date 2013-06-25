using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using turismo.ViewModel.Registro;
using turismo.Helpers;
using turismo.Mailers;
using Mvc.Mailer;
using System.Diagnostics;

namespace turismo.Controllers
{
    public class RegistroController : Controller
    {
        private IUserMailer _userMailer = new UserMailer();
        public IUserMailer UserMailer
        {
            get { return _userMailer; }
            set { _userMailer = value; }
        }
        public turismo_uvmEntities db;
        

        public ActionResult nuevoRegistro()
        {
            RegistroViewModel nuevo = new RegistroViewModel();

            return View(nuevo);
        }
        [HttpPost]
        public ActionResult nuevoRegistro(RegistroViewModel input) {
         
            try{
            
            if (ModelState.IsValid)
            {
                    persona p = new persona();
                    p.email = input.email;
                    p.password = input.contraseña;
                    p.rol_id = 3;
                    p.nombre_usuario = "anonimus";
                    p.token = Guid.NewGuid().ToString();
                    ViewBag.linkUrl = "?token=" + p.token;
                    //VIewBag.urlLink = System.Web.HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/Account/ConfirmAccount?token=" + token;
                    
                    MvcMailMessage mail = UserMailer.CorreoConfirmacion(p);
                    mail.Send();
                    //(en constructor)
                    db = new turismo_uvmEntities();
                    //luego para guardar
                    db.persona.Add(p);
                    db.SaveChanges();

                    return RedirectToAction("Terminos", new { Id = p.id });
                }
              }
                catch (Exception e) {
                    ModelState.AddModelError("email",e.Message);
                }
                
            return View(input);
        }

        //**===================================================================================================*/


        public ActionResult Terminos( int id)
        {

           
           return View();
        }

        //**===================================================================================================*/
        //[AllowAnonymous]
        //[HttpGet]
        public ActionResult confirmacionCorreo()
        {
            
            return View();
        }
        public ActionResult correoConfirmacion()
        {

            return View();
        }
        public ActionResult recuperarContraseña()
        {
            return View();
        }
        public ActionResult envioRecuperarContraseña()
        {
            return View();
        }
        

        public string email { get; set; }

        public string token { get; set; }
    }
}