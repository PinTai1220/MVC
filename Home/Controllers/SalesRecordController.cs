using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Controllers
{
    public class SalesRecordController : Controller
    {
        //销售记录控制器
        // GET: SalesRecord
        public ActionResult Index()
        {
            return View();
        }
    }
}