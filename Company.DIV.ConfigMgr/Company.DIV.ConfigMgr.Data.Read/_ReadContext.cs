﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Read;
//using Company.DIV.ConfigMgr.Domain;


namespace Company.DIV.ConfigMgr.Data.Read
    {
    internal class ConfigMgrReadContext : DbContext
        {
        public ConfigMgrReadContext() :
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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //very little if anything should ever be deleted - mostly deactivated (ConfigParam data is an exception, but no dependency concern)
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.HasDefaultSchema("AD");
            
            //These non-"AD" Schemas are for clear environment 'domain' separation within the db.  Make the cross-server setup unmistakeable for DBA replication , or pub/sub
            modelBuilder.Entity<ConfigParamPROD>()
                .ToTable("ConfigParam" , schemaName: "_PROD"); //TODO Add views in respective db to remap Schema back to [AD].[ConfigParam]

            modelBuilder.Entity<ConfigParamSTG1>()
                .ToTable("ConfigParam" , schemaName: "_STG1"); //TODO Add views in respective db to remap Schema back to [AD].[ConfigParam]

            modelBuilder.Entity<ConfigParamSTG2>()
                .ToTable("ConfigParam" , schemaName: "_STG2"); //TODO Add views in respective db to remap Schema back to [AD].[ConfigParam]

            modelBuilder.Entity<ConfigParamQA1>()
                .ToTable("ConfigParam" , schemaName: "_QA1"); //TODO Add views in respective db to remap Schema back to [AD].[ConfigParam]

            modelBuilder.Entity<ConfigParamQA2>()
                .ToTable("ConfigParam" , schemaName: "_QA2"); //TODO Add views in respective db to remap Schema back to [AD].[ConfigParam]

            modelBuilder.Entity<ConfigParamDEV1>()
                .ToTable("ConfigParam" , schemaName: "_DEV1"); //TODO Add views in respective db to remap Schema back to [AD].[ConfigParam]

            modelBuilder.Entity<ConfigParamDEV2>()
                .ToTable("ConfigParam" , schemaName: "_DEV2"); //TODO Add views in respective db to remap Schema back to [AD].[ConfigParam]



            #region GeneralConventionNDefaultOverrides

            modelBuilder.Properties<String>()
                .Configure(s => s.HasMaxLength(20)); //Just a default

            modelBuilder.Properties<Guid>()
                .Where(p => p.Name == "ID")
                .Configure(c => c.IsKey());

            modelBuilder.Properties<string>()
                .Where(p => p.Name.Length > 4 && p.Name.EndsWith("User"))
                .Configure(c => c.HasMaxLength(20).IsRequired());

            modelBuilder.Properties<DateTime>()
                .Where(p => p.Name == "createDT")
                .Configure(c => c.IsRequired());

            modelBuilder.Properties<DateTime>()
                .Where(p => p.Name == "updateDT")
                .Configure(c => c.IsRequired());


            modelBuilder.Properties<int>()
                .Where(p => p.Name == "AuditID")
                .Configure(c => c.IsKey());

            modelBuilder.Properties<DateTime>()
                .Where(p => p.Name.StartsWith("Audit"))
                .Configure(c => c.IsRequired());

            modelBuilder.Properties<byte>()
                .Where(p => p.Name.StartsWith("Audit"))
                .Configure(c => c.IsRequired());

            modelBuilder.Properties<string>()
                .Where(p => p.Name.StartsWith("Audit"))
                .Configure(c => c.HasMaxLength(20).IsRequired());

            #endregion


            //Ignored classes  (code-first table settings)
            modelBuilder.Ignore<ConfigParam>();
            modelBuilder.Ignore<EntityStateDisconnected>();


            //App (code-first table settings)
            modelBuilder.Entity<App>().MapToStoredProcedures();
            modelBuilder.Entity<AppAudit>().MapToStoredProcedures();
            //modelBuilder.Entity<App>()
            //    .Property(p => p.createUser).IsRequired();


            //Config (code-first table settings)
            modelBuilder.Entity<Config>().MapToStoredProcedures();
            modelBuilder.Entity<ConfigAudit>().MapToStoredProcedures();

            modelBuilder.Entity<Config>()
                .HasRequired(c => c.App)
                .WithMany(a => a.Configs);

            modelBuilder.Entity<Config>()
              .HasRequired(c => c.ParamVersion)
              .WithMany(pv => pv.Configs);

            //ConfigParamPROD (code-first table settings)
            modelBuilder.Entity<ConfigParamPROD>().MapToStoredProcedures();
            modelBuilder.Entity<ConfigParamPRODAudit>().MapToStoredProcedures();

            modelBuilder.Entity<ConfigParamPROD>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamPROD);

            modelBuilder.Entity<ConfigParamPROD>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamPROD);

            //ConfigParamSTG1 (code-first table settings)
            modelBuilder.Entity<ConfigParamSTG1>().MapToStoredProcedures();
            modelBuilder.Entity<ConfigParamSTG1Audit>().MapToStoredProcedures();

            modelBuilder.Entity<ConfigParamSTG1>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamSTG1);

            modelBuilder.Entity<ConfigParamSTG1>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamSTG1);


            //ConfigParamSTG2 (code-first table settings)
            modelBuilder.Entity<ConfigParamSTG2>().MapToStoredProcedures();
            modelBuilder.Entity<ConfigParamSTG2Audit>().MapToStoredProcedures();

            modelBuilder.Entity<ConfigParamSTG2>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamSTG2);

            modelBuilder.Entity<ConfigParamSTG2>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamSTG2);


            //ConfigParamQA1 (code-first table settings)
            modelBuilder.Entity<ConfigParamQA1>().MapToStoredProcedures();
            modelBuilder.Entity<ConfigParamQA1Audit>().MapToStoredProcedures();

            modelBuilder.Entity<ConfigParamQA1>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamQA1);

            modelBuilder.Entity<ConfigParamQA1>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamQA1);


            //ConfigParamQA2 (code-first table settings)
            modelBuilder.Entity<ConfigParamQA2>().MapToStoredProcedures();
            modelBuilder.Entity<ConfigParamQA2Audit>().MapToStoredProcedures();

            modelBuilder.Entity<ConfigParamQA2>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamQA2);

            modelBuilder.Entity<ConfigParamQA2>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamQA2);


            //ConfigParamDEV1 (code-first table settings)
            modelBuilder.Entity<ConfigParamDEV1>().MapToStoredProcedures();
            modelBuilder.Entity<ConfigParamDEV1Audit>().MapToStoredProcedures();

            modelBuilder.Entity<ConfigParamDEV1>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamDEV1);

            modelBuilder.Entity<ConfigParamDEV1>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamDEV1);


            //ConfigParamDEV2 (code-first table settings)
            modelBuilder.Entity<ConfigParamDEV2>().MapToStoredProcedures();
            modelBuilder.Entity<ConfigParamDEV2Audit>().MapToStoredProcedures();

            modelBuilder.Entity<ConfigParamDEV2>()
                .HasRequired(cp => cp.ParamDefinition)
                .WithMany(pd => pd.ConfigParamDEV2);

            modelBuilder.Entity<ConfigParamDEV2>()
                .HasRequired(cp => cp.Config)
                .WithMany(c => c.ConfigParamDEV2);


            //Executable (code-first table settings)
            modelBuilder.Entity<Executable>().MapToStoredProcedures();
            modelBuilder.Entity<ExecutableAudit>().MapToStoredProcedures();

            modelBuilder.Entity<Executable>()
                .HasRequired(e => e.ParamVersion)  //wanted to change this to HasOptional while adding to fluent, but EF (or maybe just EF PowerTools?) was fighting the change even after removing the [Required] decoration in entity model
                .WithMany(pv => pv.Executables);

            modelBuilder.Entity<Executable>()
              .HasRequired(e => e.App)
              .WithMany(a => a.Executables);


            //JAppPlan (code-first table settings)
            modelBuilder.Entity<JAppPlan>().MapToStoredProcedures();
            modelBuilder.Entity<JAppPlanAudit>().MapToStoredProcedures();

            modelBuilder.Entity<JAppPlan>()
                .ToTable("J_App_Plan");

            modelBuilder.Entity<JAppPlan>()
                .HasRequired(jap => jap.App)
                .WithMany(a => a.JAppPlans);

            modelBuilder.Entity<JAppPlan>()
                .HasRequired(jap => jap.Plan)
                .WithMany(p => p.JAppPlans);


            //JConfigExecutable (code-first table settings)
            modelBuilder.Entity<JConfigExecutable>().MapToStoredProcedures();
            modelBuilder.Entity<JConfigExecutableAudit>().MapToStoredProcedures();

            modelBuilder.Entity<JConfigExecutable>()
                .ToTable("J_Config_Executable");

            modelBuilder.Entity<JConfigExecutable>()
                .HasRequired(jce => jce.Executable)
                .WithMany(e => e.JConfigExecutables);

            modelBuilder.Entity<JConfigExecutable>()
                .HasRequired(jce => jce.Config)
                .WithMany(c => c.JConfigExecutables);


            //JConfigJPlanLOB (code-first table settings)
            modelBuilder.Entity<JConfigJPlanLOB>().MapToStoredProcedures();
            modelBuilder.Entity<JConfigJPlanLOBAudit>().MapToStoredProcedures();

            modelBuilder.Entity<JConfigJPlanLOB>()
                .ToTable("J_Config_JPlanLOB");

            modelBuilder.Entity<JConfigJPlanLOB>()
                .HasRequired(jcjpl => jcjpl.Config)
                .WithMany(c => c.JConfigJPlanLOBs);

            modelBuilder.Entity<JConfigJPlanLOB>()
                .HasRequired(jcjpl => jcjpl.JPlanLOB)
                .WithMany(jpl => jpl.JConfigJPlanLOBs);


            //JConfigPlan (code-first table settings)
            modelBuilder.Entity<JConfigPlan>().MapToStoredProcedures();
            modelBuilder.Entity<JConfigPlanAudit>().MapToStoredProcedures();

            modelBuilder.Entity<JConfigPlan>()
                .ToTable("J_Config_Plan");

            modelBuilder.Entity<JConfigPlan>()
                .HasRequired(jcp => jcp.Config)
                .WithMany(c => c.JConfigPlans);

            modelBuilder.Entity<JConfigPlan>()
                .HasRequired(jcp => jcp.Plan)
                .WithMany(p => p.JConfigPlans);



            //JExecutablePathServer (code-first table settings)
            modelBuilder.Entity<JExecutablePathServer>().MapToStoredProcedures();
            modelBuilder.Entity<JExecutablePathServerAudit>().MapToStoredProcedures();

            modelBuilder.Entity<JExecutablePathServer>()
                .ToTable("J_Executable_PathServer");

            modelBuilder.Entity<JExecutablePathServer>()
                .HasRequired(jeps => jeps.Executable)
                .WithMany(y => y.JExecutablePathServers);

            modelBuilder.Entity<JExecutablePathServer>()
                .HasRequired(jeps => jeps.PathServer)
                .WithMany(z => z.JExecutablePathServers);


            //JExecutablePrimaryFunction (code-first table settings)
            modelBuilder.Entity<JExecutablePrimaryFunction>().MapToStoredProcedures();
            modelBuilder.Entity<JExecutablePrimaryFunctionAudit>().MapToStoredProcedures();

            modelBuilder.Entity<JExecutablePrimaryFunction>()
                .ToTable("J_Executable_PrimaryFunction");

            modelBuilder.Entity<JExecutablePrimaryFunction>()
                .HasRequired(jepf => jepf.Executable)
                .WithMany(y => y.JExecutablePrimaryFunctions);

            modelBuilder.Entity<JExecutablePrimaryFunction>()
                .HasRequired(jepf => jepf.PrimaryFunction)
                .WithMany(z => z.JExecutablePrimaryFunctions);


            //JPathServerPathShare (code-first table settings)
            modelBuilder.Entity<JPathServerPathShare>().MapToStoredProcedures();
            modelBuilder.Entity<JPathServerPathShareAudit>().MapToStoredProcedures();

            modelBuilder.Entity<JPathServerPathShare>()
                .ToTable("J_PathServer_PathShare");

            modelBuilder.Entity<JPathServerPathShare>()
                .HasRequired(jpsps => jpsps.PathServer)
                .WithMany(ps1 => ps1.JPathServerPathShares);

            modelBuilder.Entity<JPathServerPathShare>()
                .HasRequired(jpsps => jpsps.PathShare)
                .WithMany(ps2 => ps2.JPathServerPathShares);


            //JPlanLOB (code-first table settings)
            modelBuilder.Entity<JPlanLOB>().MapToStoredProcedures();
            modelBuilder.Entity<JPlanLOBAudit>().MapToStoredProcedures();

            modelBuilder.Entity<JPlanLOB>()
                .ToTable("J_Plan_LOB");

            modelBuilder.Entity<JPlanLOB>()
                .HasRequired(jpl => jpl.Plans)
                .WithMany(p => p.JPlanLOB);

            modelBuilder.Entity<JPlanLOB>()
                .HasRequired(jpl => jpl.LineOfBusiness)
                .WithMany(lob =>lob.JPlanLOB);


            //LineOfBusiness (code-first table settings)
            modelBuilder.Entity<LineOfBusiness>().MapToStoredProcedures();
            modelBuilder.Entity<LineOfBusinessAudit>().MapToStoredProcedures();


            //PrimaryFunction (code-first table settings)
            modelBuilder.Entity<PrimaryFunction>().MapToStoredProcedures();
            modelBuilder.Entity<PrimaryFunctionAudit>().MapToStoredProcedures();


            //ParamDefinition (code-first table settings)
            modelBuilder.Entity<ParamDefinition>().MapToStoredProcedures();
            modelBuilder.Entity<ParamDefinitionAudit>().MapToStoredProcedures();

            modelBuilder.Entity<ParamDefinition>()
                .HasRequired(pd => pd.ParamVersion)
                .WithMany(pv => pv.ParamDefinitions);

            modelBuilder.Entity<ParamDefinition>()
              .HasRequired(pd => pd.ParamType)
              .WithMany(pt => pt.ParamDefinitions);

            //ParamType (code-first table settings)
            modelBuilder.Entity<ParamType>().MapToStoredProcedures();
            modelBuilder.Entity<ParamTypeAudit>().MapToStoredProcedures();


            //ParamVersion (code-first table settings)
            modelBuilder.Entity<ParamVersion>().MapToStoredProcedures();
            modelBuilder.Entity<ParamVersionAudit>().MapToStoredProcedures();


            //PathServer (code-first table settings)
            modelBuilder.Entity<PathServer>().MapToStoredProcedures();
            modelBuilder.Entity<PathServerAudit>().MapToStoredProcedures();

            //PathShare (code-first table settings)
            modelBuilder.Entity<PathShare>().MapToStoredProcedures();
            modelBuilder.Entity<PathShareAudit>().MapToStoredProcedures();

            //Plan (code-first table settings)
            modelBuilder.Entity<Plan>().MapToStoredProcedures();
            modelBuilder.Entity<PlanAudit>().MapToStoredProcedures();


            }



        //Audit Entities should have no setters - they have purely db-generated data

        public DbSet<App> app { get; set; }
        public DbSet<AppAudit> appAudit { get; }
        public DbSet<Config> config { get; set; }
        public DbSet<ConfigAudit> configAudit { get;  }

        public DbSet<ConfigParamPROD> configParamPROD { get; set; }
        public DbSet<ConfigParamPRODAudit> configParamPRODAudit { get; }
        public DbSet<ConfigParamSTG1> configParamSTG1 { get; set; }
        public DbSet<ConfigParamSTG1Audit> configParamSTG1Audit { get;  }
        public DbSet<ConfigParamSTG2> configParamSTG2 { get; set; }
        public DbSet<ConfigParamSTG2Audit> configParamSTG2Audit { get;  }
        public DbSet<ConfigParamQA1> configParamQA1 { get; set; }
        public DbSet<ConfigParamQA1Audit> configParamQA1Audit { get; }
        public DbSet<ConfigParamQA2> configParamQA2 { get; set; }
        public DbSet<ConfigParamQA2Audit> configParamQA2Audit { get; }
        public DbSet<ConfigParamDEV1> configParamDev1 { get; set; }
        public DbSet<ConfigParamDEV1Audit> configParamDev1Audit { get; }
        public DbSet<ConfigParamDEV2> configParamDev2 { get; set; }
        public DbSet<ConfigParamDEV2Audit> configParamDev2Audit { get; }
        
        public DbSet<Executable> executable { get; set; }
        public DbSet<ExecutableAudit> executableAudit { get; }

        public DbSet<JAppPlan> jAppPlan { get; set; }
        public DbSet<JAppPlanAudit> jAppPlanAudit { get; }
        public DbSet<JConfigExecutable> jConfigExecutable { get; set; }
        public DbSet<JConfigExecutableAudit> jConfigExecutableAudit { get;  }
        public DbSet<JConfigJPlanLOB> jConfigJPlanLOB { get; set; }
        public DbSet<JConfigJPlanLOBAudit> jConfigJPlanLOBAudit { get;  }
        public DbSet<JConfigPlan> jConfigPlan { get; set; }
        public DbSet<JConfigPlanAudit> jConfigPlanAudit { get;  }
        public DbSet<JExecutablePathServer> jExecutablePathServer { get; set; }
        public DbSet<JExecutablePathServerAudit> jExecutablePathServerAudit { get;  }
        public DbSet<JExecutablePrimaryFunction> jExecutablePrimaryFunction { get; set; }
        public DbSet<JExecutablePrimaryFunctionAudit> jExecutablePrimaryFunctionAudit { get;  }
        public DbSet<JPathServerPathShare> jPathServerPathShare { get; set; }
        public DbSet<JPathServerPathShareAudit> jPathServerPathShareAudit { get;  }
        public DbSet<JPlanLOB> jPlanLOB { get; set; }
        public DbSet<JPlanLOBAudit> jPlanLOBAudit { get;  }

        public DbSet<LineOfBusiness> lineOfBusiness { get; set; }
        public DbSet<LineOfBusinessAudit> lineOfBusinessAudit { get; }
        public DbSet<PrimaryFunction> executableFunction { get; set; }
        public DbSet<PrimaryFunctionAudit> executableFunctionAudit { get; }
        public DbSet<ParamDefinition> paramDefinition { get; set; }
        public DbSet<ParamDefinitionAudit> paramDefinitionAudit { get; }
        public DbSet<ParamType> paramType { get; set; }
        public DbSet<ParamTypeAudit> paramTypeAudit { get; }
        public DbSet<ParamVersion> paramVersion { get; set; }
        public DbSet<ParamVersionAudit> paramVersionAudit { get; }
        public DbSet<PathServer> pathServer { get; set; }
        public DbSet<PathServerAudit> pathServerAudit { get; }
        public DbSet<PathShare> pathShare { get; set; }
        public DbSet<PathShareAudit> pathShareAudit { get; }
        public DbSet<Plan> plan { get; set; }
        public DbSet<PlanAudit> planAudit { get; }

        }

    }
