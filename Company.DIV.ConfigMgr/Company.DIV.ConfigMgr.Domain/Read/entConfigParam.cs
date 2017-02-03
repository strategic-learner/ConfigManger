using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class ConfigParamPROD : ConfigParam
        {
        //TODO: cleanup Interface for this (Add Environ)

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



    public interface ITestConfigParam : IEntityRead , IConfigParam
        {
        Guid ID { get; }
        DateTime updateDT { get; }
        string updateUser { get; }
        EntityStateDisconnected entityStateDisconnected { get; }

        string Environ { get; }
        Guid ConfigID { get; }
        DateTime effDT { get; }
        DateTime trmDT { get; }
        Guid ParamDefinitionID { get; }
        bool isRefOnly { get; }
        string value { get; }
        string valueUseageComments { get; }
        }


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

        [NotMapped]
        public abstract string Environ { get; } 

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

        //public Config Config { get; private set; }  //Trying OneWay Nav
        //public ParamDefinition ParamDefinition { get; private set; }  //Trying OneWay Nav

        #endregion






        }

    }