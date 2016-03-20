using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS.ELearningWebAPI.BusinessServices
{
    public static class Helper
    {
        public static bool NullOrTrue(bool? value)
        {
            return value == null || value == true;
        }
        public static bool NullOrFalse(bool? value)
        {
            return value == null || value == false;        
        }
    }
}
