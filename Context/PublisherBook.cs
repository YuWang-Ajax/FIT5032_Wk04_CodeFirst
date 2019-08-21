using FIT5032_Wk04_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_Wk04_CodeFirst.Context
{
    public class PublisherBook : DbContext
    {
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }

    }
}