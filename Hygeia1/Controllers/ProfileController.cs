using Hygeia1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hygeia1.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/Index/name

        public ActionResult Index(int ID)
        {
         
            return View(Member.ReturnMember(ID));
        }

    }
}
