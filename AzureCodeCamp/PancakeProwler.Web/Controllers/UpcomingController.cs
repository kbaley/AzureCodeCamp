﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PancakeProwler.Web.Controllers
{
    public class UpcomingController : Controller
    {
        //
        // GET: /Upcoming/

        public ActionResult Index()
        {
            return View();
        }

    }
}