using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Home.Models;
using Home.Helpers;
using Newtonsoft.Json;

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
            string json = HttpClientHelper.SendRequest("api/", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
    }
}