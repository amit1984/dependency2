using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using dependency2.Models;

namespace dependency2.Iinterface
{
    public interface IUnitOfWork
    {
        IGenericRepository<officer> ModelRepository { get; }
        void Save();
    }
}
