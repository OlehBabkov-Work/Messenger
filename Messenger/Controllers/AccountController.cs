using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web;
using System.Web.Mvc;
using Messenger.Models;

namespace Messenger.Controllers
{
    public class AccountController : Controller
    {
        UserContext db = new UserContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {

        }
    }
}