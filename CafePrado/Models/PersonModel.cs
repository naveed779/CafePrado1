using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafePrado.Models
{
    public class PersonModel
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public int age { get; set; } = 0;   

        public bool isAlive { get; set; } = true;
    }
}