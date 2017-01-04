using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JPathServerPathShare : IJPathServerPathShare, IEntityWrite
        {
        public JPathServerPathShare() { }

        public Guid ID { get; private set; }
        public Guid PathServerID { get; private set; }
        public Guid PathShareID { get; private set; }

        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }