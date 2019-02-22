using System;
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
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpGet]
        public void AdminLogin(string txtname, string txtpwd)
        {
            var post = new Administrator { AdministratorAccount = txtname, AdministratorPwd = txtpwd };
            string result = Helpers.HttpClientHelper.SendRequest("api/Get?jsonStr=" + JsonConvert.SerializeObject(post), "get");
            int n = Convert.ToInt32(JsonConvert.DeserializeObject<Administrator>(result));
            if (n > 0)
            {
                Response.Write("<script>alert('登陆成功!');location.href='/Administrator/Main'</script>");
            }

        }
    }
}