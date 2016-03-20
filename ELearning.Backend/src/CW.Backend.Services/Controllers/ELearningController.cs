using Gratex_Project_Template.Repository;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace CW.Backend.Services.Controllers
{
    [RoutePrefix("api/ELearning")]
    [AllowAnonymous]
    public class ELearningController : ApiController
    {
        //private ICategoryRepository repository;
        public ELearningController()
        {
            
        }

        [Route("GetAllAnimal")]
        [HttpGet]
        //[EnableCors(origins: "*",headers: "*",methods: "GET,POST")]
        public HttpResponseMessage GetAllAnimal()
        {
            var repo = new AnimalRepository();

            var items = repo.Get();

            //var categories = new List<string>();

            //for (int i = 0; i < 10; i++)
            //{
            //    var cat = "AniName" + i;
            //    categories.Add(cat);
            //}
            //var data = repository.GetAll();

            var response = Request.CreateResponse(items);
            //For some reason the EnableCors Attribute is not working
            response.Headers.Add("Access-Control-Allow-Origin", "*");
           

            return response;

        }

        
    }
}
