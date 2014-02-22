using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.Practices.Unity;

namespace UnityMVC_DepResolver.Controllers
{
    public class HomeController : Controller
    {
        private ISomeContent _content;

        // For Property injection
        //[Dependency]
        //public ISomeContent someContent
        //{
        //    get { return _content; }
        //    set { this._content = value; }
        //}

        public HomeController()
        {
            // This should be a default??
            _content = null;
        }

        // For constructor injection

        public HomeController(ISomeContent cont)
        {
            this._content = cont;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _content.theContent;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = _content.helpAboutContent;
            return View();
        }
    }
}
