using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;


namespace Company.DIV.ConfigMgr.Domain.Read
    {

    public class ConfigParamPROD : ConfigParam { }

    public class ConfigParamSTG1 : ConfigParam { }
    public class ConfigParamSTG2 : ConfigParam { }

    public class ConfigParamQA1 : ConfigParam { }
    public class ConfigParamQA2 : ConfigParam { }

    public class ConfigParamDEV1 : ConfigParam { }
    public class ConfigParamDEV2 : ConfigParam {}



    /// <summary>
    /// At first Class inheritance Concrete/Abstract created silly-big Generated Views
    /// Now I changed something(?) and the Generated Views seem fine
    /// </summary>
    public abstract class ConfigParam : IConfigParam
        {
        public ConfigParam( string user )
            {
            //this.PROPERTY = new HashSet<ENTITYCLASS>();

            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        
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


        protected ConfigParam() { }

        }


    //public interface IConfigParam  //Class inheritance w/wo Abstract may have serious performance impact - need to compose not inherit
    //    {

    //    
    //    Guid ID { get; set; }

    //    [Required]
    //    Guid ConfigID { get; set; }

    //    [Required]
    //    DateTime effDT { get; set; }

    //    [Required]
    //    DateTime trmDT { get; set; }

    //    [Required]
    //    Guid ParamDefinitionsID { get; set; }

    //    [Required]
    //    bool isRefOnly { get; set; }

    //    [Required]
    //    [Column(TypeName = "NVarchar(MAX)")]
    //    string value { get; set; }

    //    [MaxLength(100)]
    //    string valueUseageComments { get; set; }


    //    #region NavigationProperties

    //    Config Config { get; set; }
    //    ParamDefinition ParamDefinition { get; set; }

    //    #endregion


    //    [Required]
    //    DateTime createDT { get; set; }

    //    [Required]
    //    [MaxLength(20)]
    //    string createUser { get; set; }

    //    [Required]
    //    DateTime updateDT { get; set; }

    //    [Required]
    //    [MaxLength(20)]
    //    string updateUser { get; set; }

    //    }



    }