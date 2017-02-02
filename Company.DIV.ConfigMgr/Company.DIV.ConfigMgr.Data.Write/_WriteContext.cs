using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Company.DIV.ConfigMgr.Domain.Write;


namespace Company.DIV.ConfigMgr.Data.Write
    {
    public interface IConfigMgrWriteContext {/* for DI */}

    public sealed class ConfigMgrWriteContext : DbContext, IConfigMgrWriteContext
        {
        public ConfigMgrWriteContext() :
        base("name=ConfigMgr") 
            {
            this.Configuration.LazyLoadingEnabled = false;

#if DEBUG
            Database.Log = Console.WriteLine;
#endif
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

        public DbSet<JAppPlan> jAppPlan { get; set; }
        public DbSet<JConfigExecutable> jConfigExecutable { get; set; }
        public DbSet<JConfigJPlanLOB> jConfigJPlanLOB { get; set; }
        public DbSet<JExecutablePathServer> jExecutablePathServer { get; set; }
        public DbSet<JExecutablePrimaryFunction> jExecutablePrimaryFunction { get; set; }
        public DbSet<JPathServerPathShare> jPathServerPathShare { get; set; }
        public DbSet<JPlanLOB> jPlanLOB { get; set; }
        
        public DbSet<LineOfBusiness> lineOfBusiness { get; set; }
        public DbSet<PrimaryFunction> executableFunction { get; set; }
        public DbSet<ParamDefinition> paramDefinition { get; set; }
        public DbSet<ParamType> paramType { get; set; }
        public DbSet<ParamVersion> paramVersion { get; set; }
        public DbSet<PathServer> pathServer { get; set; }
        public DbSet<PathShare> pathShare { get; set; }
        public DbSet<Plan> plan { get; set; }

        }

    }
