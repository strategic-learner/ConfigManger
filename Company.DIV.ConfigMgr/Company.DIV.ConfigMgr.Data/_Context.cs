using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Company.DIV.ConfigMgr.Domain;



namespace Company.DIV.ConfigMgr.DataRead
    {
    internal class ConfigMgrContext : DbContext
        {
        public ConfigMgrContext() :
        base("name=ConfigMgr") //--HOLY WTW: PowerTools can only find the connString with this!!!???
        //base(System.Configuration.ConfigurationManager.ConnectionStrings["ConfigMgr"].ConnectionString)  //--HOLY WTW: PowerTools can NOT find the connString with this!!!??? //Throws "object reference not set to an instance of an object" in a dialog box
        //http://thedatafarm.com/data-access/entity-framework-power-tool-tips-to-view-model-a-feature-i-depend-on/
        //base("ConfigMgr")
        //base("ConfigMgrContext")

            {
            this.Configuration.LazyLoadingEnabled = false;
            
            #if DEBUG
            Database.Log = Console.WriteLine;
            #endif
            }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
            {
            modelBuilder.HasDefaultSchema("AD");

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //very little if anything should ever be deleted - mostly deactivated (ConfigParam data is an exception, but no dependency concern)
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            ////Schemas for clear environment 'domain' separation within the db
            modelBuilder.Entity<ConfigParamPROD>()  
                .ToTable("ConfigParam" , schemaName: "_PROD"); //Add views in each db to remap Schema back to [AD]

            modelBuilder.Entity<ConfigParamPROD>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamsPROD);

            modelBuilder.Entity<ConfigParamPROD>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamsPROD);


            modelBuilder.Entity<ConfigParamSTG1>()
                .ToTable("ConfigParam" , schemaName: "_STG1");

            modelBuilder.Entity<ConfigParamSTG1>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamsSTG1);

            modelBuilder.Entity<ConfigParamSTG1>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamsSTG1);


            modelBuilder.Entity<ConfigParamSTG2>()
                .ToTable("ConfigParam" , schemaName: "_STG2");

            modelBuilder.Entity<ConfigParamSTG2>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamsSTG2);

            modelBuilder.Entity<ConfigParamSTG2>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamsSTG2);


            modelBuilder.Entity<ConfigParamQA1>()
                .ToTable("ConfigParam" , schemaName: "_QA1");

            modelBuilder.Entity<ConfigParamQA1>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamsQA1);

            modelBuilder.Entity<ConfigParamQA1>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamsQA1);


            modelBuilder.Entity<ConfigParamQA2>()
                .ToTable("ConfigParam" , schemaName: "_QA2");

			modelBuilder.Entity<ConfigParamQA2>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamsQA2);

			modelBuilder.Entity<ConfigParamQA2>()
                .HasRequired(cp => cp.ParamDefinition)
			    .WithMany(pd => pd.ConfigParamsQA2);


            modelBuilder.Entity<ConfigParamDEV1>()
                .ToTable("ConfigParam" , schemaName: "_DEV1");

            modelBuilder.Entity<ConfigParamDEV1>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamsDEV1);

            modelBuilder.Entity<ConfigParamDEV1>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamsDEV1);


            modelBuilder.Entity<ConfigParamDEV2>()
                .ToTable("ConfigParam" , schemaName: "_DEV2");

            modelBuilder.Entity<ConfigParamDEV2>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamsDEV2);

            modelBuilder.Entity<ConfigParamDEV2>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamsDEV2);



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

            modelBuilder.Entity<Config>()
               .HasMany(c => c.JPlanLOBs)
               .WithMany(jpl => jpl.Configs)
               .Map(ap => {
                   ap.MapLeftKey("jPlanLOB");
                   ap.MapRightKey("config");
                   ap.ToTable("J_Config_JPlanLOB");
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

            modelBuilder.Entity<PathServer>()
              .HasMany(srv => srv.PathShare)
              .WithMany(shr => shr.PathServer)
              .Map(ap => {
                  ap.MapLeftKey("pathServer");
                  ap.MapRightKey("pathShare");
                  ap.ToTable("J_PathServer_PathShare");
              });

            modelBuilder.Entity<Config>()
               .HasRequired(c => c.App)
               .WithMany(a => a.Configs);

            modelBuilder.Entity<Config>()
              .HasRequired(c => c.ParamVersion)
              .WithMany(pv => pv.Configs);

            modelBuilder.Entity<Executable>()
              .HasRequired(e => e.ParamVersion)  //wanted to change this to HasOptional while adding to fluent, but EF (or maybe just EF PowerTools?) was fighting the change even after removing the [Required] decoration in entity model
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

            }


        public DbSet<App> app { get; set; }
        public DbSet<Config> config { get; set; }

        public DbSet<ConfigParamPROD> configParamPROD { get; set; }
        public DbSet<ConfigParamSTG1> configParamSTG1 { get; set; }
        public DbSet<ConfigParamSTG2> configParamSTG2 { get; set; }
        public DbSet<ConfigParamQA1> configParamQA1 { get; set; }
        public DbSet<ConfigParamQA2> configParamQA2 { get; set; }
        public DbSet<ConfigParamDEV1> configParamDev1 { get; set; }
        public DbSet<ConfigParamDEV2> configParamDev2 { get; set; }


        public DbSet<Executable> executable { get; set; }
        public DbSet<JPlanLOB> jPlanLOB { get; set; }
        public DbSet<LineOfBusiness> lineOfBusiness { get; set; }
        public DbSet<PrimaryFunction> executableFunctions { get; set; }
        public DbSet<ParamDefinition> paramDefinitions { get; set; }
        public DbSet<ParamType> paramType { get; set; }
        public DbSet<ParamVersion> paramVersion { get; set; }
        public DbSet<PathServer> pathServer { get; set; }
        public DbSet<PathShare> pathShare { get; set; }
        public DbSet<Plan> plan { get; set; }

        }

    }
