﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.DataModel.Domain
{
    public class Answer : EntityBase
    {
        

        public int AnswerID { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }

       
    }
}
