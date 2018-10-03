using Chat.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chat.Web.Controllers
{
    [Log]
    public class AngularChatController : Controller
    {
        /// <summary>
        /// Returns Index page for Angular Chat Application
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Returns Chat Page as a view for Angular Chat Application
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Chat()
        {
            return View();
        }


        /// <summary>
        /// Returns About Us Page as a view for Angular Chat Application
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
    }
}