using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Site01.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("Login") == null)
            {
                if (context.Controller != null)
                {
                    Controller controlador = context.Controller as Controller;

                    controlador.TempData["MensagemErro"] = "Informe suas credeciais para acessar esta página!";
                }

                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }
}
