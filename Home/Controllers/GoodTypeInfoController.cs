using Home.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;

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
            string json = HttpClientHelper.SendRequest("api/", "Get");
            List<object> attday = JsonConvert.DeserializeObject<List<object>>(json);
            ViewBag.att = attday;
            return View();
        }
    }
}