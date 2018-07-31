﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopOnline.Models;

namespace ShopOnline.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MessageModel message = new MessageModel();
            message.Wellcome = "Wellcome to Myshop";
            return View(message);
        }
    }
}