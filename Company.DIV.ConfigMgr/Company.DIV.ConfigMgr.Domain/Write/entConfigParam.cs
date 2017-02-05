using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class ConfigParamPROD : ConfigParam
        {
        [NotMapped]
        public override string Environ { get; } = "Prod";
        }


    public class ConfigParamSTG1 : ConfigParam
        {
        [NotMapped]
        public override string Environ { get; } = "STG1";
        }

    public class ConfigParamSTG2 : ConfigParam
        {
        [NotMapped]
        public override string Environ { get; } = "STG2";
        }


    public class ConfigParamQA1 : ConfigParam
        {
        [NotMapped]
        public override string Environ { get; } = "QA1";
        }
    public class ConfigParamQA2 : ConfigParam
        {
        [NotMapped]
        public override string Environ { get; } = "QA2";
        }

    public class ConfigParamDEV1 : ConfigParam
        {
        [NotMapped]
        public override string Environ { get; } = "DEV1";
        }
    public class ConfigParamDEV2 : ConfigParam
        {
        [NotMapped]
        public override string Environ { get; } = "DEV2";
        }



    /// <DevNotes>
    /// At first Class inheritance Concrete/Abstract created silly-big Generated Views; 
    /// Now I changed something(?)somewhere(?) and the Generated Views are equal to 100% composed entityClasses
    /// </DevNotes>
    public abstract class ConfigParam : EntityWrite, IConfigParamWrite
        {
        protected ConfigParam() { }

        [NotMapped]
        public abstract string Environ { get; }
        public Guid ConfigID { get; private set; }
        public DateTime effDT { get; private set; }
        public DateTime trmDT { get; private set; }
        public Guid ParamDefinitionID { get; private set; }
        public bool isRefOnly { get; private set; }
        public string value { get; private set; }
        public string valueUseageComments { get; private set; }
        
        }

    }