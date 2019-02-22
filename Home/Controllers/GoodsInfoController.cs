using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Home.Helpers;
using Home.Models;

namespace Home.Controllers
{
    public class GoodsInfoController : Controller
    {
        /// <summary>
        /// 商品控制器
        /// </summary>
        /// <returns></returns>
        // GET: GoodsInfo
        public ActionResult GoodsIndex()
        {
            string json = HttpClientHelper.SendRequest("api/Courier/GetSum/?str=&IndexPage=1&IndexSize=8", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
        public ActionResult AddGoods()
        {
            return View();
        }
        public ActionResult Addgoods()
        {
            return View();
        }
        public ActionResult Updgoods(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        public ActionResult Showgoods()
        {
            return View();
        }

    }
}