﻿using InvitacionEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvitacionEventos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Rsvp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Rsvp(Invitaciones response)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(response);
                return View("Thanks", response);
            }
            else
            {
                return View();
            }
        }
        [ChildActionOnly]
        public ActionResult Attendees()
        {
            return View(Repository.Responses.Where(x => x.Asistira == true));
        }
    }
}

