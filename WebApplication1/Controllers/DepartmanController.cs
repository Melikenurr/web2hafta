using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman
        public ActionResult Index()
        {
            Departman departman = new Departman();
            { id = 1; Adi="Bilgi işlem" };
            return View;
        }
        public String Index2()
        {
            return "merhaba Index2";
        }
        public ActionResult Index3()
        {
            Departman departman = new Departman();
            { id = 1; Adi = "Bilgi işlem" };
            return view(deparatman);
        }
    }
}