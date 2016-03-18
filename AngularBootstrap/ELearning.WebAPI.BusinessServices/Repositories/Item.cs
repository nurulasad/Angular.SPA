using System.Collections.Generic;
using System.Linq;
using ELearning.BusinessServices.Repositories.Interfaces;
using ELearning.DataModel;
using ELearning.BusinessServices.Utility;

namespace ELearning.BusinessServices.Repositories
{
    public class Item
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Answer> Answers;

        public Item()
        {
            Answers = new List<Answer>();
        }

        

    }

    public class Answer
    {
        public string Text { get; set; }
        public string Code { get; set; }
    }

    
}
