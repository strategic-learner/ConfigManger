using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    public interface IExecutable
        {
         Guid AppID { get; }
         string nameWExtension { get; }
         string description { get; }
        Guid? ParamVersionID { get; }
        }
    }