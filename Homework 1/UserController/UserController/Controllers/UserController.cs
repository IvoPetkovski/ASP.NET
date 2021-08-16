using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserController.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // ViewResult
        [Route("User")]
        public IActionResult GetUser()
        {
            return View("User");
        }

        // RedirectResult
        public IActionResult GetContact()
        {
            return RedirectToAction("Admin", "Admin");
        }

        // EmptyResult
        [Route("Empty")]
        public IActionResult GetEmpty()
        {
            return new EmptyResult();
        }

        [Route("Id/{id}")]
        public IActionResult GetId(int? id)
        {
            if (id.HasValue)
            {
                return View("User");
            }
            else
            {
                return new EmptyResult();
            }
        }

    }
}