using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.CustomFilter
{
    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        //Hata anında belirleğimiz sayfaya yönlendirilir. 
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            filterContext.Controller.TempData["error"] = filterContext.Exception;
            filterContext.Result = new RedirectResult("~/Error/Index");
        }
    }
}