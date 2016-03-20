namespace ELearning.BusinessServices.Models
{
    using DataModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Answer")]
    public class Answer : EntityBase
    {

        [Key]
        public int AnswerID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

    }
}
