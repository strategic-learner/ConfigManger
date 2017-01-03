﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// Interface for all entities Read and Write
    /// </summary>
    public interface IEntityRW
        {
        Guid ID { get; }

        DateTime createDT { get; }
        string createUser { get; }

        DateTime updateDT { get; }
        string updateUser { get; }

        EntityStateDisconnected entityStateDisconnected { get; }
        }
    }
