using ASP.Exo.HelpersData.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Exo.HelpersData.Controllers
{
    public class AspUserController : Controller
    {
        public ActionResult Register()
        {
            AspUserRegisterForm data = new AspUserRegisterForm();
            return View(data);
        }
        [HttpPost]
        public ActionResult Register(AspUserRegisterForm form)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                AspUserRegisterForm data = new AspUserRegisterForm();
                return View(data);
            }
        }
    }
}