using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Register.Models;

namespace MVC_Register.Controllers
{
    public class ProfileDBController : Controller
    {
        MVCEntities1 dbobj = new MVCEntities1();
        // GET: ProfileDB
        public ActionResult ProfilePageLoad()
        {
            var getData = dbobj.spProfileView(Session["uname"].ToString()).FirstOrDefault();

            return View(new UserProfile
            {
                name = getData.name,
                age = getData.age,
                address = getData.address,
                email = getData.email,
                photo = getData.photo
            });
        }

        public ActionResult ProfileUpdate(UserProfile clsobj)
        {
            dbobj.spUpdate(Session["uname"].ToString(), clsobj.age, clsobj.address);

            var getData = dbobj.spProfileView(Session["uname"].ToString()).FirstOrDefault();
            return View("ProfilePageLoad", new UserProfile
            {
                name = getData.name,
                age = getData.age,
                address = getData.address,
                email = getData.email,
                photo = getData.photo
            });
        }
    }
}