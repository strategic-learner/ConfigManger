using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IDataWrite<T>
        {
        void Insert( T entity );
        void Update( T entity );
        void Delete( Guid? id );
        }
    }
