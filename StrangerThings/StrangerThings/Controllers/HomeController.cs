﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrangerThings.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            List<SelectListItem> CommentTopic = new List<SelectListItem>();
            CommentTopic.Add(new SelectListItem { Text = "Help", Value = "0" });
            CommentTopic.Add(new SelectListItem { Text = "Troubleshoot", Value = "1" });
            CommentTopic.Add(new SelectListItem { Text = "Questions", Value = "2", Selected = true });
            ViewBag.Comment = CommentTopic;

            return View();
        }
    }
}