using PetShop.Models;

namespace PetShop.Repositories
{
    public interface IRepository
    {
        public IEnumerable<Animal>? GetAnimals();
        public IEnumerable<Category>? GetCategorys();
        public Category GetCategory(int id);
        public void DeleteAnimal(int id);
        public void AddAnimal(Animal animal);
        public void AddComment(Comment comment);
        public Animal GetMosrCommented();
        public Animal GetSecondMosrCommented();
        public void UpdateAnimal(Animal Updated);
    }
}
