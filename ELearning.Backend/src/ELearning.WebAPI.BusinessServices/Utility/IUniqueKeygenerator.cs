using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace PCS.ELearningWebAPI.BusinessServices.Utility
{

    public interface IUniqueKeygenerator<T>
    {

        string GetHashkey(T input);
    }
}
