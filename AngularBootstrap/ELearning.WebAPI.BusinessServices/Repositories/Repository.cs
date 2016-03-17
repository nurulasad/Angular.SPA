using ELearning.BusinessServices.Utility;

namespace ELearning.BusinessServices.Repositories
{
    public class RepositoryBase
    {

  
        protected ICacheProvider CacheProvider;

        public RepositoryBase(ICacheProvider cacheProvider)
        {
            CacheProvider = cacheProvider;
    

            
        }


       
       
    }
}
