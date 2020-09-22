using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLoginApp.Models;

namespace TestLoginApp.Controllers
{
    public class TestController : Controller
    {
        public readonly string username = "thanos@gmail.com";

        public readonly string password = "kapsalis";
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoginUser(UserModel model)  //opws eipame kai sto ajax ta stoixeia pou 8eloume na steiloume prepei na exoun tin idia  morfi
        //me to usermodel kai to onoma tou adikeimenoy idio me to seriallized json poy kaname sthn js.
        {
            if (model.username == username & model.password == password) 
                return Json(new {success=true});
            return Json(new {success = false});
        }
    }
}