using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;


namespace Company.DIV.ConfigMgr.Domain
    {

    public interface IConfigParam  //Class inheritance w/wo Abstract may have serious performance impact - need to compose not inherit
        {

        [Key]
        Guid ID { get; set; }

        [Required]
        Guid ConfigID { get; set; }

        [Required]
        DateTime effDT { get; set; }

        [Required]
        DateTime trmDT { get; set; }

        [Required]
        Guid ParamDefinitionsID { get; set; }

        [Required]
        bool isRefOnly { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        string value { get; set; }

        [MaxLength(100)]
        string valueUseageComments { get; set; }


        #region NavigationProperties

        Config Config { get; set; }
        ParamDefinition ParamDefinition { get; set; }

        #endregion


        [Required]
        DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        string createUser { get; set; }

        [Required]
        DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        string updateUser { get; set; }

        }


    public class ConfigParamPROD : IConfigParam
        {
        public ConfigParamPROD( string user )
            {
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate; 

            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ConfigID { get; set; }

        [Required]
        public DateTime effDT { get; set; }

        [Required]
        public DateTime trmDT { get; set; }

        [Required]
        public Guid ParamDefinitionsID { get; set; }

        [Required]
        public bool isRefOnly { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; set; }

        [MaxLength(100)]
        public string valueUseageComments { get; set; }


        #region NavigationProperties

        public Config Config { get; set; }
        public ParamDefinition ParamDefinition { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string updateUser { get; set; }


        protected ConfigParamPROD() { }

        }

    public class ConfigParamSTG1 : IConfigParam
        {
        public ConfigParamSTG1( string user )
            {
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ConfigID { get; set; }

        [Required]
        public DateTime effDT { get; set; }

        [Required]
        public DateTime trmDT { get; set; }

        [Required]
        public Guid ParamDefinitionsID { get; set; }

        [Required]
        public bool isRefOnly { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; set; }

        [MaxLength(100)]
        public string valueUseageComments { get; set; }


        #region NavigationProperties

        public Config Config { get; set; }
        public ParamDefinition ParamDefinition { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string updateUser { get; set; }


        protected ConfigParamSTG1() { }

        }

    public class ConfigParamSTG2 : IConfigParam
        {
        public ConfigParamSTG2( string user )
            {
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ConfigID { get; set; }

        [Required]
        public DateTime effDT { get; set; }

        [Required]
        public DateTime trmDT { get; set; }

        [Required]
        public Guid ParamDefinitionsID { get; set; }

        [Required]
        public bool isRefOnly { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; set; }

        [MaxLength(100)]
        public string valueUseageComments { get; set; }


        #region NavigationProperties

        public Config Config { get; set; }
        public ParamDefinition ParamDefinition { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string updateUser { get; set; }


        protected ConfigParamSTG2() { }

        }

    public class ConfigParamQA1 : IConfigParam
        {
        public ConfigParamQA1( string user )
            {
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ConfigID { get; set; }

        [Required]
        public DateTime effDT { get; set; }

        [Required]
        public DateTime trmDT { get; set; }

        [Required]
        public Guid ParamDefinitionsID { get; set; }

        [Required]
        public bool isRefOnly { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; set; }

        [MaxLength(100)]
        public string valueUseageComments { get; set; }


        #region NavigationProperties

        public Config Config { get; set; }
        public ParamDefinition ParamDefinition { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string updateUser { get; set; }


        protected ConfigParamQA1() { }

        }

    public class ConfigParamQA2 : IConfigParam
        {
        public ConfigParamQA2( string user )
            {
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ConfigID { get; set; }

        [Required]
        public DateTime effDT { get; set; }

        [Required]
        public DateTime trmDT { get; set; }

        [Required]
        public Guid ParamDefinitionsID { get; set; }

        [Required]
        public bool isRefOnly { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; set; }

        [MaxLength(100)]
        public string valueUseageComments { get; set; }


        #region NavigationProperties

        public Config Config { get; set; }
        public ParamDefinition ParamDefinition { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string updateUser { get; set; }


        protected ConfigParamQA2() { }

        }

    public class ConfigParamDEV1 : IConfigParam
        {
        public ConfigParamDEV1( string user )
            {
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ConfigID { get; set; }

        [Required]
        public DateTime effDT { get; set; }

        [Required]
        public DateTime trmDT { get; set; }

        [Required]
        public Guid ParamDefinitionsID { get; set; }

        [Required]
        public bool isRefOnly { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; set; }

        [MaxLength(100)]
        public string valueUseageComments { get; set; }


        #region NavigationProperties

        public Config Config { get; set; }
        public ParamDefinition ParamDefinition { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string updateUser { get; set; }


        protected ConfigParamDEV1() { }

        }

    public class ConfigParamDEV2 : IConfigParam
        {
        public ConfigParamDEV2( string user )
            {
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ConfigID { get; set; }

        [Required]
        public DateTime effDT { get; set; }

        [Required]
        public DateTime trmDT { get; set; }

        [Required]
        public Guid ParamDefinitionsID { get; set; }

        [Required]
        public bool isRefOnly { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        public string value { get; set; }

        [MaxLength(100)]
        public string valueUseageComments { get; set; }


        #region NavigationProperties

        public Config Config { get; set; }
        public ParamDefinition ParamDefinition { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        [MaxLength(20)]
        public string updateUser { get; set; }


        protected ConfigParamDEV2() { }

        }



    #region original class
    //public class ConfigParam   //Class inheritance w/wo Abstract may have serious performance impact - need to compose not inherit
    //    {
    //    public ConfigParam( string user )
    //        {
    //        //this.PROPERTY = new HashSet<ENTITYCLASS>();

    //        effDT = DateTime.Now;
    //        trmDT = DataConstants.defaultEndDate;

    //        createDT = DateTime.Now;
    //        createUser = MockUsers.defaultUser;
    //        updateDT = DateTime.Now;
    //        updateUser = MockUsers.defaultUser;
    //        }

    //    [Key]
    //    public Guid ID { get; set; }

    //    [Required]
    //    public Guid ConfigID { get; set; }

    //    [Required]
    //    public DateTime effDT { get; set; }

    //    [Required]
    //    public DateTime trmDT { get; set; }

    //    [Required]
    //    public Guid ParamDefinitionsID { get; set; }

    //    [Required]
    //    public bool isRefOnly { get; set; }

    //    [Required]
    //    [Column(TypeName = "NVarchar(MAX)")]
    //    public string value { get; set; }

    //    [MaxLength(100)]
    //    public string valueUseageComments { get; set; }


    //    #region NavigationProperties

    //    public Config Config { get; set; }
    //    public ParamDefinition ParamDefinition { get; set; }

    //    #endregion


    //    [Required]
    //    public DateTime createDT { get; set; }

    //    [Required]
    //    [MaxLength(20)]
    //    public string createUser { get; set; }

    //    [Required]
    //    public DateTime updateDT { get; set; }

    //    [Required]
    //    [MaxLength(20)]
    //    public string updateUser { get; set; }


    //    protected ConfigParam() { }

    //    }
    #endregion


    }