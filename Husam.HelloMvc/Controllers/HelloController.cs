using Microsoft.AspNetCore.Mvc;
using Husam.HelloMvc.Models;

namespace Husam.HelloMvc.Controllers
{
    public class HelloController : Controller
    {
        // GET: /Hello/Greet
        [HttpGet]
        public IActionResult Greet()
        {
            return View(new GreetViewModel());
        }

        // POST: /Hello/Greet
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Greet(GreetViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Message = $"Hello, {model.Name}!";
            return View(model);
        }

        // (Optional) Your previous Index action can stay here too.
    }
}