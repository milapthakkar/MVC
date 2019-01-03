using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Areas.Admin.Controllers
{
    public class TableController : Controller
    {
        // GET: Admin/Table
        public ActionResult Index()
        {
            return View();
        }
    }
}