using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class ConfigParamPROD : ConfigParam
        {
        private ConfigParamPROD() { }
        public ConfigParamPROD( ConfigParamConsolidated dto)
            {
            if(!dto.Environ.Equals("PROD"))
                { throw new Exception(""); }

            ID = dto.ID;
            updateDT = dto.updateDT;
            updateUser = dto.updateUser;
            entityStateDisconnected = dto.entityStateDisconnected;

            Environ = dto.Environ;
            ConfigID = dto.ConfigID;
            effDT = dto.effDT;
            trmDT = dto.trmDT;
            ParamDefinitionID = dto.ParamDefinitionID;
            isRefOnly = dto.isRefOnly;
            value = dto.value;
            valueUseageComments = dto.valueUseageComments;
        }

        [NotMapped]
        public override string Environ { get ; } = "PROD";
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
    public abstract class ConfigParam : EntityRead, IConfigParamRead
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
        public Guid ConfigID { get; protected set; }

        [Required]
        public DateTime effDT { get; protected set; }

        [Required]
        public DateTime trmDT { get; protected set; }

        [Required]
        public Guid ParamDefinitionID { get; protected set; }

        [Required]
        public bool isRefOnly { get; protected set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; protected set; }

        [MaxLength(100)]
        public string valueUseageComments { get; protected set; }


        #region NavigationProperties

        //public Config Config { get; private set; }  //Trying OneWay Nav
        //public ParamDefinition ParamDefinition { get; private set; }  //Trying OneWay Nav

        #endregion






        }

    }