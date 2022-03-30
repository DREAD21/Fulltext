using System;
using System.Diagnostics;
using System.Linq;
using front.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace front.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        TextContext db;

        public HomeController(ILogger<HomeController> logger, TextContext context)
        {
            _logger = logger;
            db = context;
        }

        [HttpGet]
        public IActionResult Index(string? name)
        {
            IQueryable<Text> _texts = (IQueryable<Text>)db.Texts;

            if (!String.IsNullOrEmpty(name))
            {
                _texts = _texts.Where(p => p.Id == int.Parse(name));
            }
            ViewModel view = new ViewModel
            {
                Texts = _texts.ToList(),
                Name = name

            };
          
            return View(view);
        }
        [HttpPost]
        public IActionResult newElement(string? _text)
        {
            if (!String.IsNullOrEmpty(_text))
            {
                Text text1 = new Text { text = _text };
                db.Texts.Add(text1);
                db.SaveChanges();
            }
            return Redirect("~/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
