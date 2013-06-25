using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using turismo.Helpers;


namespace turismo.Controllers
{
    public class EmailController : Controller
    {
        //
        // GET: /Email/

        public ActionResult enviarCorreo()
        {

           EmailFactory factory = new EmailFactory();

           factory.agregarDestinatario("ghostdisk@hotmail.cl");
           factory.agregarDestinatario("csaldiasrussell@gmail.com");
           //factory.agregarDestinatario("pedrocarrasco@gmail.com");
           factory.enviarCorreo("Turismo uvm","Este correo esta enviado desde la paguina web www.turismouvm.cl y se mamaran este corre cada vez que cargue la paguina Saludos wetas");
            return View();
        }

    }
}
