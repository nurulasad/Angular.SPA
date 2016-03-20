using ELearning.BusinessServices.Models;
using ELearning.BusinessServices.Repositories.Interfaces;
using ELearning.DataModel;
using Gratex_Project_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gratex_Project_Template.Repository
{
    public class AnimalRepository : IAnimalRepository
    {

        private ELearningDbContext context = new Models.ELearningDbContext();

        public void Add(Animal entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Animal entity)
        {
            throw new NotImplementedException();
        }

        public List<Animal> Get() {
            return context.Animals.ToList();
        }

        public Animal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Animal entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}