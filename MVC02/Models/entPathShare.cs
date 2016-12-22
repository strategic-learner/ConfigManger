﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC02.Users;

namespace MVC02.Models
	{
	public class PathShare
		{
		public PathShare( string user )
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
        [StringLength(256)]
        public string share { get; set; }

        [Index("NDX_PKey" , 2 , IsUnique = true)]
        [StringLength(256)]
        public string path { get; set; }

        //[Required]
        //public  { get; set; }


        [Required]
		public DateTime createDT { get; set; }

		[Required]
		public string createUser { get; set; }

		[Required]
		public DateTime updateDT { get; set; }

		[Required]
		public string updateUser { get; set; }



        private PathShare() { }

        }
    }