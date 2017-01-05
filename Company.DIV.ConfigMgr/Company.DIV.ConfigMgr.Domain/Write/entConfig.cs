﻿using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class Config : IConfig, IEntityWrite
        {
        private Config() { }

		public Guid ID { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int jobID { get; private set; }
        public Guid AppID { get; private set; }
        public Guid ParamVersionID { get; private set; }
        public bool Active { get; private set; }
        public string DescriptonShort { get; private set; }
        public string DescriptonFull { get; private set; }
        public DateTime effDT { get; private set; }
        public DateTime trmDT { get; private set; }


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }