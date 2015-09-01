using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dependency2.Models;

namespace dependency2.Controllers
{
    public class houseController : Controller
    {
        //
        // GET: /house/
       
        public ActionResult Index()
        {
            var hc = new houseContext();
            List<house> hm = hc.houses.ToList();
            return View(hm);
        }

    }
}
