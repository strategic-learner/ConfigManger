namespace Company.DIV.ConfigMgr.Data.Read.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuditTables_AddMissingDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "AD.AppAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ITIL = c.Int(nullable: false),
                        abbr = c.String(maxLength: 3),
                        description = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        jobID = c.Int(nullable: false),
                        AppID = c.Guid(nullable: false),
                        ParamVersionID = c.Guid(nullable: false),
                        Active = c.Boolean(nullable: false),
                        DescriptonShort = c.String(maxLength: 25),
                        DescriptonFull = c.String(maxLength: 100),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamDEV1Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamDEV2Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamPRODAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamQA1Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamQA2Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamSTG1Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamSTG2Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ExecutableAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ParamVersionID = c.Guid(nullable: false),
                        AppID = c.Guid(nullable: false),
                        nameWExtension = c.String(maxLength: 256),
                        description = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.PrimaryFunctionAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        abbr = c.String(maxLength: 3),
                        description = c.String(maxLength: 50),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.JAppPlanAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        AppID = c.Guid(nullable: false),
                        PlanID = c.Guid(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.JConfigExecutableAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.JConfigJPlanLOBAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        JPlanLOBID = c.Guid(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.JConfigPlanAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        PlanID = c.Guid(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.JExecutablePathServerAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        PathServerID = c.Guid(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.JExecutablePrimaryFunctionAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        PrimaryFunctionID = c.Guid(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.JPathServerPathShareAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        PathServerID = c.Guid(nullable: false),
                        PathShareID = c.Guid(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.JPlanLOBAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        planID = c.Guid(nullable: false),
                        LineOfBusinessID = c.Guid(nullable: false),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.LineOfBusinessAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        abbr = c.String(maxLength: 10),
                        descr = c.String(maxLength: 50),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ParamDefinitionAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        ParamVersionID = c.Guid(nullable: false),
                        ParamSequence = c.Int(nullable: false),
                        ParamTypeID = c.Guid(nullable: false),
                        variableName = c.String(maxLength: 50),
                        intendedUse = c.String(maxLength: 500),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ParamTypeAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        type = c.String(maxLength: 15),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ParamVersionAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        version = c.Single(nullable: false),
                        description = c.String(maxLength: 100),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.PathServerAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        server = c.String(maxLength: 256),
                        path = c.String(maxLength: 256),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.PathShareAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        share = c.String(maxLength: 256),
                        path = c.String(maxLength: 256),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.PlanAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID_ = c.Guid(nullable: false),
                        abbr = c.String(maxLength: 4),
                        descr = c.String(maxLength: 50),
                        updateDT_ = c.DateTime(nullable: false),
                        updateUser_ = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            DropColumn("AD.App", "createDT");
            DropColumn("AD.App", "createUser");
            DropColumn("AD.Config", "createDT");
            DropColumn("AD.Config", "createUser");
            DropColumn("_DEV1.ConfigParam", "createDT");
            DropColumn("_DEV1.ConfigParam", "createUser");
            DropColumn("AD.ParamDefinition", "createDT");
            DropColumn("AD.ParamDefinition", "createUser");
            DropColumn("_DEV2.ConfigParam", "createDT");
            DropColumn("_DEV2.ConfigParam", "createUser");
            DropColumn("_PROD.ConfigParam", "createDT");
            DropColumn("_PROD.ConfigParam", "createUser");
            DropColumn("_QA1.ConfigParam", "createDT");
            DropColumn("_QA1.ConfigParam", "createUser");
            DropColumn("_QA2.ConfigParam", "createDT");
            DropColumn("_QA2.ConfigParam", "createUser");
            DropColumn("_STG1.ConfigParam", "createDT");
            DropColumn("_STG1.ConfigParam", "createUser");
            DropColumn("_STG2.ConfigParam", "createDT");
            DropColumn("_STG2.ConfigParam", "createUser");
            DropColumn("AD.ParamType", "createDT");
            DropColumn("AD.ParamType", "createUser");
            DropColumn("AD.ParamVersion", "createDT");
            DropColumn("AD.ParamVersion", "createUser");
            DropColumn("AD.Executable", "createDT");
            DropColumn("AD.Executable", "createUser");
            DropColumn("AD.J_Config_Executable", "createDT");
            DropColumn("AD.J_Config_Executable", "createUser");
            DropColumn("AD.J_Executable_PathServer", "createDT");
            DropColumn("AD.J_Executable_PathServer", "createUser");
            DropColumn("AD.PathServer", "createDT");
            DropColumn("AD.PathServer", "createUser");
            DropColumn("AD.J_PathServer_PathShare", "createDT");
            DropColumn("AD.J_PathServer_PathShare", "createUser");
            DropColumn("AD.PathShare", "createDT");
            DropColumn("AD.PathShare", "createUser");
            DropColumn("AD.J_Executable_PrimaryFunction", "createDT");
            DropColumn("AD.J_Executable_PrimaryFunction", "createUser");
            DropColumn("AD.PrimaryFunction", "createDT");
            DropColumn("AD.PrimaryFunction", "createUser");
            DropColumn("AD.J_Config_JPlanLOB", "createDT");
            DropColumn("AD.J_Config_JPlanLOB", "createUser");
            DropColumn("AD.J_Plan_LOB", "createDT");
            DropColumn("AD.J_Plan_LOB", "createUser");
            DropColumn("AD.LineOfBusiness", "createDT");
            DropColumn("AD.LineOfBusiness", "createUser");
            DropColumn("AD.Plan", "createDT");
            DropColumn("AD.Plan", "createUser");
            DropColumn("AD.J_App_Plan", "createDT");
            DropColumn("AD.J_App_Plan", "createUser");
            DropColumn("AD.J_Config_Plan", "createDT");
            DropColumn("AD.J_Config_Plan", "createUser");
        }
        
        public override void Down()
        {
            AddColumn("AD.J_Config_Plan", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.J_Config_Plan", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.J_App_Plan", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.J_App_Plan", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.Plan", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.Plan", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.LineOfBusiness", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.LineOfBusiness", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.J_Plan_LOB", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.J_Plan_LOB", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.J_Config_JPlanLOB", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.J_Config_JPlanLOB", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.PrimaryFunction", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.PrimaryFunction", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.J_Executable_PrimaryFunction", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.J_Executable_PrimaryFunction", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.PathShare", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.PathShare", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.J_PathServer_PathShare", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.J_PathServer_PathShare", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.PathServer", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.PathServer", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.J_Executable_PathServer", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.J_Executable_PathServer", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.J_Config_Executable", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.J_Config_Executable", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.Executable", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.Executable", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.ParamVersion", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.ParamVersion", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.ParamType", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.ParamType", "createDT", c => c.DateTime(nullable: false));
            AddColumn("_STG2.ConfigParam", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("_STG2.ConfigParam", "createDT", c => c.DateTime(nullable: false));
            AddColumn("_STG1.ConfigParam", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("_STG1.ConfigParam", "createDT", c => c.DateTime(nullable: false));
            AddColumn("_QA2.ConfigParam", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("_QA2.ConfigParam", "createDT", c => c.DateTime(nullable: false));
            AddColumn("_QA1.ConfigParam", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("_QA1.ConfigParam", "createDT", c => c.DateTime(nullable: false));
            AddColumn("_PROD.ConfigParam", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("_PROD.ConfigParam", "createDT", c => c.DateTime(nullable: false));
            AddColumn("_DEV2.ConfigParam", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("_DEV2.ConfigParam", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.ParamDefinition", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.ParamDefinition", "createDT", c => c.DateTime(nullable: false));
            AddColumn("_DEV1.ConfigParam", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("_DEV1.ConfigParam", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.Config", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.Config", "createDT", c => c.DateTime(nullable: false));
            AddColumn("AD.App", "createUser", c => c.String(nullable: false, maxLength: 20));
            AddColumn("AD.App", "createDT", c => c.DateTime(nullable: false));
            DropTable("AD.PlanAudit");
            DropTable("AD.PathShareAudit");
            DropTable("AD.PathServerAudit");
            DropTable("AD.ParamVersionAudit");
            DropTable("AD.ParamTypeAudit");
            DropTable("AD.ParamDefinitionAudit");
            DropTable("AD.LineOfBusinessAudit");
            DropTable("AD.JPlanLOBAudit");
            DropTable("AD.JPathServerPathShareAudit");
            DropTable("AD.JExecutablePrimaryFunctionAudit");
            DropTable("AD.JExecutablePathServerAudit");
            DropTable("AD.JConfigPlanAudit");
            DropTable("AD.JConfigJPlanLOBAudit");
            DropTable("AD.JConfigExecutableAudit");
            DropTable("AD.JAppPlanAudit");
            DropTable("AD.PrimaryFunctionAudit");
            DropTable("AD.ExecutableAudit");
            DropTable("AD.ConfigParamSTG2Audit");
            DropTable("AD.ConfigParamSTG1Audit");
            DropTable("AD.ConfigParamQA2Audit");
            DropTable("AD.ConfigParamQA1Audit");
            DropTable("AD.ConfigParamPRODAudit");
            DropTable("AD.ConfigParamDEV2Audit");
            DropTable("AD.ConfigParamDEV1Audit");
            DropTable("AD.ConfigAudit");
            DropTable("AD.AppAudit");
        }
    }
}
