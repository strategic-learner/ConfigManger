using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DIV.ConfigMgr.Data
    {

    public interface IDAO<T> : IDisposable
        {
        IQueryable<T> GetAll();
        T findByID( Guid? id );
        void Insert( T entity );
        void Update( T entity );
        void Delete ( Guid? id );
        }
    }
