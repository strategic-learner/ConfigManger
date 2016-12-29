using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.DIV.ConfigMgr.Users;

namespace Company.DIV.ConfigMgr.Domain
    {

    /// <summary>
    /// Is there an easier way to do this in Fluent API?  
    /// Needed to allow only valid combinations to be referenced from Config
    /// </summary>
    [Table("J_Plan_LOB")]
    public class JPlanLOB
        {
        public JPlanLOB()
            {
            //this.??? = new HashSet<???>();
            createDT = DateTime.Now;
            createUser = MockUsers.defaultUser;
            updateDT = DateTime.Now;
            updateUser = MockUsers.defaultUser;

            }

        //[Key]
        //public Guid ID { get; set; }

        ??? [Key]
        [Required]
        ??? [Index("NDX_PK" , 1 , IsUnique = true , IsClustered = false)]
        public Guid planID { get; set; }

        ??? [Key]
        [Required]
        ??? [Index("NDX_PK" , 2 , IsUnique = true , IsClustered = false)]
        public Guid LineOfBusinessID { get; set; }


        #region NavigationProperties
        public Plan Plans { get; set; }
        public LineOfBusiness LineOfBusiness { get; set; }
        public ICollection<Config> Configs { get; set; }
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



        }
    }