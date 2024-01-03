using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Core.Objects;
using MVC_Register.Models;

namespace MVC_Register.Controllers
{
    public class ChangePasswordDBController : Controller
    {
        MVCEntities1 dbobj = new MVCEntities1();
        // GET: ChangePasswordDB
        public ActionResult ChangePasswordPageLoad()
        {
            return View();
        }

        public ActionResult ChangePasswordClick(UserPassword clsobj)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.spUpdatePassword(Session["uname"].ToString(), clsobj.oldpassword, clsobj.newpassword, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    clsobj.message = "Password changed";
                    return View("ChangePasswordPageLoad", clsobj);
                } else
                {
                    clsobj.message = "Invalid message";
                    return View("ChangePasswordPageLoad", clsobj);
                }
            }
            return View("ChangePasswordPageLoad", clsobj);
        }
    }
}