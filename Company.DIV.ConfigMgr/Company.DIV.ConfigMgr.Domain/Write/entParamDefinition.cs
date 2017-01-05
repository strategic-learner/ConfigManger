using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.DIV.ConfigMgr.Domain.Write
    {
    public class ParamDefinition : IParamDefinition, IEntityWrite
        {
        private ParamDefinition() { }

        public Guid ID { get; private set; }
        public Guid ParamVersionID { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParamSequence { get; private set; }
        public Guid ParamTypeID { get; private set; }  //data type for validations
        public string variableName { get; private set; }
        public string intendedUse { get; private set; } //Specify intended usage of the ConfigParam's value


        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }
        }
    }