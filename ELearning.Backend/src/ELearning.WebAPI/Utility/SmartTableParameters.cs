using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCS.ELearningWebAPI.Utility
{
    public class SmartTableParameters
    {
        public string pageNumber { get; set; }
        public string pageSize { get; set; }
        public string orderByColumn { get; set; }
        public string orderByDirection { get; set; }

        public Dictionary<string, string> predicateObject { get; set; }


    }

    public class CustomerParameters :  SmartTableParameters
    {
       
        public string companyId { get; set; }
        


    }
}