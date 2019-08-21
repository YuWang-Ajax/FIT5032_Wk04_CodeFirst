using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Wk04_CodeFirst.Models
{
    public class Book
    {
        public int id { get; set; }
        public String BookName { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}