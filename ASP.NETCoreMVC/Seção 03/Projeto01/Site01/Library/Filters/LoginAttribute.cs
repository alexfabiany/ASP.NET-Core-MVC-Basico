using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Verificar se a sessão existe
            if (context.HttpContext.Session.GetString("Login") == null)
            {
                // Redirecionar
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }
}
