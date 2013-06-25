using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc.Mailer;
using turismo.Mailers;
namespace turismo.Controllers
{
    public class MailersController : Controller
    {
        //
        // GET: /Mailers/
        private IUserMailer _userMailer = new UserMailer();
        public IUserMailer UserMailer
        {
            get { return _userMailer; }
            set { _userMailer = value; }
        }
        public ActionResult Index()
        {
            UserMailer.Welcome().Send();
            return View();
        }

    }
}
