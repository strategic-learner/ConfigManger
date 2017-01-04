using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JConfigExecutable : IJConfigExecutable, IEntityWrite
        {
        public JConfigExecutable() { }

        public Guid ID { get; private set; }
        public Guid ConfigID { get; private set; }
        public Guid ExecutableID { get; private set; }

        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }