using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.DIV.ConfigMgr.Domain.Business.UseCase
    {
    public class QryGetAggConfigurationByJobIDList
        {
        public QryGetAggConfigurationByJobIDList( List<int> _JobIDList )
            {JobIDList = _JobIDList;}

        public List<int> JobIDList { get; private set; }
        }
    }
