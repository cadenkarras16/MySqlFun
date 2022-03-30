using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySqlFun.Models;

namespace MySqlFun.Controllers
{
    public class HomeController : Controller
    {

        private IBowlersRepository _repo { get; set; }

        public HomeController(IBowlersRepository temp)
        {
            //constructor
            _repo = temp;
        }

        public IActionResult Index()
        {
            var blah = _repo.Bowlers
                .ToList();

            
            return View(blah);
        }

    }
}
