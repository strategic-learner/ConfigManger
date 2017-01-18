using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.DIV.ConfigMgr.Domain.Business.UseCase
    {
    public class JobIDList
        {
        public JobIDList( List<int> JobIDList )
            {IDs = JobIDList;}

        public List<int> IDs { get; private set; }
        }
    }
