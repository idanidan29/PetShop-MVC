using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PetShop.Data;
using PetShop.Models;
using PetShop.Repositories;
using System;

namespace PetShop.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IRepository _repository;

        public CatalogController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var categories = _repository.GetCategorys();
            return View(categories);
        }
        public IActionResult Parchuse(int id)
        {
            _repository.DeleteAnimal(id);
            return RedirectToAction("Index");
        }
        public IActionResult AnimalPage(int id)
        {
            var animal=_repository.GetAnimals()?.Single(a => a.Id == id);
            ViewBag.Animal = animal;
            return View();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {

            if (!ModelState.IsValid) { return RedirectToAction("AnimalPage", new { id = comment.AnimalId }); }

            _repository.AddComment(comment);
            return RedirectToAction("AnimalPage", new {id=comment.AnimalId});

        }
        public IActionResult ShowCategory(int id)
        {
            var category=_repository.GetCategory(id);
            return View(category);
        }
    }
}
