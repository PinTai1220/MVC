using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Controllers
{
    public class AdministratorController : Controller
    {
        /// <summary>
        /// 管理员控制器
        /// </summary>
        /// <returns></returns>
        // GET: Administrator
        public ActionResult Index()
        {

            return View();
        }
    }
}