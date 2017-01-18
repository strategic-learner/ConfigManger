using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
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
    public abstract class ConfigParam : EntityRead, IConfigParam
        {
        protected ConfigParam() { }
        //public ConfigParam( MockUsers user )
        //    {
        //    effDT = DateTime.Now;
        //    trmDT = DataConstants.defaultEndDate;

        //    ID = new Guid();
        //   updateDT = DateTime.Now;
        //    updateUser = user.defaultUser;
        //    }

        
        

        [Required]
        public Guid ConfigID { get; private set; }

        [Required]
        public DateTime effDT { get; private set; }

        [Required]
        public DateTime trmDT { get; private set; }

        [Required]
        public Guid ParamDefinitionID { get; private set; }

        [Required]
        public bool isRefOnly { get; private set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; private set; }

        [MaxLength(100)]
        public string valueUseageComments { get; private set; }


        #region NavigationProperties

        public Config Config { get; private set; }
        public ParamDefinition ParamDefinition { get; private set; }

        #endregion


        
        

        
        }

    }