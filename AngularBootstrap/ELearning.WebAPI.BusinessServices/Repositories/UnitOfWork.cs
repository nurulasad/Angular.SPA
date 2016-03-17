using ELearning.BusinessServices.Repositories.Interfaces;
using ELearning.BusinessServices.Utility;

namespace ELearning.BusinessServices.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        //private ELearningDbContext _context;
        private ICacheProvider _cacheProvider;

       
        public UnitOfWork(ICacheProvider cacheProvider)
        {
            _cacheProvider = cacheProvider;

            Animals = new AnimalRepository(_cacheProvider);
        
        }



        public IAnimalRepository Animals { get; set; }

     

        //public int Save()
        //{
        //    return _context.SaveChanges();
        //}
       
    }
}
