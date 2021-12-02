using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Controllers
{
    public class SeriesController : Controller
    {
        public SeriesController()
        {

        }
            public ActionResult Index()
            {
                return View();
            }
        public ActionResult Nuevo()
        {
            return View();
        }
    }
}
