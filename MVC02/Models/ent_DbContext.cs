using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC02.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVC02.Models {
	public class MVC02Context : DbContext {
		public MVC02Context() : base("MVC02") 
			{	}
		protected override void OnModelCreating(DbModelBuilder modelBuilder) 
			{
            //modelBuilder.HasDefaultSchema("special");
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<App>()
			   .HasMany(a => a.Plans)
			   .WithMany(p => p.Apps)
			   .Map(ap => {
				   ap.MapLeftKey("app");
				   ap.MapRightKey("plan");
				   ap.ToTable("J_App_Plan");
			   });

            modelBuilder.Entity<Config>()
               .HasMany(c => c.Plans)
               .WithMany(p => p.Configs)
               .Map(ap => {
                   ap.MapLeftKey("plan");
                   ap.MapRightKey("config");
                   ap.ToTable("J_Config_Plan");
               });

            modelBuilder.Entity<Config>()
               .HasMany(c => c.Executables)
               .WithMany(e => e.Configs)
               .Map(ap => {
                   ap.MapLeftKey("executable");
                   ap.MapRightKey("config");
                   ap.ToTable("J_Config_Executable");
               });


            modelBuilder.Entity<Executable>()
               .HasMany(e => e.PathServers)
               .WithMany(p => p.Executables)
               .Map(ap => {
                   ap.MapLeftKey("pathServer");
                   ap.MapRightKey("executable");
                   ap.ToTable("J_Executable_PathServer");
               });

             modelBuilder.Entity<Executable>()
               .HasMany(e => e.PrimaryFunctions)
               .WithMany(pf => pf.Executables)
               .Map(ap => {
                   ap.MapLeftKey("primaryFunction");
                   ap.MapRightKey("executable");
                   ap.ToTable("J_Executable_PrimaryFunction");
               });

            modelBuilder.Entity<Config>()
               .HasRequired(c => c.App)
               .WithMany(a => a.Configs);

            modelBuilder.Entity<Config>()
              .HasRequired(c => c.ParamVersion)
              .WithMany(pv => pv.Configs);

            modelBuilder.Entity<ConfigParam>()
              .HasRequired(cp => cp.Config)
              .WithMany(cp => cp.ConfigParams);

            modelBuilder.Entity<Executable>()
              .HasRequired(e => e.ParamVersion)  //wanted to change this to be HasOptional while adding here, but EF (or maybe just EF PowerTools?) was fighting the change from [Required] decoration
              .WithMany(pv => pv.Executables);

            modelBuilder.Entity<Executable>()
              .HasRequired(e => e.App)
              .WithMany(a => a.Executables);

            modelBuilder.Entity<ParamDefinition>()
              .HasRequired(pd => pd.ParamVersion)
              .WithMany(pv => pv.ParamDefinitions);

            modelBuilder.Entity<ParamDefinition>()
              .HasRequired(pd => pd.ParamType)
              .WithMany(pt => pt.ParamDefinitions);

            modelBuilder.Entity<ConfigParam>()
              .HasRequired(cp => cp.ParamDefinitions)
              .WithMany(pd => pd.ConfigParams);

            }


        public DbSet<App> app { get; set; }
        public DbSet<Config> config { get; set; }
        //public DbSet<ConfigParams> configParams { get; set; }
        public DbSet<ConfigParamPROD> configParamsPROD { get; set; }
        public DbSet<ConfigParamQA1> configParamsQA1 { get; set; }
        public DbSet<ConfigParamDEV1> configParamsDev1 { get; set; }
        public DbSet<ConfigParamSTG1> configParamsSTG1 { get; set; }

        public DbSet<Executable> executable { get; set; }
        public DbSet<PrimaryFunction> executableFunctions { get; set; }
        public DbSet<ParamDefinition> paramDefinitions { get; set; }
        public DbSet<ParamType> paramType { get; set; }
        public DbSet<ParamVersion> paramVersion { get; set; }
        public DbSet<PathServer> pathServer { get; set; }
        public DbSet<PathShare> pathShare { get; set; }
        public DbSet<Plan> plan { get; set; }
        //public DbSet<>  { get; set; }

        }
    }