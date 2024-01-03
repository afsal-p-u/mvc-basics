using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Register.Models;
using System.Web.Mvc;
using System.Data.Entity.Core.Objects;

namespace MVC_Register.Controllers
{
    public class LoginDBController : Controller
    {
        MVCEntities1 dbobj = new MVCEntities1();
        // GET: LoginDB
        public ActionResult LoginPageLoad()
        {
            return View();
        }
        public ActionResult LoginClick(UserLogin clsobj)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(clsobj.username, clsobj.password, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    Session["uname"] = clsobj.username;
                    return RedirectToAction("Home");
                } else
                {
                    ModelState.Clear();
                    clsobj.message = "Invalid login";
                    return View("LoginPageLoad", clsobj);
                }
            }
            return View("LoginPageLoad", clsobj);
        }

        public ActionResult Home()
        {
            return View();
        }
    }
}