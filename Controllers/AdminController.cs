using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Plugins;
using PetShop.Models;
using PetShop.Repositories;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PetShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepository _repository;

        public AdminController(IRepository repository)
        {
            _repository = repository;
        }
        
        
        public IActionResult Index()
        {
            var categories = _repository.GetCategorys();
            return View(categories);
        }
        public IActionResult Delete(int id)
        {
            _repository.DeleteAnimal(id);
            return RedirectToAction("Index");
        }
        public IActionResult EditPage(int id)
        {
            var animal = _repository?.GetAnimals()?.Single(a => a.Id == id);
            return View(animal);
        }
        [HttpPost]
        public IActionResult UpdateEdit(Animal animal)
        {
            if (!ModelState.IsValid)
            { return View("EditPage",animal); }

            _repository?.UpdateAnimal(animal);
            return RedirectToAction("Index");
        }


        public IActionResult NewAnimalPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewAnimal(Animal animal)
        {
            if (!ModelState.IsValid) 
            { return View("NewAnimalPage"); }
            
          
            _repository.AddAnimal(animal);
            return RedirectToAction("Index");
        }
        
    }
}
