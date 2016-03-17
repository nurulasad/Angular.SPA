using System.Collections.Generic;
using System.Linq;
using ELearning.BusinessServices.Repositories.Interfaces;
using ELearning.DataModel;
using ELearning.BusinessServices.Utility;

namespace ELearning.BusinessServices.Repositories
{
    public class AnimalRepository: RepositoryBase, IAnimalRepository
    {
        MockDbContext data;
        public AnimalRepository(ICacheProvider cacheProvider):base(cacheProvider)
        {
            var data = new MockDbContext();
        }

        

        public void Add(Animal entity)
        {
            data.Animals.Add(entity);
        }

        public void Delete(Animal entity)
        {
            var item = data.Animals.Where(x=>x.AnimalId == entity.AnimalId).SingleOrDefault();
            data.Animals.Remove(item);
        }

        public List<Animal> Get()
        {
            return data.Animals;
        }

        public Animal GetById(int id)
        {
            return data.Animals.Where(x => x.AnimalId == id).SingleOrDefault();
            
        }

      

        public void Update(Animal entityToUpdate)
        {
            var item = data.Animals.Where(x => x.AnimalId == entityToUpdate.AnimalId).SingleOrDefault();
            item = entityToUpdate;
        }
    }
}
