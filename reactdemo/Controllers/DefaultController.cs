using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reactdemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getRepos()
        {
            HttpContext.Session["repo"] = "some repo data";
            return Json(HttpContext.Session["repo"], JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult addRepo(string repoResult)
        {
            HttpContext.Session["repo"] = repoResult;
            return Json(repoResult, JsonRequestBehavior.AllowGet);
        }
    }
}