using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Home.Models;
using Home.Helpers;
using Newtonsoft.Json;

namespace Home.Controllers
{
    public class CourierController : Controller
    {
        /// <summary>
        /// 快递表控制器
        /// </summary>
        /// <returns></returns>
        // GET: Courier
        public ActionResult Index()
        {
            //string json = HttpClientHelper.SendRequest("api/", "Get");
            //List<Courier> attday = JsonConvert.DeserializeObject<List<Courier>>(json);
            return View(/*attday*/);
        }
        public ActionResult Addorder()
        {
            return View();
        }
        
    }
}