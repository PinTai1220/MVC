using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Controllers
{
    public class SalesRecordController : Controller
    {
        /// <summary>
        /// 销售控制器
        /// </summary>
        /// <returns></returns>
        // GET: SalesRecord
        public ActionResult ShowSales()
        {
            return View();
        }
    }
}