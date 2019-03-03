using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Home.Helpers;
using Home.Filter;

namespace Home.Controllers
{
    public class OrderInfoController : Controller
    {
        /// <summary>
        /// 订单控制器
        /// </summary>
        /// <returns></returns>
        // GET: OrderInfo
        [LoginAuthorization]
        public ActionResult OrderInfoIndex()
        {
            string json = HttpClientHelper.SendRequest("api/OrderInfo/List/?str=&IndexPage=1&IndexSize=8", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
    }
}