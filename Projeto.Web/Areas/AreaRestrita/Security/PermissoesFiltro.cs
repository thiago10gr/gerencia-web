using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Web.Areas.AreaRestrita.Security
{
    public class PermissoesFiltro : AuthorizeAttribute
    {

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            //Caso o usuário não esteja autorizado, ele será redirecionado para a página /Home/AcessoNegado
            if(filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.HttpContext.Response.Redirect("/Home/AcessoNegado");
            }
        }
    }
}