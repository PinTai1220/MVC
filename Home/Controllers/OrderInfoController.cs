using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Home.Helpers;

namespace Home.Controllers
{
    public class OrderInfoController : Controller
    {
        /// <summary>
        /// 订单控制器
        /// </summary>
        /// <returns></returns>
        // GET: OrderInfo
        public ActionResult Index()
        {
            string json = HttpClientHelper.SendRequest("api/", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
    }
}