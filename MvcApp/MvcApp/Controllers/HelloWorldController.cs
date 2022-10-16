using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using System.Reflection.Metadata;

namespace MvcApp.Controllers
{
    public class HelloWorldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            
            return View(dogs);

        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public String Hello()
        {
            return "Who's there?";
        }
    }
}
