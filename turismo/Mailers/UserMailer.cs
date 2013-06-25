using Mvc.Mailer;
using System;

namespace turismo.Mailers
{ 
    public class UserMailer : MailerBase, IUserMailer 	
	{
		public UserMailer()
		{
			MasterName="_Layout";
		}
		
		public virtual MvcMailMessage Welcome()
		{
            
			//ViewBag.Data = someObject;
			return Populate(x =>
			{
				x.Subject = "Bienvenido a Turismo uvm";
				x.ViewName = "Welcome";
				x.To.Add("nvulloa.uvm@gmail.com");
                x.To.Add("wachimingo@gmail.com");
                
			});
		}
 
		public virtual MvcMailMessage PasswordReset()
		{
			//ViewBag.Data = someObject;
			return Populate(x =>
			{
				x.Subject = "PasswordReset";
				x.ViewName = "PasswordReset";
				x.To.Add("some-email@example.com");
			});
		}

        public virtual MvcMailMessage CorreoConfirmacion(persona p) {
            ViewBag.persona = p; //le pasamos el objeto persona a la vista...
                     //devuelve la vista poblada con datos...
            ViewBag.urlLink = System.Web.HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/Registro/correoConfirmacion/?token=" + p.token;

         return Populate(x => {
              ViewBag.Name = p.nombre_usuario;
              x.ViewName = "CorreoConfirmacion" + p.nombreUsuario;
              //x.To.Add("nvulloa.uvm@gmail.com");
              x.To.Add(p.email);

              x.Subject = "Confirmación de Correo";
        });

}
        


    }
}