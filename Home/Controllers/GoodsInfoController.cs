﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Home.Controllers
{
    public class GoodsInfoController : Controller
    {
        /// <summary>
        /// 商品控制器
        /// </summary>
        /// <returns></returns>
        // GET: GoodsInfo
        public ActionResult Index()
        {
            return View();
        }
    }
}