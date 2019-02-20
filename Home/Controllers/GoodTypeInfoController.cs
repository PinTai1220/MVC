using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data;
using Home.Helpers;
using Home.Models;

namespace Home.Controllers
{
    public class GoodTypeInfoController : Controller
    {
        /// <summary>
        /// 商品分类控制器
        /// </summary>
        /// <returns></returns>
        // GET: GoodTypeInfo
        public ActionResult Index()
        {
            string json = HttpClientHelper.SendRequest("api/", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
    }
}