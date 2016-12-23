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
    public class ParamDefinition
        {
        public ParamDefinition( string user )
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
        [Index("NDX_PKey" , 1 , IsUnique = true)]
        public Guid ParamVersionID { get; set; }

        [Required]
        [Index("NDX_PKey" , 2 , IsUnique = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParamSequence { get; set; }
        
        [Required]
        public Guid ParamTypeID { get; set; }  //data type for validations

        [Required]
        [MaxLength(50)]
        public string variableName { get; set; }

        [Required]
        [MaxLength(500)]
        public string intendedUse { get; set; } //Specify intended usage of the ConfigParam's value

        //[Required]
        //public  { get; set; }

            #region NavigationProperties
        public virtual ParamVersion ParamVersion { get; set; }
        public virtual ParamType ParamType { get; set; }
        public virtual ICollection<ConfigParam> ConfigParams { get; set; }
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



        private ParamDefinition() { }

        }
    }