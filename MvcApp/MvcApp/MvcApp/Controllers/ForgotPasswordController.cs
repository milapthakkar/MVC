﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class ForgotPasswordController : Controller
    {
        //
        // GET: /ForgotPassword/

        public ActionResult Index()
        {
            return View();
        }

    }
}
