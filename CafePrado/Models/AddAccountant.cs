using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafePrado.Models
{
    public class AddAccountant
    {
        public int AccountantID { get; set; }
        public String AName { get; set; }
        public int AccountantCell { get; set; }
        public int AccountantSalary { get; set; }
        public String AEmail { get; set; }

    }
}