using System;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IDataWrite<T>
        {
        void Insert( T entity );
        void Update( T entity );
        void Delete( Guid? id );
        }
    }
