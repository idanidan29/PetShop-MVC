using Microsoft.AspNetCore.Mvc;
using PetShop.Data;
using PetShop.Models;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController (IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.MostCommented =_repository.GetMosrCommented();
            ViewBag.SecondMostCommented =_repository.GetSecondMosrCommented();

            if (ViewBag.MostCommented != null) { ViewBag.NumofComments = "Number of comments"; }
            
            return View();
        }
    }
}
