using ELearning.DataModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELearning.BusinessServices.Models
{

    [Table("Animal")]
    public class Animal : EntityBase
    {
        [Key]
        public int AnimalID { get; set; }

        public int AnswerID { get; set; }

      
        public string Item { get; set; }

  
        public string Name { get; set; }

  
        public string Code { get; set; }
        
    }
}
