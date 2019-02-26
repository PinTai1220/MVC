﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Home.Helpers;
using Newtonsoft.Json;
using Home.Models;
namespace Home.Controllers
{
    public class AdministratorController : Controller
    {
        /// <summary>
        /// 管理员控制器
        /// </summary>
        /// <returns></returns>
        // GET: Administrator
        [AllowAnonymous]
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public void Login(string txtname, string txtpwd)
        {
            string result = Helpers.HttpClientHelper.SendRequest("api/Administrator/Login?AdministratorAccount=" + txtname+ "&AdministratorPwd="+txtpwd, "get");
            if (int.Parse(result) > 0)
            {
                Response.Write("<script>location.href='/Administrator/Main'</script>");
            }
        }
        public ActionResult Main()
        {
            return View();
        }
    }
}