using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class Config : EntityWrite, IConfigWrite
        {
        private Config() { }

		

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int jobID { get; private set; }
        public Guid AppID { get; private set; }
        public Guid ParamVersionID { get; private set; }
        public bool Active { get; private set; }
        public string DescriptionShort { get; private set; }
        public string DescriptionFull { get; private set; }
        public DateTime effDT { get; private set; }
        public DateTime trmDT { get; private set; }


        
        
        }
    }