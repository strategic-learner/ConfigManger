using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class ConfigParamPRODAudit : ConfigParamAudit
        {
        [NotMapped]
        public override string Environ { get; } = "Prod";
        }


    public class ConfigParamSTG1Audit : ConfigParamAudit
        {
        [NotMapped]
        public override string Environ { get; } = "STG1";
        }

    public class ConfigParamSTG2Audit : ConfigParamAudit
        {
        [NotMapped]
        public override string Environ { get; } = "STG2";
        }


    public class ConfigParamQA1Audit : ConfigParamAudit
        {
        [NotMapped]
        public override string Environ { get; } = "QA1";
        }
    public class ConfigParamQA2Audit : ConfigParamAudit
        {
        [NotMapped]
        public override string Environ { get; } = "QA2";
        }

    public class ConfigParamDEV1Audit : ConfigParamAudit
        {
        [NotMapped]
        public override string Environ { get; } = "DEV1";
        }
    public class ConfigParamDEV2Audit : ConfigParamAudit
        {
        [NotMapped]
        public override string Environ { get; } = "DEV2";
        }



    /// <DevNotes>
    /// At first Class inheritance Concrete/Abstract created silly-big Generated Views; 
    /// Now I changed something(?)somewhere(?) and the Generated Views are equal to 100% composed entityClasses
    /// </DevNotes>
    public abstract class ConfigParamAudit : EntityAudit, IConfigParamBase
        {
        protected ConfigParamAudit() { }






        [NotMapped]
        public abstract string Environ { get; }
        public Guid ConfigID { get; private set;}
        public DateTime effDT { get; private set;}
        public DateTime trmDT { get; private set;}
        public Guid ParamDefinitionID { get; private set;}
        public bool isRefOnly { get; private set;}

        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; private set;}

        [MaxLength(100)]
        public string valueUseageComments { get; private set;}


        
        
        }

    }