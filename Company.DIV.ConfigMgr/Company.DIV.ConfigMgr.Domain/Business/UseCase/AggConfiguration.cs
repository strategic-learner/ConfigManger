using System;
using System.Collections.Generic;
using Company.DIV.ConfigMgr.Domain.Read;

namespace Company.DIV.ConfigMgr.Domain.Business.UseCase
    {
    public class ReadAggConfiguration : IAggConfiguration
        {
        public Config config { get; set; }
        IConfig IAggConfiguration.config { get { return this.config; }  }

        }
    }
