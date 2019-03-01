﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Home.Helpers;
using Home.Models;
using Home.Filter;

namespace Home.Controllers
{
    public class UserInfoController : Controller
    {
        /// <summary>
        /// 用户表控制器
        /// </summary>
        /// <returns></returns>
        // GET: UserInfo
        [HttpGet]
        [LoginAuthorization]
        public ActionResult UserIndex()
        {
            string json = HttpClientHelper.SendRequest("api/User/GetAll?str=&PageIndex=1&PageSize=4", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
        public ActionResult UserResult()
        {
            return View();
        }
        public ActionResult CeShi()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(string Name,string Pwd)
        {

            return View();
        }
    }
}
