﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class ConfigParamPRODAudit : ConfigParamAudit { }

    public class ConfigParamSTG1Audit : ConfigParamAudit { }
    public class ConfigParamSTG2Audit : ConfigParamAudit { }

    public class ConfigParamQA1Audit : ConfigParamAudit { }
    public class ConfigParamQA2Audit : ConfigParamAudit { }

    public class ConfigParamDEV1Audit : ConfigParamAudit { }
    public class ConfigParamDEV2Audit : ConfigParamAudit { }



    /// <DevNotes>
    /// At first Class inheritance Concrete/Abstract created silly-big Generated Views; 
    /// Now I changed something(?)somewhere(?) and the Generated Views are equal to 100% composed entityClasses
    /// </DevNotes>
    public abstract class ConfigParamAudit : EntityAudit, IConfigParam
        {
        protected ConfigParamAudit() { }

        
        
        
        

        
        public Guid ConfigID { get; private set;}
        public DateTime effDT { get; private set;}
        public DateTime trmDT { get; private set;}
        public Guid ParamDefinitionsID { get; private set;}
        public bool isRefOnly { get; private set;}

        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; private set;}

        [MaxLength(100)]
        public string valueUseageComments { get; private set;}


        
        
        }

    }