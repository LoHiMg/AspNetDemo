using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using car_policy.Models;

namespace car_policy.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View("Login",null);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (model.UserName == "admin" && model.Password == "123456")
            {
                // 验证通过，跳转到指定页面
                return Json(new { redirectUrl = Url.Action("Index", "Home") });
            }
            else
            {
                // 验证失败，返回错误消息
                ModelState.AddModelError("", "用户名或密码不正确");
                Console.WriteLine();
                return View("Login", null);
            }
        }
    }
}