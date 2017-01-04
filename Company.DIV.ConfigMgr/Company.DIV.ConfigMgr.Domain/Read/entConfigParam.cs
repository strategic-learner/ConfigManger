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



    /// <DevNotes>
    /// At first Class inheritance Concrete/Abstract created silly-big Generated Views; 
    /// Now I changed something(?)somewhere(?) and the Generated Views are equal to 100% composed entityClasses
    /// </DevNotes>
    public abstract class ConfigParam : IConfigParam, IEntityRead
        {
        protected ConfigParam() { }
        public ConfigParam( string user )
            {
            effDT = DateTime.Now;
            trmDT = DataConstants.defaultEndDate;

            ID = new Guid();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;
            }

        
        public Guid ID { get; private set; }

        [Required]
        public Guid ConfigID { get; private set; }

        [Required]
        public DateTime effDT { get; private set; }

        [Required]
        public DateTime trmDT { get; private set; }

        [Required]
        public Guid ParamDefinitionsID { get; private set; }

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


        public DateTime createDT { get; private set; }
        public string createUser { get; private set; }
        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }

    }