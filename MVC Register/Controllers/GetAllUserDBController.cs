using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Register.Controllers
{
    public class GetAllUserDBController : Controller
    {
        MVCEntities1 dbobj = new MVCEntities1();
        // GET: GetAllUserDB
        public ActionResult DisplayAllUserPageLoad()
        {
            return View(dbobj.RegisterTBs.ToList());
        }
    }
}