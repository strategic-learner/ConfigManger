using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC02.Users;

namespace MVC02.Models
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
            createUser = MockUsers.Mock1();
            updateDT = DateTime.Now;
            updateUser = MockUsers.Mock1();

            }

        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid planID { get; set; }
        [Required]
        public Guid LineOfBusinessID { get; set; }


        #region NavigationProperties
        public virtual Plan Plans { get; set; }
        public virtual LineOfBusiness LineOfBusiness { get; set; }
        public virtual ICollection<Config> Configs { get; set; }
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