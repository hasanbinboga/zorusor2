﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace BilisselBeceriler.Portal.Core
{
    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            //LoggerService.Log.Error("Controller", filterContext.Exception);
            base.OnException(filterContext);
            
        }
    }
}
