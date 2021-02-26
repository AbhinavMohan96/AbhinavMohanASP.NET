using AbhinavMohanASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLIbrary;
using DataLIbrary.BusinessLogic;

namespace AbhinavMohanASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Abhinav Mohan - Full Stack Developer, ASP.NET MVC and ReactJS";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MessagingApp()
        {
            ViewBag.Message = "Messaging App";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MessagingApp(MessagingModel model)
        {
            if (ModelState.IsValid)
            {
                int messageCreated = MessageProcessor.CreateMessage(model.DisplayName, 
                    model.Location, 
                    model.Message, 
                    model.Visible);
                return RedirectToAction("Index");       
            } 

            return View();
        }
    }
}