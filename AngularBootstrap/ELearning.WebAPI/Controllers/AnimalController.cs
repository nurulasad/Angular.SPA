using System.Collections.Generic;
using System.Web.Http;
using ELearning.DataModel;
using ELearning.BusinessServices.Repositories;
using ELearning.BusinessServices.Utility;

namespace ELearning.WebAPI.Controllers
{
    public class AnimalController : ApiController
    {



        public List<Animal> Get()
        {
            var repo = new AnimalRepository(new DefaultCacheProvider());
            return repo.Get();
        }
    }
}
