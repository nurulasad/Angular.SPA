using ELearning.BusinessServices.Models;
using Gratex_Project_Template.Models;
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
        public ELearningController()
        {
            
        }

        [Route("GetAllAnimal")]
        [HttpGet]
        //[EnableCors(origins: "*",headers: "*",methods: "GET,POST")]
        public HttpResponseMessage GetAllAnimal()
        {
            var animalRepo = new AnimalRepository();
            var answerRepo = new AnswerRepository();

            var quiz = new Quiz();
            quiz.Animals = animalRepo.Get();

            quiz.Answers = answerRepo.Get();



            var response = Request.CreateResponse(quiz);
            //For some reason the EnableCors Attribute is not working
            response.Headers.Add("Access-Control-Allow-Origin", "*");
           

            return response;

        }


        public class Quiz {

            public List<Animal> Animals { get; set; }
            public List<Answer> Answers { get; set; }

        }
        
    }
}
