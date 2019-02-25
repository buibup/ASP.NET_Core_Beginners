using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApplication.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Book>
            {
                new Book { Title = "Better today", Author = "best"}
            };

            return View(list);
        }
    }
}