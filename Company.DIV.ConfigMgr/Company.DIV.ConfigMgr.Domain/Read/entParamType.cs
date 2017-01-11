using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamType : EntityRead, IParamType
        {
        private ParamType() { }
        public ParamType( MockUsers user )
            {
            this.ParamDefinitions = new HashSet<ParamDefinition>();

            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        
		

        [Required]
        [MaxLength(15)]
        public string type { get; private set; }


        #region NavigationProperties

        public ICollection<ParamDefinition> ParamDefinitions { get; private set; }

        #endregion



        
        

        
        }
    }