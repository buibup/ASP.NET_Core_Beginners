using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var upBook = new Book
            {
                Title = "Book is great",
                Author = "buibup"
            };

            return View(upBook);
        }
    }
}