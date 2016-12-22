using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC02.Users;

namespace MVC02.Models
	{
    public class ConfigParamQA1 : ConfigParam { }
    public class ConfigParamQA2 : ConfigParam { }
    public class ConfigParamDEV1 : ConfigParam { }
    public class ConfigParamDEV2 : ConfigParam { }
    public class ConfigParamSTG1 : ConfigParam { }
    public class ConfigParamSTG2 : ConfigParam { }
    public class ConfigParamPROD : ConfigParam { }


    public abstract class ConfigParam
        {
        public ConfigParam( string user )
            {
            //this.PROPERTY = new HashSet<ENTITYCLASS>();
            createDT = DateTime.Now;
            createUser = user;
            updateDT = DateTime.Now;
            updateUser = user;
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
        public string value { get; set; }

        public string valueComments { get; set; }


        #region NavigationProperties

        public virtual Config Config { get; set; }
        public virtual ParamDefinition ParamDefinitions { get; set; }

        #endregion


        [Required]
        public DateTime createDT { get; set; }

        [Required]
        public string createUser { get; set; }

        [Required]
        public DateTime updateDT { get; set; }

        [Required]
        public string updateUser { get; set; }


        protected ConfigParam() { }

        }


    }