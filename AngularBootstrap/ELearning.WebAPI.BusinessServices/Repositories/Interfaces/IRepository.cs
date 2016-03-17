using ELearning.DataModel;
using System.Collections.Generic;


namespace ELearning.BusinessServices.Repositories.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        List<T> Get();
        void Add(T entity);
      
        void Update(T entityToUpdate);

        void Delete(T entity);

    }
}
