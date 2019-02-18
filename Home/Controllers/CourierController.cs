using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Controllers
{
    public class CourierController : Controller
    {
        /// <summary>
        /// 快递表控制器
        /// </summary>
        /// <returns></returns>
        // GET: Courier
        public ActionResult Index()
        {
            return View();
        }
    }
}