using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Home.Filter;

namespace Home.Controllers
{
    public class AddressInfoController : Controller
    {
        /// <summary>
        /// 地址表控制器
        /// </summary>
        /// <returns></returns>
        // GET: AddressInfo
        [LoginAuthorization]
        public ActionResult Index()
        {
            return View();
        }
    }
}