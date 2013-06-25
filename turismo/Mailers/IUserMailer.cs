using Mvc.Mailer;

namespace turismo.Mailers
{ 
    public interface IUserMailer
    {
			MvcMailMessage Welcome();
			MvcMailMessage PasswordReset();
            MvcMailMessage CorreoConfirmacion(persona p);
    }
}