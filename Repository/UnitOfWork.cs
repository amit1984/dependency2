using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dependency2.Iinterface;
using dependency2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace dependency2.Repository
{
    public class UnitOfWork : IUnitOfWork, System.IDisposable
    {
        private officerContext context = new officerContext();
        private IGenericRepository<officer> modelRepository;

        public IGenericRepository<officer> ModelRepository
        {
            get { return modelRepository ?? (modelRepository = new GenericRepository<officer>(context)); }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }
}