using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2.Controllers
{
    public class DirectoresController : Controller
    {
        public DirectoresController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
