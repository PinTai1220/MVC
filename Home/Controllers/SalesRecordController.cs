using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Home.Helpers;
using Home.Models;
using Newtonsoft.Json;
using Home.Filter;

namespace Home.Controllers
{
    public class SalesRecordController : Controller
    {
        /// <summary>
        /// 销售控制器
        /// </summary>
        /// <returns></returns>
        // GET: SalesRecord
        [LoginAuthorization]
        public ActionResult ShowSales()
        {
            string json = HttpClientHelper.SendRequest("api/", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
    }
}