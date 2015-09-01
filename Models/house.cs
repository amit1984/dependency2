using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace dependency2.Models
{
    public partial class house
    {
            public int ID { get; set; }
            public string name { get; set; }
            public string add { get; set; }
    }
    public partial class houseContext : DbContext
    {
        public DbSet<house> houses { get; set; }
    }
}