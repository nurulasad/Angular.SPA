using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCS.ELearningWebAPI.ViewModel
{
    public class PagedList<T> where T:class
    {
        public List<T> data { get; set; }
        public int totalRecords { get; set; }
    }
}