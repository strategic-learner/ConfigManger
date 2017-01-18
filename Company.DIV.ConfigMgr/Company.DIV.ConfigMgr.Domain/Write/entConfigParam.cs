using System;


namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class ConfigParamPROD : ConfigParam { }

    public class ConfigParamSTG1 : ConfigParam { }
    public class ConfigParamSTG2 : ConfigParam { }

    public class ConfigParamQA1 : ConfigParam { }
    public class ConfigParamQA2 : ConfigParam { }

    public class ConfigParamDEV1 : ConfigParam { }
    public class ConfigParamDEV2 : ConfigParam {}



    /// <DevNotes>
    /// At first Class inheritance Concrete/Abstract created silly-big Generated Views; 
    /// Now I changed something(?)somewhere(?) and the Generated Views are equal to 100% composed entityClasses
    /// </DevNotes>
    public abstract class ConfigParam : EntityWrite, IConfigParam
        {
        protected ConfigParam() { }
        
        
        public Guid ConfigID { get; private set; }
        public DateTime effDT { get; private set; }
        public DateTime trmDT { get; private set; }
        public Guid ParamDefinitionID { get; private set; }
        public bool isRefOnly { get; private set; }
        public string value { get; private set; }
        public string valueUseageComments { get; private set; }


        
        
        }

    }