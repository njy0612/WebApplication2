using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class myModel
    {
        public myModel()
        {
            count = 0;
        }
        public string text { get; set; }
        public int count { get; set; }

        public string imgPath { get; set; }

        
    }
}