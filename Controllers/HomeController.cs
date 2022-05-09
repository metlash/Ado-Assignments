﻿using FootBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.IO;
using System.Data.Entity;


namespace FootBall.Controllers
{
    public class HomeController : Controller
    {
        PlayDbContext context = new PlayDbContext();
        public ActionResult Index()
        {
            return View(context.Teams);
        }

        public ActionResult Create()
        {
            return View();
        }


        public ActionResult CreateAccount(Team a)
        {
            context.Teams.Add(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}