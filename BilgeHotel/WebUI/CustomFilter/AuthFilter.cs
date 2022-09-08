﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.CustomFilter
{
    public class AuthFilter: FilterAttribute, IAuthorizationFilter
    {
        //Oturum açılmaması durumunda login sayfasına geri yönlendirir.
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["login"] == null)  
            {
                filterContext.Result = new RedirectResult("~/Home/Login"); 
            }
        }
    }
}