using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Company.DIV.ConfigMgr.Domain;
using Company.DIV.ConfigMgr.Domain.Read;
//using Company.DIV.ConfigMgr.Domain;


namespace Company.DIV.ConfigMgr.Data.Read
    {
    public interface IConfigMgrReadContext {/* for DI */}

    public sealed class ConfigMgrReadContext : DbContext, IConfigMgrReadContext
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
            //Database.Log = Console.WriteLine;
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




            modelBuilder.Types<EntityRead>()
            .Configure(t => {
                t.Property(p => p.ID).IsKey();
                t.Property(p => p.updateDT).IsRequired();
                t.Property(p => p.updateUser).IsRequired().HasMaxLength(20);
            });


            modelBuilder.Types<EntityAudit>()
            .Configure(t => {
                t.Property(p => p.AuditID).IsKey();
                t.Property(p => p.AuditType).IsRequired();
                t.Property(p => p.AuditDT).IsRequired();
                t.Property(p => p.AuditSUserSName).IsRequired().HasMaxLength(20);

                t.Property(p => p.ID).IsOptional();
                t.Property(p => p.updateDT).IsOptional();
                t.Property(p => p.updateUser).IsOptional().HasMaxLength(20);
            });


            #endregion


            //Ignored classes  (code-first table settings)
            modelBuilder.Ignore<EntityAudit>();
            modelBuilder.Ignore<EntityRead>();
            modelBuilder.Ignore<EntityWrite>(); //just in case
            modelBuilder.Ignore<ConfigParam>();
            modelBuilder.Ignore<EntityStateDisconnected>();
            modelBuilder.Ignore<DTOPlanLOB>();
            



            //App (code-first table settings)
            modelBuilder.Entity<App>().MapToStoredProcedures();
            //modelBuilder.Entity<App>()
            //    .Property(p => p.createUser).IsRequired();

            modelBuilder.Entity<App>()
                .HasMany(a => a.Configs)
                .WithRequired().HasForeignKey(c=>c.AppID);

            modelBuilder.Entity<App>()
                .HasMany(a => a.Executables)
                .WithRequired().HasForeignKey(e => e.AppID);

            modelBuilder.Entity<App>()
                .HasMany(a => a.JAppPlans)
                .WithRequired().HasForeignKey(jap => jap.AppID);



            //Config (code-first table settings)
            modelBuilder.Entity<Config>().MapToStoredProcedures();

            modelBuilder.Entity<Config>()
                .HasMany(c => c.JConfigJPlanLOBs)
                .WithRequired().HasForeignKey(jcjpl => jcjpl.ConfigID);

            modelBuilder.Entity<Config>()    //Depricate this                
                .HasMany(c => c.JConfigPlans)    //Depricate this                
                .WithRequired().HasForeignKey(jcp => jcp.ConfigID);

            modelBuilder.Entity<Config>()
                .HasMany(c => c.JConfigExecutables)
                .WithRequired().HasForeignKey(jce => jce.ConfigID);


            modelBuilder.Entity<Config>()
                    .HasMany(c => c.ConfigParamPROD)
                    .WithRequired().HasForeignKey(cp => cp.ConfigID);

            modelBuilder.Entity<Config>()
                    .HasMany(c => c.ConfigParamSTG1)
                    .WithRequired().HasForeignKey(cp => cp.ConfigID);

            modelBuilder.Entity<Config>()
                    .HasMany(c => c.ConfigParamSTG2)
                    .WithRequired().HasForeignKey(cp => cp.ConfigID);

            modelBuilder.Entity<Config>()
                    .HasMany(c => c.ConfigParamQA1)
                    .WithRequired().HasForeignKey(cp => cp.ConfigID);

            modelBuilder.Entity<Config>()
                    .HasMany(c => c.ConfigParamQA2)
                    .WithRequired().HasForeignKey(cp => cp.ConfigID);

            modelBuilder.Entity<Config>()
                    .HasMany(c => c.ConfigParamDEV1)
                    .WithRequired().HasForeignKey(cp => cp.ConfigID);

            modelBuilder.Entity<Config>()
                    .HasMany(c => c.ConfigParamDEV2)
                    .WithRequired().HasForeignKey(cp => cp.ConfigID);


            //ConfigParamPROD (code-first table settings)
            modelBuilder.Entity<ConfigParamPROD>().MapToStoredProcedures();

            //ConfigParamSTG1 (code-first table settings)
            modelBuilder.Entity<ConfigParamSTG1>().MapToStoredProcedures();

            //ConfigParamSTG2 (code-first table settings)
            modelBuilder.Entity<ConfigParamSTG2>().MapToStoredProcedures();

            //ConfigParamQA1 (code-first table settings)
            modelBuilder.Entity<ConfigParamQA1>().MapToStoredProcedures();

            //ConfigParamQA2 (code-first table settings)
            modelBuilder.Entity<ConfigParamQA2>().MapToStoredProcedures();

            //ConfigParamDEV1 (code-first table settings)
            modelBuilder.Entity<ConfigParamDEV1>().MapToStoredProcedures();

            //ConfigParamDEV2 (code-first table settings)
            modelBuilder.Entity<ConfigParamDEV2>().MapToStoredProcedures();

            //Executable (code-first table settings)
            modelBuilder.Entity<Executable>().MapToStoredProcedures();

            modelBuilder.Entity<Executable>()
                .HasMany(e => e.JConfigExecutables)
                .WithRequired().HasForeignKey(jce => jce.ExecutableID);
            modelBuilder.Entity<Executable>()
                .HasMany(y => y.JExecutablePathServers)
                .WithRequired().HasForeignKey(jeps => jeps.ExecutableID);
            modelBuilder.Entity<Executable>()
                .HasMany(y => y.JExecutablePrimaryFunctions)
                .WithRequired().HasForeignKey(jepf => jepf.ExecutableID);


            //JAppPlan (code-first table settings)
            modelBuilder.Entity<JAppPlan>().MapToStoredProcedures();

            modelBuilder.Entity<JAppPlan>().ToTable("J_App_Plan");

            modelBuilder.Entity<JAppPlanAudit>().ToTable("J_App_Plan_Audit");


            //JConfigExecutable (code-first table settings)
            modelBuilder.Entity<JConfigExecutable>().MapToStoredProcedures();

            modelBuilder.Entity<JConfigExecutable>().ToTable("J_Config_Executable");

            modelBuilder.Entity<JConfigExecutableAudit>().ToTable("J_Config_Executable_Audit");


            //JConfigJPlanLOB (code-first table settings)
            modelBuilder.Entity<JConfigJPlanLOB>().MapToStoredProcedures();

            modelBuilder.Entity<JConfigJPlanLOB>().ToTable("J_Config_JPlanLOB");

            modelBuilder.Entity<JConfigJPlanLOBAudit>().ToTable("J_Config_JPlanLOB_Audit");


            //JConfigPlan (code-first table settings)
            modelBuilder.Entity<JConfigPlan>().MapToStoredProcedures();

            modelBuilder.Entity<JConfigPlan>().ToTable("J_Config_Plan");

            modelBuilder.Entity<JConfigPlanAudit>().ToTable("J_Config_Plan_Audit");


            //JExecutablePathServer (code-first table settings)
            modelBuilder.Entity<JExecutablePathServer>().MapToStoredProcedures();

            modelBuilder.Entity<JExecutablePathServer>().ToTable("J_Executable_PathServer");

            modelBuilder.Entity<JExecutablePathServerAudit>().ToTable("J_Executable_PathServer_Audit");


            //JExecutablePrimaryFunction (code-first table settings)
            modelBuilder.Entity<JExecutablePrimaryFunction>().MapToStoredProcedures();

            modelBuilder.Entity<JExecutablePrimaryFunction>()
                .ToTable("J_Executable_PrimaryFunction");

            modelBuilder.Entity<JExecutablePrimaryFunctionAudit>()
                .ToTable("J_Executable_PrimaryFunction_Audit");


            //JPathServerPathShare (code-first table settings)
            modelBuilder.Entity<JPathServerPathShare>().MapToStoredProcedures();

            modelBuilder.Entity<JPathServerPathShare>().ToTable("J_PathServer_PathShare");

            modelBuilder.Entity<JPathServerPathShareAudit>().ToTable("J_PathServer_PathShare_Audit");


            //JPlanLOB (code-first table settings)
            modelBuilder.Entity<JPlanLOB>().MapToStoredProcedures();

            modelBuilder.Entity<JPlanLOB>().ToTable("J_Plan_LOB");

            modelBuilder.Entity<JPlanLOBAudit>().ToTable("J_Plan_LOB_Audit");

            modelBuilder.Entity<JPlanLOB>()
                .HasMany(jpl => jpl.JConfigJPlanLOBs)
                .WithRequired().HasForeignKey(jcjpl => jcjpl.JPlanLOBID);


            //LineOfBusiness (code-first table settings)
            modelBuilder.Entity<LineOfBusiness>().MapToStoredProcedures();

            modelBuilder.Entity<LineOfBusiness>()
                .HasMany(lob => lob.JPlanLOB)
                .WithRequired().HasForeignKey(jpl => jpl.LineOfBusinessID);


            //PrimaryFunction (code-first table settings)
            modelBuilder.Entity<PrimaryFunction>().MapToStoredProcedures();

            modelBuilder.Entity<PrimaryFunction>()
                .HasMany(z => z.JExecutablePrimaryFunctions)
                .WithRequired().HasForeignKey(jepf => jepf.PrimaryFunctionID);


            //ParamDefinition (code-first table settings)
            modelBuilder.Entity<ParamDefinition>().MapToStoredProcedures();

            modelBuilder.Entity<ParamDefinition>()
                .HasMany(pd => pd.ConfigParamPROD)
                .WithRequired()
                .HasForeignKey(cp => cp.ParamDefinitionID);

            modelBuilder.Entity<ParamDefinition>()
                .HasMany(pd => pd.ConfigParamSTG1)
                .WithRequired()
                .HasForeignKey(cp => cp.ParamDefinitionID);

            modelBuilder.Entity<ParamDefinition>()
                .HasMany(pd => pd.ConfigParamSTG2)
                .WithRequired()
                .HasForeignKey(cp => cp.ParamDefinitionID);

            modelBuilder.Entity<ParamDefinition>()
                .HasMany(pd => pd.ConfigParamQA1)
                .WithRequired()
                .HasForeignKey(cp => cp.ParamDefinitionID);

            modelBuilder.Entity<ParamDefinition>()
                .HasMany(pd => pd.ConfigParamQA2)
                .WithRequired()
                .HasForeignKey(cp => cp.ParamDefinitionID);

            modelBuilder.Entity<ParamDefinition>()
                .HasMany(pd => pd.ConfigParamDEV1)
                .WithRequired()
                .HasForeignKey(cp => cp.ParamDefinitionID);

            modelBuilder.Entity<ParamDefinition>()
                .HasMany(pd => pd.ConfigParamDEV2)
                .WithRequired()
                .HasForeignKey(cp => cp.ParamDefinitionID);


            //ParamType (code-first table settings)
            modelBuilder.Entity<ParamType>().MapToStoredProcedures();

            modelBuilder.Entity<ParamType>()
                .HasMany(pt => pt.ParamDefinitions)
                .WithRequired()
                .HasForeignKey(pd => pd.ParamTypeID);



            //ParamVersion (code-first table settings)
            modelBuilder.Entity<ParamVersion>().MapToStoredProcedures();

            modelBuilder.Entity<ParamVersion>()
                .HasMany(pv => pv.Configs)
            .WithRequired()
                .HasForeignKey(c => c.ParamVersionID);

            modelBuilder.Entity<ParamVersion>()
                .HasMany(pv => pv.Executables)
                .WithOptional().HasForeignKey(e => e.ParamVersionID);

            modelBuilder.Entity<ParamVersion>()
                .HasMany(pv => pv.ParamDefinitions)
                .WithRequired()
                .HasForeignKey(pd => pd.ParamVersionID);


            //PathServer (code-first table settings)
            modelBuilder.Entity<PathServer>().MapToStoredProcedures();

            modelBuilder.Entity<PathServer>()
                .HasMany(ps1 => ps1.JPathServerPathShares)
                .WithRequired().HasForeignKey(jpsps => jpsps.PathServerID);

            modelBuilder.Entity<PathServer>()
                .HasMany(z => z.JExecutablePathServers)
                .WithRequired().HasForeignKey(jeps => jeps.PathServerID);

            modelBuilder.Entity<PathShare>()
                .HasMany(ps2 => ps2.JPathServerPathShares)
                .WithRequired().HasForeignKey(jpsps => jpsps.PathShareID);


            //PathShare (code-first table settings)
            modelBuilder.Entity<PathShare>().MapToStoredProcedures();

            //Plan (code-first table settings)
            modelBuilder.Entity<Plan>().MapToStoredProcedures();

            modelBuilder.Entity<Plan>()
                .HasMany(p => p.JAppPlans)
                .WithRequired().HasForeignKey(jap => jap.PlanID);

            modelBuilder.Entity<Plan>()
                .HasMany(p => p.JPlanLOB)
                .WithRequired().HasForeignKey(jpl => jpl.PlanID);

            modelBuilder.Entity<Plan>()    //Depricate this                
                .HasMany(p => p.JConfigPlans)    //Depricate this               
                .WithRequired().HasForeignKey(jcp => jcp.PlanID);


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
