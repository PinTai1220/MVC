﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

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
            return View();
        }
    }
}