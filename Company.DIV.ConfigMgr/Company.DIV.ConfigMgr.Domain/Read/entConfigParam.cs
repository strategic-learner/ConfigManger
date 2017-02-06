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
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamPROD) , nameof(Environ) , dto.Environ)); }
            if ( dto.ID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamPROD) , nameof(ID) , dto.ID.ToString())); }
            if ( dto.ConfigID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamPROD) , nameof(ConfigID) , dto.ConfigID.ToString())); }
            if ( dto.ParamDefinitionID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamPROD) , nameof(ParamDefinitionID) , dto.ParamDefinitionID.ToString())); }
            if ( string.IsNullOrWhiteSpace(dto.value) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamPROD) , nameof(value) , dto.value)); }
            if ( dto.effDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamPROD) , nameof(effDT) , dto.effDT.ToString())); }
            if ( dto.trmDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamPROD) , nameof(trmDT) , dto.trmDT.ToString())); }

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
        private ConfigParamSTG1() { }
        public ConfigParamSTG1( ConfigParamConsolidated dto )
            {
            if ( !dto.Environ.Equals("STG1") )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG1) , nameof(Environ) , dto.Environ)); }
            if ( dto.ID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG1) , nameof(ID) , dto.ID.ToString())); }
            if ( dto.ConfigID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG1) , nameof(ConfigID) , dto.ConfigID.ToString())); }
            if ( dto.ParamDefinitionID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG1) , nameof(ParamDefinitionID) , dto.ParamDefinitionID.ToString())); }
            if ( string.IsNullOrWhiteSpace(dto.value) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG1) , nameof(value) , dto.value)); }
            if ( dto.effDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG1) , nameof(effDT) , dto.effDT.ToString())); }
            if ( dto.trmDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG1) , nameof(trmDT) , dto.trmDT.ToString())); }

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
        public override string Environ { get; } = "STG1";
        }

    public class ConfigParamSTG2 : ConfigParam
        {
        private ConfigParamSTG2() { }
        public ConfigParamSTG2( ConfigParamConsolidated dto )
            {
            if ( !dto.Environ.Equals("STG2") )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG2) , nameof(Environ) , dto.Environ)); }
            if ( dto.ID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG2) , nameof(ID) , dto.ID.ToString())); }
            if ( dto.ConfigID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG2) , nameof(ConfigID) , dto.ConfigID.ToString())); }
            if ( dto.ParamDefinitionID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG2) , nameof(ParamDefinitionID) , dto.ParamDefinitionID.ToString())); }
            if ( string.IsNullOrWhiteSpace(dto.value) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG2) , nameof(value) , dto.value)); }
            if ( dto.effDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG2) , nameof(effDT) , dto.effDT.ToString())); }
            if ( dto.trmDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamSTG2) , nameof(trmDT) , dto.trmDT.ToString())); }

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
        public override string Environ { get; } = "STG2";
        }


    public class ConfigParamQA1 : ConfigParam
        {
        private ConfigParamQA1() { }
        public ConfigParamQA1( ConfigParamConsolidated dto )
            {
            if ( !dto.Environ.Equals("QA1") )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA1) , nameof(Environ) , dto.Environ)); }
            if ( dto.ID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA1) , nameof(ID) , dto.ID.ToString())); }
            if ( dto.ConfigID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA1) , nameof(ConfigID) , dto.ConfigID.ToString())); }
            if ( dto.ParamDefinitionID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA1) , nameof(ParamDefinitionID) , dto.ParamDefinitionID.ToString())); }
            if ( string.IsNullOrWhiteSpace(dto.value) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA1) , nameof(value) , dto.value)); }
            if ( dto.effDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA1) , nameof(effDT) , dto.effDT.ToString())); }
            if ( dto.trmDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA1) , nameof(trmDT) , dto.trmDT.ToString())); }

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
        public override string Environ { get; } = "QA1";
        }

    public class ConfigParamQA2 : ConfigParam
        {
        private ConfigParamQA2() { }
        public ConfigParamQA2( ConfigParamConsolidated dto )
            {
            if ( !dto.Environ.Equals("QA2") )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA2) , nameof(Environ) , dto.Environ)); }
            if ( dto.ID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA2) , nameof(ID) , dto.ID.ToString())); }
            if ( dto.ConfigID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA2) , nameof(ConfigID) , dto.ConfigID.ToString())); }
            if ( dto.ParamDefinitionID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA2) , nameof(ParamDefinitionID) , dto.ParamDefinitionID.ToString())); }
            if ( string.IsNullOrWhiteSpace(dto.value) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA2) , nameof(value) , dto.value)); }
            if ( dto.effDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA2) , nameof(effDT) , dto.effDT.ToString())); }
            if ( dto.trmDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamQA2) , nameof(trmDT) , dto.trmDT.ToString())); }

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
        public override string Environ { get; } = "QA2";
        }


    public class ConfigParamDEV1 : ConfigParam
        {
        private ConfigParamDEV1() { }
        public ConfigParamDEV1( ConfigParamConsolidated dto )
            {
            if ( !dto.Environ.Equals("DEV1") )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV1) , nameof(Environ) , dto.Environ)); }
            if ( dto.ID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV1) , nameof(ID) , dto.ID.ToString())); }
            if ( dto.ConfigID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV1) , nameof(ConfigID) , dto.ConfigID.ToString())); }
            if ( dto.ParamDefinitionID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV1) , nameof(ParamDefinitionID) , dto.ParamDefinitionID.ToString())); }
            if ( string.IsNullOrWhiteSpace(dto.value) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV1) , nameof(value) , dto.value)); }
            if ( dto.effDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV1) , nameof(effDT) , dto.effDT.ToString())); }
            if ( dto.trmDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV1) , nameof(trmDT) , dto.trmDT.ToString())); }

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
        public override string Environ { get; } = "DEV1";
        }

    public class ConfigParamDEV2 : ConfigParam
        {
        private ConfigParamDEV2() { }
        public ConfigParamDEV2( ConfigParamConsolidated dto )
            {
            if ( !dto.Environ.Equals("DEV2") )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV2) , nameof(Environ) , dto.Environ)); }
            if ( dto.ID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV2) , nameof(ID) , dto.ID.ToString())); }
            if ( dto.ConfigID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV2) , nameof(ConfigID) , dto.ConfigID.ToString())); }
            if ( dto.ParamDefinitionID.Equals(Guid.Empty) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV2) , nameof(ParamDefinitionID) , dto.ParamDefinitionID.ToString())); }
            if ( string.IsNullOrWhiteSpace(dto.value) )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV2) , nameof(value) , dto.value)); }
            if ( dto.effDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV2) , nameof(effDT) , dto.effDT.ToString())); }
            if ( dto.trmDT == DateTime.MinValue )
                { throw new Exception(string.Format("Invalid ctor value {0}.{1}='{2}'" , nameof(ConfigParamDEV2) , nameof(trmDT) , dto.trmDT.ToString())); }

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