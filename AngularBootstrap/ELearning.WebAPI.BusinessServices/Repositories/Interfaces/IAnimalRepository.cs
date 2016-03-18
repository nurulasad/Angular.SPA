using ELearning.DataModel;
using System.Collections.Generic;

namespace ELearning.BusinessServices.Repositories.Interfaces
{
    public interface IAnimalRepository: IRepository<Animal>
    {
        List<Item> GetItems();
    }
}
