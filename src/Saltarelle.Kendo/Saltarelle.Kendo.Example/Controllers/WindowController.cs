﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Saltarelle.Kendo.Example.Controllers
{
    public class WindowController : Controller
    {
        //
        // GET: /Window/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjaxContent()
        {
            return PartialView();
        }

    }
}
