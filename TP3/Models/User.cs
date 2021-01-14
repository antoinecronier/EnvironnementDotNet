using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP3.Models
{
    public class User : EntityBase
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Role Role { get; set; }
        public List<Book> Books { get; set; }
    }
}