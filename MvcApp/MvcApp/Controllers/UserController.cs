using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private static Users _users = new Users();
        private UserModels userModel;

        public ActionResult Index()
        {
            return View(_users._userList);
        }
        public ActionResult UserAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserAdd(UserModels usermodel)
        {
            _users.CreateUser(userModel);
            return View();
        }
        public ContentResult Test()
        {
            return Content("This is my test data");
        }

    }
}