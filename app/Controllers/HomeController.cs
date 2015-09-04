using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult tmpWidgets()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult tmpChartsChartsJs()
        {
            return View();
        }
        public ActionResult tmpChartsMorris()
        {
            return View();
        }
        public ActionResult tmpChartsFlot()
        {
            return View();
        }
        public ActionResult tmpChartsInline()
        {
            return View();
        }
        public ActionResult tmpUIGeneral()
        {
            return View();
        }
        public ActionResult tmpUIIcons()
        {
            return View();
        }
        public ActionResult tmpUIButtons()
        {
            return View();
        }
        public ActionResult tmpUISliders()
        {
            return View();
        }
        public ActionResult tmpUITimeline()
        {
            return View();
        }
        public ActionResult tmpUIModals()
        {
            return View();
        }
        public ActionResult tmpFormsGeneral()
        {
            return View();
        }
        public ActionResult tmpFormsAdvanced()
        {
            return View();
        }
        public ActionResult tmpFormsEditor()
        {
            return View();
        }
        public ActionResult tmpTablesSimple()
        {
            return View();
        }
        public ActionResult tmpTablesData()
        {
            return View();
        }
        public ActionResult tmpCalendar()
        {
            return View();
        }
        public ActionResult tmpMailbox()
        {
            return View();
        }

        public PartialViewResult tmpMailCompose(AjaxOptions ajaxOptions)
        {
            return PartialView("_tmpMailCompose");
        }

        public ActionResult TmpMailboxList()
        {
            return PartialView("_tmpMailboxList");
        }
    }
}