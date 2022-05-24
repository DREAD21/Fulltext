using System;
using System.Diagnostics;
using System.Linq;
using front.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Korzh.EasyQuery.Linq;


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

        public IActionResult Index(string name, string full_name)
        {
            IQueryable<Text> _texts = (IQueryable<Text>) db.Texts;
            IQueryable<Text> _full_name = db.Texts;

            if (!String.IsNullOrEmpty(name))
            {
                _texts = db.Texts.Where(p => p.Id == int.Parse(name));
            }

            if (!String.IsNullOrEmpty(full_name))
            {
                string new_name = full_name.Remove(0, full_name.IndexOf(',')+2);
                if (full_name.Substring(0, full_name.IndexOf(',')) == "FreeText")
                {
                    
                    _full_name = db.Texts.FullTextSearchQuery(new_name);
                }
                if (full_name.Substring(0, full_name.IndexOf(',')) == "Contains")
                {
                    _full_name = null;
                }
            }

            ViewModel view = new ViewModel 
            {
                Texts = _texts.ToList(),
                Name = name,
                Full_Texts = _full_name.ToList()
            };
          
            return View(view);
        } return View(view);
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
