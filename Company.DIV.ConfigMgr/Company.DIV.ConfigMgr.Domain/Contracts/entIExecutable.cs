﻿using System;

namespace Company.DIV.ConfigMgr.Domain
    {
	public interface IExecutable : IEntityBase
        {
         Guid ParamVersionID { get; }
         Guid AppID { get; }
         string nameWExtension { get; }
         string description { get; }
        }
	}