namespace Company.DIV.ConfigMgr.DataRead.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PreCQRS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "AD.App",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ITIL = c.Int(nullable: false),
                        abbr = c.String(nullable: false, maxLength: 3),
                        description = c.String(nullable: false, maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "AD.Config",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        jobID = c.Int(nullable: false, identity: true),
                        AppID = c.Guid(nullable: false),
                        ParamVersionID = c.Guid(nullable: false),
                        Active = c.Boolean(nullable: false),
                        DescriptonShort = c.String(nullable: false, maxLength: 25),
                        DescriptonFull = c.String(nullable: false, maxLength: 100),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.App", t => t.AppID)
                .ForeignKey("AD.ParamVersion", t => t.ParamVersionID)
                .Index(t => t.AppID)
                .Index(t => t.ParamVersionID);
            
            CreateTable(
                "_DEV1.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                        ParamDefinition_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinition_ID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinition_ID);
            
            CreateTable(
                "AD.ParamDefinition",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ParamVersionID = c.Guid(nullable: false),
                        ParamSequence = c.Int(nullable: false, identity: true),
                        ParamTypeID = c.Guid(nullable: false),
                        variableName = c.String(nullable: false, maxLength: 50),
                        intendedUse = c.String(nullable: false, maxLength: 500),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.ParamType", t => t.ParamTypeID)
                .ForeignKey("AD.ParamVersion", t => t.ParamVersionID)
                .Index(t => new { t.ParamVersionID, t.ParamSequence }, unique: true, name: "NDX_PKey")
                .Index(t => t.ParamTypeID);
            
            CreateTable(
                "_DEV2.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                        ParamDefinition_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinition_ID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinition_ID);
            
            CreateTable(
                "_PROD.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                        ParamDefinition_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinition_ID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinition_ID);
            
            CreateTable(
                "_QA1.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                        ParamDefinition_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinition_ID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinition_ID);
            
            CreateTable(
                "_QA2.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                        ParamDefinition_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinition_ID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinition_ID);
            
            CreateTable(
                "_STG1.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                        ParamDefinition_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinition_ID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinition_ID);
            
            CreateTable(
                "_STG2.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionsID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                        ParamDefinition_ID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinition_ID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinition_ID);
            
            CreateTable(
                "AD.ParamType",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        type = c.String(nullable: false, maxLength: 15),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "AD.ParamVersion",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        version = c.Single(nullable: false),
                        description = c.String(nullable: false, maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.version, unique: true, name: "NDX_PKey");
            
            CreateTable(
                "AD.Executable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ParamVersionID = c.Guid(nullable: false),
                        AppID = c.Guid(nullable: false),
                        nameWExtension = c.String(nullable: false, maxLength: 256),
                        description = c.String(nullable: false, maxLength: 100),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.App", t => t.AppID)
                .ForeignKey("AD.ParamVersion", t => t.ParamVersionID)
                .Index(t => t.ParamVersionID)
                .Index(t => new { t.AppID, t.nameWExtension }, unique: true, name: "NDX_AppID_NameWExtension");
            
            CreateTable(
                "AD.PathServer",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        server = c.String(nullable: false, maxLength: 256),
                        path = c.String(maxLength: 256),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.server, t.path }, unique: true, name: "NDX_PKey");
            
            CreateTable(
                "AD.PathShare",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        share = c.String(nullable: false, maxLength: 256),
                        path = c.String(maxLength: 256),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.share, t.path }, unique: true, name: "NDX_PKey");
            
            CreateTable(
                "AD.PrimaryFunction",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        abbr = c.String(nullable: false, maxLength: 3),
                        description = c.String(nullable: false, maxLength: 50),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "AD.J_Plan_LOB",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        planID = c.Guid(nullable: false),
                        LineOfBusinessID = c.Guid(nullable: false),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.LineOfBusiness", t => t.LineOfBusinessID)
                .ForeignKey("AD.Plan", t => t.planID)
                .Index(t => new { t.planID, t.LineOfBusinessID }, unique: true, name: "NDX_PK");
            
            CreateTable(
                "AD.LineOfBusiness",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        abbr = c.String(nullable: false, maxLength: 10),
                        descr = c.String(nullable: false, maxLength: 50),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "AD.Plan",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        abbr = c.String(nullable: false, maxLength: 4),
                        descr = c.String(nullable: false, maxLength: 50),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "AD.J_PathServer_PathShare",
                c => new
                    {
                        pathServer = c.Guid(nullable: false),
                        pathShare = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.pathServer, t.pathShare })
                .ForeignKey("AD.PathServer", t => t.pathServer)
                .ForeignKey("AD.PathShare", t => t.pathShare)
                .Index(t => t.pathServer)
                .Index(t => t.pathShare);
            
            CreateTable(
                "AD.J_Executable_PathServer",
                c => new
                    {
                        pathServer = c.Guid(nullable: false),
                        executable = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.pathServer, t.executable })
                .ForeignKey("AD.Executable", t => t.pathServer)
                .ForeignKey("AD.PathServer", t => t.executable)
                .Index(t => t.pathServer)
                .Index(t => t.executable);
            
            CreateTable(
                "AD.J_Executable_PrimaryFunction",
                c => new
                    {
                        primaryFunction = c.Guid(nullable: false),
                        executable = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.primaryFunction, t.executable })
                .ForeignKey("AD.Executable", t => t.primaryFunction)
                .ForeignKey("AD.PrimaryFunction", t => t.executable)
                .Index(t => t.primaryFunction)
                .Index(t => t.executable);
            
            CreateTable(
                "AD.J_Config_Executable",
                c => new
                    {
                        executable = c.Guid(nullable: false),
                        config = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.executable, t.config })
                .ForeignKey("AD.Config", t => t.executable)
                .ForeignKey("AD.Executable", t => t.config)
                .Index(t => t.executable)
                .Index(t => t.config);
            
            CreateTable(
                "AD.J_Config_JPlanLOB",
                c => new
                    {
                        jPlanLOB = c.Guid(nullable: false),
                        config = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.jPlanLOB, t.config })
                .ForeignKey("AD.Config", t => t.jPlanLOB)
                .ForeignKey("AD.J_Plan_LOB", t => t.config)
                .Index(t => t.jPlanLOB)
                .Index(t => t.config);
            
            CreateTable(
                "AD.J_Config_Plan",
                c => new
                    {
                        plan = c.Guid(nullable: false),
                        config = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.plan, t.config })
                .ForeignKey("AD.Config", t => t.plan)
                .ForeignKey("AD.Plan", t => t.config)
                .Index(t => t.plan)
                .Index(t => t.config);
            
            CreateTable(
                "AD.J_App_Plan",
                c => new
                    {
                        app = c.Guid(nullable: false),
                        plan = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.app, t.plan })
                .ForeignKey("AD.App", t => t.app)
                .ForeignKey("AD.Plan", t => t.plan)
                .Index(t => t.app)
                .Index(t => t.plan);
            
        }
        
        public override void Down()
        {
            DropForeignKey("AD.J_App_Plan", "plan", "AD.Plan");
            DropForeignKey("AD.J_App_Plan", "app", "AD.App");
            DropForeignKey("AD.J_Config_Plan", "config", "AD.Plan");
            DropForeignKey("AD.J_Config_Plan", "plan", "AD.Config");
            DropForeignKey("AD.Config", "ParamVersionID", "AD.ParamVersion");
            DropForeignKey("AD.J_Config_JPlanLOB", "config", "AD.J_Plan_LOB");
            DropForeignKey("AD.J_Config_JPlanLOB", "jPlanLOB", "AD.Config");
            DropForeignKey("AD.J_Plan_LOB", "planID", "AD.Plan");
            DropForeignKey("AD.J_Plan_LOB", "LineOfBusinessID", "AD.LineOfBusiness");
            DropForeignKey("AD.J_Config_Executable", "config", "AD.Executable");
            DropForeignKey("AD.J_Config_Executable", "executable", "AD.Config");
            DropForeignKey("_DEV1.ConfigParam", "ParamDefinition_ID", "AD.ParamDefinition");
            DropForeignKey("AD.ParamDefinition", "ParamVersionID", "AD.ParamVersion");
            DropForeignKey("AD.J_Executable_PrimaryFunction", "executable", "AD.PrimaryFunction");
            DropForeignKey("AD.J_Executable_PrimaryFunction", "primaryFunction", "AD.Executable");
            DropForeignKey("AD.J_Executable_PathServer", "executable", "AD.PathServer");
            DropForeignKey("AD.J_Executable_PathServer", "pathServer", "AD.Executable");
            DropForeignKey("AD.J_PathServer_PathShare", "pathShare", "AD.PathShare");
            DropForeignKey("AD.J_PathServer_PathShare", "pathServer", "AD.PathServer");
            DropForeignKey("AD.Executable", "ParamVersionID", "AD.ParamVersion");
            DropForeignKey("AD.Executable", "AppID", "AD.App");
            DropForeignKey("AD.ParamDefinition", "ParamTypeID", "AD.ParamType");
            DropForeignKey("_STG2.ConfigParam", "ParamDefinition_ID", "AD.ParamDefinition");
            DropForeignKey("_STG2.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_STG1.ConfigParam", "ParamDefinition_ID", "AD.ParamDefinition");
            DropForeignKey("_STG1.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_QA2.ConfigParam", "ParamDefinition_ID", "AD.ParamDefinition");
            DropForeignKey("_QA2.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_QA1.ConfigParam", "ParamDefinition_ID", "AD.ParamDefinition");
            DropForeignKey("_QA1.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_PROD.ConfigParam", "ParamDefinition_ID", "AD.ParamDefinition");
            DropForeignKey("_PROD.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_DEV2.ConfigParam", "ParamDefinition_ID", "AD.ParamDefinition");
            DropForeignKey("_DEV2.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_DEV1.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("AD.Config", "AppID", "AD.App");
            DropIndex("AD.J_App_Plan", new[] { "plan" });
            DropIndex("AD.J_App_Plan", new[] { "app" });
            DropIndex("AD.J_Config_Plan", new[] { "config" });
            DropIndex("AD.J_Config_Plan", new[] { "plan" });
            DropIndex("AD.J_Config_JPlanLOB", new[] { "config" });
            DropIndex("AD.J_Config_JPlanLOB", new[] { "jPlanLOB" });
            DropIndex("AD.J_Config_Executable", new[] { "config" });
            DropIndex("AD.J_Config_Executable", new[] { "executable" });
            DropIndex("AD.J_Executable_PrimaryFunction", new[] { "executable" });
            DropIndex("AD.J_Executable_PrimaryFunction", new[] { "primaryFunction" });
            DropIndex("AD.J_Executable_PathServer", new[] { "executable" });
            DropIndex("AD.J_Executable_PathServer", new[] { "pathServer" });
            DropIndex("AD.J_PathServer_PathShare", new[] { "pathShare" });
            DropIndex("AD.J_PathServer_PathShare", new[] { "pathServer" });
            DropIndex("AD.J_Plan_LOB", "NDX_PK");
            DropIndex("AD.PathShare", "NDX_PKey");
            DropIndex("AD.PathServer", "NDX_PKey");
            DropIndex("AD.Executable", "NDX_AppID_NameWExtension");
            DropIndex("AD.Executable", new[] { "ParamVersionID" });
            DropIndex("AD.ParamVersion", "NDX_PKey");
            DropIndex("_STG2.ConfigParam", new[] { "ParamDefinition_ID" });
            DropIndex("_STG2.ConfigParam", new[] { "ConfigID" });
            DropIndex("_STG1.ConfigParam", new[] { "ParamDefinition_ID" });
            DropIndex("_STG1.ConfigParam", new[] { "ConfigID" });
            DropIndex("_QA2.ConfigParam", new[] { "ParamDefinition_ID" });
            DropIndex("_QA2.ConfigParam", new[] { "ConfigID" });
            DropIndex("_QA1.ConfigParam", new[] { "ParamDefinition_ID" });
            DropIndex("_QA1.ConfigParam", new[] { "ConfigID" });
            DropIndex("_PROD.ConfigParam", new[] { "ParamDefinition_ID" });
            DropIndex("_PROD.ConfigParam", new[] { "ConfigID" });
            DropIndex("_DEV2.ConfigParam", new[] { "ParamDefinition_ID" });
            DropIndex("_DEV2.ConfigParam", new[] { "ConfigID" });
            DropIndex("AD.ParamDefinition", new[] { "ParamTypeID" });
            DropIndex("AD.ParamDefinition", "NDX_PKey");
            DropIndex("_DEV1.ConfigParam", new[] { "ParamDefinition_ID" });
            DropIndex("_DEV1.ConfigParam", new[] { "ConfigID" });
            DropIndex("AD.Config", new[] { "ParamVersionID" });
            DropIndex("AD.Config", new[] { "AppID" });
            DropTable("AD.J_App_Plan");
            DropTable("AD.J_Config_Plan");
            DropTable("AD.J_Config_JPlanLOB");
            DropTable("AD.J_Config_Executable");
            DropTable("AD.J_Executable_PrimaryFunction");
            DropTable("AD.J_Executable_PathServer");
            DropTable("AD.J_PathServer_PathShare");
            DropTable("AD.Plan");
            DropTable("AD.LineOfBusiness");
            DropTable("AD.J_Plan_LOB");
            DropTable("AD.PrimaryFunction");
            DropTable("AD.PathShare");
            DropTable("AD.PathServer");
            DropTable("AD.Executable");
            DropTable("AD.ParamVersion");
            DropTable("AD.ParamType");
            DropTable("_STG2.ConfigParam");
            DropTable("_STG1.ConfigParam");
            DropTable("_QA2.ConfigParam");
            DropTable("_QA1.ConfigParam");
            DropTable("_PROD.ConfigParam");
            DropTable("_DEV2.ConfigParam");
            DropTable("AD.ParamDefinition");
            DropTable("_DEV1.ConfigParam");
            DropTable("AD.Config");
            DropTable("AD.App");
        }
    }
}
