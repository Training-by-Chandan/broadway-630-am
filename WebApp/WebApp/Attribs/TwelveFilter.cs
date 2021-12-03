using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Attribs
{
    public class TwelveFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Form["Test"] == "12")
            {
                base.OnActionExecuting(filterContext);
            }
            else
            {
                var result = new ViewResult();
                result.ViewName = "~/Views/Home/Index.cshtml";
                filterContext.Result = result;
            }
        }
    }
}
