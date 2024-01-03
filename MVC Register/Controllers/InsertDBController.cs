using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Register.Models;

namespace MVC_Register.Controllers
{
    public class InsertDBController : Controller
    {
        MVCEntities1 dbobj = new MVCEntities1();
        // GET: InsertDB
        public ActionResult Insert_PageLoad()
        {
            return View();
        }

        public ActionResult InsertClick(UserInsert clsobj, HttpPostedFileBase file)
        {
            //if (ModelState.IsValid)
            //{
                if (file.ContentLength > 0)
                {
                string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/Images");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);
                    var fullpath = Path.Combine("~\\Images", fname);
                    clsobj.photo = fullpath;
                }
                dbobj.spInsert(clsobj.name, clsobj.age, clsobj.address, clsobj.email, clsobj.photo, clsobj.username, clsobj.password);
                clsobj.message = "Inserted succesfully";
                return View("Insert_PageLoad", clsobj);
            }
            //return View("Insert_PageLoad", clsobj);
        //}
    }
}