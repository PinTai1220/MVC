using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Controllers
{
    public class ShoppingCartController : Controller
    {
        /// <summary>
        /// 购物车控制器
        /// </summary>
        /// <returns></returns>
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
    }
}