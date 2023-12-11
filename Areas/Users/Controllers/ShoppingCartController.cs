using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Areas.Users.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: Users/ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
    }
}