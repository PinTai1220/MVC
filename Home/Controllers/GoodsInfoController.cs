using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Home.Helpers;
using Home.Models;
using Home.Filter;

namespace Home.Controllers
{
    public class GoodsInfoController : Controller
    {
        /// <summary>
        /// 商品控制器
        /// </summary>
        /// <returns></returns>
        [LoginAuthorization]
        public ActionResult Addgood()
        {
            return View();
        }
        [LoginAuthorization]
        public ActionResult Updgoods(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [LoginAuthorization]
        public ActionResult Showgoods()
        {
            return View();
        }

    }
}