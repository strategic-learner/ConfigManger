using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain.Read
    {
    public class ParamType : IParamType, IEntityRead
        {
        private ParamType() { }
        public ParamType( MockUsers user )
            {
            this.ParamDefinitions = new HashSet<ParamDefinition>();

            ID = new Guid();
            updateDT = DateTime.Now;
            updateUser = user.defaultUser;
            }

        
		public Guid ID { get; private set; }

        [Required]
        [MaxLength(15)]
        public string type { get; private set; }


        #region NavigationProperties

        public ICollection<ParamDefinition> ParamDefinitions { get; private set; }

        #endregion



        public DateTime updateDT { get; private set; }
        public string updateUser { get; private set; }

        public EntityStateDisconnected entityStateDisconnected { get; private set;}
        }
    }