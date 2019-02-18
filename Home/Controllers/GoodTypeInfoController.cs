using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

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
            return View();
        }
    }
}