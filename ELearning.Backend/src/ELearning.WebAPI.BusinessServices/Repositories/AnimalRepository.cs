using ELearning.BusinessServices.Models;
using ELearning.DataModel;
using Gratex_Project_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gratex_Project_Template.Repository
{
    public class AnimalRepository
    {

        private ELearningDbContext context = new Models.ELearningDbContext();

        public List<Animal> Get() {
            return context.Animals.ToList();
        }
    }
}