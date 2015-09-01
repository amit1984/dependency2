using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace dependency2.Models
{
    public class officer
    {
        public int ID { get; set; }
        public string name { get; set; }
    }
    public class officerContext : DbContext
    {
      public DbSet<officer> officers { get; set; }
    }
}