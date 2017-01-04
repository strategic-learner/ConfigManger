using System;
using System.Linq;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IDataRead<T>
        {
        IQueryable<T> GetAll();
        T findByID( Guid? id );
        }
    }
