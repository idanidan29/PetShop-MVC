using PetShop.Data;
using PetShop.Models;
using System;

namespace PetShop.Repositories
{
    public class MyRepository:IRepository
    {
        private readonly MyDBContext _context;

        public MyRepository(MyDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Animal>? GetAnimals()
        {
            return _context.animals?.ToList();
        }
        public IEnumerable<Category>? GetCategorys()
        {
            return _context.categories?.ToList();
        }
        public Category GetCategory(int id)
        {
            var category = _context.categories?.SingleOrDefault(c => c.CategoryId == id);
            return category ;
        }
        public void DeleteAnimal(int id)
        {
            var aniaml = _context.animals?.SingleOrDefault(a => a.Id == id);
            if (aniaml != null) _context.animals?.Remove(aniaml);
            _context.SaveChanges();
        }
        public void AddAnimal(Animal animal) 
        {
            _context.animals?.Add(animal);
            _context.SaveChanges();
        }
        public void AddComment(Comment comment)
        {
            _context.Add(comment);
            _context.SaveChanges();
        }
        public Animal GetMosrCommented()
        {
            Animal? mostCommented=null;
            int comments = 0;
            foreach(Animal animal in _context.animals)
            {
                if (animal.comments.Count > comments && mostCommented == null)
                {mostCommented = animal;}

                if (mostCommented != null && animal.comments.Count > mostCommented.comments.Count)
                {mostCommented = animal;}
            }
            if (mostCommented == null) { return null; }
            return mostCommented;
        }
        public Animal GetSecondMosrCommented()
        {
            Animal? MostCommented =GetMosrCommented();
            Animal? SeconfMostCommented = null;
            int comments = 0;
            foreach (Animal animal in _context.animals)
            {
                if (animal.comments.Count > comments && SeconfMostCommented == null&&animal!=MostCommented)
                {SeconfMostCommented = animal;}

                    if (SeconfMostCommented != null && animal.comments.Count > SeconfMostCommented.comments.Count&&animal!=MostCommented)
                {SeconfMostCommented = animal;}
            }
            if (SeconfMostCommented == null) { return null; }
            return SeconfMostCommented;
        }
        public void UpdateAnimal(Animal Updated) 
        {
            var aniaml = _context.animals?.SingleOrDefault(a => a.Id == Updated.Id!);
            aniaml.Name=Updated.Name;
            aniaml.Age = Updated.Age;
            aniaml.Description=Updated.Description;
            aniaml.Picture = Updated.Picture;
            aniaml.CategoryId = Updated.CategoryId;
            
            _context.SaveChanges();
        }
       
      
    }
}
