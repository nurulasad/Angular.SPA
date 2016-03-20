namespace Gratex_Project_Template.Models
{
    using System.Data.Entity;
    using ELearning.BusinessServices.Models;
    public partial class ELearningDbContext : DbContext
    {
        public ELearningDbContext()
            : base("name=ELearning")
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
