using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafePrado.Models
{
    public class AddCustomer
    {

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int CCell { get; set; }
        public string Status { get; set; }
    }
}