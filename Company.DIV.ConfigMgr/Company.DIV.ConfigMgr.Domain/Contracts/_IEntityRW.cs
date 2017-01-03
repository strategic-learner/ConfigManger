using System;
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
        Guid ID { get; set; }

        DateTime createDT { get; set; }
        string createUser { get; set; }

        DateTime updateDT { get; set; }
        string updateUser { get; set; }

        //[NotMapped]
        EntityStateDisconnected entityStateDisconnected { get; set; }



        }
    }
