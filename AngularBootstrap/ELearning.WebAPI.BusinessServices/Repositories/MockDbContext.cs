using ELearning.DataModel;
using System.Collections.Generic;

namespace ELearning.BusinessServices.Repositories
{
    public class MockDbContext : IELearningDbContext
    {
        public MockDbContext()
        {
        }




        public List<Animal> Animals = new List<Animal>();

    }
}
