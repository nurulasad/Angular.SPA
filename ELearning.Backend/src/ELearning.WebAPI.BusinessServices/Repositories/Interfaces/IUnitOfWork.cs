using System;


namespace ELearning.BusinessServices.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IAnimalRepository Animals { get; }


        //int Save();
    }
}
