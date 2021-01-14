using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP3.Models
{
    public class Book : EntityBase
    {
        public string Name { get; set; }
        public int NbPage { get; set; }
        public decimal Price { get; set; }
    }
}