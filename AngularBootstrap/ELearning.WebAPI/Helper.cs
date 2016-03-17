using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCS.ELearningWebAPI
{
    public static class Helper
    {
        public static bool convertNulltoTrue(bool? value)
        {
            return value == null || value ==true ? true : false;
        }
        public static bool convertNulltoFalse(bool? value)
        {
            return value == null || value == false ? false : true;
        }

    }
}