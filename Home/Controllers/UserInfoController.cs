using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Home.Helpers;
using Home.Models;

namespace Home.Controllers
{
    public class UserInfoController : Controller
    {
        /// <summary>
        /// 用户表控制器
        /// </summary>
        /// <returns></returns>
        // GET: UserInfo
        public ActionResult UserIndex()
        {
            string json = HttpClientHelper.SendRequest("api/", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
    }
}