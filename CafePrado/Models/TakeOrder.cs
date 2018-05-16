using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafePrado.Models
{
    public class TakeOrder

    {
        public List<SelectListItem> Orders{ get; set; }

        public int CustomerID{ get; set; }
        public string Name{ get; set; }
        public int CCell { get; set; }
    }
}