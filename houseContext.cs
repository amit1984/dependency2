using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using dependency2.Models;

namespace dependency2
{
    public class houseContext : DbContext
    {
        //public houseContext()
        //    : base("houseContext")
        //{
        //}
        public DbSet<house> houses { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}