using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dependency2.Iinterface;
using dependency2.Models;

namespace dependency2.Repository
{
    public class officerRepository : IRepository<officer>
    {
        private officerContext oc;
        public officerRepository()
        {
           oc  = new officerContext();
        }
        public void Add(officer entity)
        {
            oc.officers.Add(entity);
            oc.SaveChanges();
        }
        public void Delete(officer entity)
        {
            oc.officers.Remove(entity);
            oc.SaveChanges();
        }
        public int getdata()
        {
            int n = oc.officers.Count();
            return n;
        }

    }
}