using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dependency2.Iinterface
{
   public interface IRepository<T> where T: class
    {
        void Add(T entity);
        void Delete(T entity);
        int getdata();  
    }
}
