namespace Company.DIV.ConfigMgr.Data.Read.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinitionID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinitionID);
            
            CreateTable(
                "AD.ParamDefinition",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ParamVersionID = c.Guid(nullable: false),
                        ParamSequence = c.Int(nullable: false),
                        ParamTypeID = c.Guid(nullable: false),
                        variableName = c.String(nullable: false, maxLength: 50),
                        intendedUse = c.String(nullable: false, maxLength: 500),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.ParamType", t => t.ParamTypeID)
                .ForeignKey("AD.ParamVersion", t => t.ParamVersionID)
                .Index(t => new { t.ParamVersionID, t.ParamSequence }, unique: true, name: "NDX_UNIQUE_ParamVersionID_ParamSequence")
                .Index(t => t.ParamTypeID);
            
            CreateTable(
                "_DEV2.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinitionID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinitionID);
            
            CreateTable(
                "_PROD.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinitionID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinitionID);
            
            CreateTable(
                "_QA1.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinitionID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinitionID);
            
            CreateTable(
                "_QA2.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinitionID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinitionID);
            
            CreateTable(
                "_STG1.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinitionID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinitionID);
            
            CreateTable(
                "_STG2.ConfigParam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(nullable: false),
                        valueUseageComments = c.String(maxLength: 100),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.ParamDefinition", t => t.ParamDefinitionID)
                .Index(t => t.ConfigID)
                .Index(t => t.ParamDefinitionID);
            
            CreateTable(
                "AD.ParamType",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        type = c.String(nullable: false, maxLength: 15),
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
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.version, unique: true, name: "NDX_UNIQUE_version");
            
            CreateTable(
                "AD.Executable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AppID = c.Guid(nullable: false),
                        nameWExtension = c.String(nullable: false, maxLength: 256),
                        description = c.String(nullable: false, maxLength: 100),
                        ParamVersionID = c.Guid(),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.App", t => t.AppID)
                .ForeignKey("AD.ParamVersion", t => t.ParamVersionID)
                .Index(t => new { t.AppID, t.nameWExtension }, unique: true, name: "NDX_AppID_NameWExtension")
                .Index(t => t.ParamVersionID);
            
            CreateTable(
                "AD.J_Config_Executable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.Executable", t => t.ExecutableID)
                .Index(t => new { t.ConfigID, t.ExecutableID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.J_Executable_PathServer",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        PathServerID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Executable", t => t.ExecutableID)
                .ForeignKey("AD.PathServer", t => t.PathServerID)
                .Index(t => new { t.ExecutableID, t.PathServerID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.PathServer",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        server = c.String(nullable: false, maxLength: 256),
                        path = c.String(maxLength: 256),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.server, t.path }, unique: true, name: "NDX_UNIQUE_server_path");
            
            CreateTable(
                "AD.J_PathServer_PathShare",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        PathServerID = c.Guid(nullable: false),
                        PathShareID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.PathServer", t => t.PathServerID)
                .ForeignKey("AD.PathShare", t => t.PathShareID)
                .Index(t => new { t.PathServerID, t.PathShareID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.PathShare",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        share = c.String(nullable: false, maxLength: 256),
                        path = c.String(maxLength: 256),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.share, t.path }, unique: true, name: "NDX_UNIQUE_share_path");
            
            CreateTable(
                "AD.J_Executable_PrimaryFunction",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        PrimaryFunctionID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Executable", t => t.ExecutableID)
                .ForeignKey("AD.PrimaryFunction", t => t.PrimaryFunctionID)
                .Index(t => new { t.ExecutableID, t.PrimaryFunctionID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.PrimaryFunction",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        abbr = c.String(nullable: false, maxLength: 3),
                        description = c.String(nullable: false, maxLength: 50),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "AD.J_Config_JPlanLOB",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        JPlanLOBID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.J_Plan_LOB", t => t.JPlanLOBID)
                .Index(t => new { t.ConfigID, t.JPlanLOBID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.J_Plan_LOB",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        planID = c.Guid(nullable: false),
                        LineOfBusinessID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.LineOfBusiness", t => t.LineOfBusinessID)
                .ForeignKey("AD.Plan", t => t.planID)
                .Index(t => new { t.planID, t.LineOfBusinessID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.LineOfBusiness",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        abbr = c.String(nullable: false, maxLength: 10),
                        descr = c.String(nullable: false, maxLength: 50),
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
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "AD.J_App_Plan",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AppID = c.Guid(nullable: false),
                        PlanID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.App", t => t.AppID)
                .ForeignKey("AD.Plan", t => t.PlanID)
                .Index(t => new { t.AppID, t.PlanID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.J_Config_Plan",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        PlanID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.Plan", t => t.PlanID)
                .Index(t => new { t.ConfigID, t.PlanID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.AppAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ITIL = c.Int(nullable: false),
                        abbr = c.String(maxLength: 3),
                        description = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        jobID = c.Int(nullable: false),
                        AppID = c.Guid(nullable: false),
                        ParamVersionID = c.Guid(nullable: false),
                        Active = c.Boolean(nullable: false),
                        DescriptonShort = c.String(maxLength: 25),
                        DescriptonFull = c.String(maxLength: 100),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamDEV1Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamDEV2Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamPRODAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamQA1Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamQA2Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamSTG1Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ConfigParamSTG2Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        effDT = c.DateTime(nullable: false),
                        trmDT = c.DateTime(nullable: false),
                        ParamDefinitionID = c.Guid(nullable: false),
                        isRefOnly = c.Boolean(nullable: false),
                        value = c.String(),
                        valueUseageComments = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ExecutableAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AppID = c.Guid(nullable: false),
                        nameWExtension = c.String(maxLength: 256),
                        description = c.String(maxLength: 100),
                        ParamVersionID = c.Guid(),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.PrimaryFunctionAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        abbr = c.String(maxLength: 3),
                        description = c.String(maxLength: 50),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.J_App_Plan_Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        AppID = c.Guid(nullable: false),
                        PlanID = c.Guid(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.J_Config_Executable_Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.J_Config_JPlanLOB_Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        JPlanLOBID = c.Guid(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.J_Config_Plan_Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ConfigID = c.Guid(nullable: false),
                        PlanID = c.Guid(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.J_Executable_PathServer_Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ExecutableID = c.Guid(nullable: false),
                        PathServerID = c.Guid(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.J_Executable_PrimaryFunction_Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ExecutableID = c.Guid(nullable: false),
                        PrimaryFunctionID = c.Guid(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.J_PathServer_PathShare_Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        PathServerID = c.Guid(nullable: false),
                        PathShareID = c.Guid(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.J_Plan_LOB_Audit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        planID = c.Guid(nullable: false),
                        LineOfBusinessID = c.Guid(nullable: false),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.LineOfBusinessAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        abbr = c.String(maxLength: 10),
                        descr = c.String(maxLength: 50),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ParamDefinitionAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        ParamVersionID = c.Guid(nullable: false),
                        ParamSequence = c.Int(nullable: false),
                        ParamTypeID = c.Guid(nullable: false),
                        variableName = c.String(maxLength: 50),
                        intendedUse = c.String(maxLength: 500),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ParamTypeAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        type = c.String(maxLength: 15),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.ParamVersionAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        version = c.Single(nullable: false),
                        description = c.String(maxLength: 100),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.PathServerAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        server = c.String(maxLength: 256),
                        path = c.String(maxLength: 256),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.PathShareAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        share = c.String(maxLength: 256),
                        path = c.String(maxLength: 256),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateTable(
                "AD.PlanAudit",
                c => new
                    {
                        AuditID = c.Int(nullable: false, identity: true),
                        abbr = c.String(maxLength: 4),
                        descr = c.String(maxLength: 50),
                        AuditDT = c.DateTime(nullable: false),
                        AuditType = c.Byte(nullable: false),
                        AuditSUserSName = c.String(nullable: false, maxLength: 20),
                        ID = c.Guid(),
                        updateDT = c.DateTime(),
                        updateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AuditID);
            
            CreateStoredProcedure(
                "AD.App_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ITIL = p.Int(),
                        abbr = p.String(maxLength: 3),
                        description = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[App]([ID], [ITIL], [abbr], [description], [updateDT], [updateUser])
                      VALUES (@ID, @ITIL, @abbr, @description, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.App_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ITIL = p.Int(),
                        abbr = p.String(maxLength: 3),
                        description = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[App]
                      SET [ITIL] = @ITIL, [abbr] = @abbr, [description] = @description, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.App_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[App]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.Config_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        AppID = p.Guid(),
                        ParamVersionID = p.Guid(),
                        Active = p.Boolean(),
                        DescriptonShort = p.String(maxLength: 25),
                        DescriptonFull = p.String(maxLength: 100),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[Config]([ID], [AppID], [ParamVersionID], [Active], [DescriptonShort], [DescriptonFull], [effDT], [trmDT], [updateDT], [updateUser])
                      VALUES (@ID, @AppID, @ParamVersionID, @Active, @DescriptonShort, @DescriptonFull, @effDT, @trmDT, @updateDT, @updateUser)
                      
                      SELECT t0.[jobID]
                      FROM [AD].[Config] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ID] = @ID"
            );
            
            CreateStoredProcedure(
                "AD.Config_Update",
                p => new
                    {
                        ID = p.Guid(),
                        jobID = p.Int(),
                        AppID = p.Guid(),
                        ParamVersionID = p.Guid(),
                        Active = p.Boolean(),
                        DescriptonShort = p.String(maxLength: 25),
                        DescriptonFull = p.String(maxLength: 100),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[Config]
                      SET [AppID] = @AppID, [ParamVersionID] = @ParamVersionID, [Active] = @Active, [DescriptonShort] = @DescriptonShort, [DescriptonFull] = @DescriptonFull, [effDT] = @effDT, [trmDT] = @trmDT, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.Config_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[Config]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV1_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [_DEV1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV1_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [_DEV1].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV1_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [_DEV1].[ConfigParam]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ParamDefinition_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ParamVersionID = p.Guid(),
                        ParamSequence = p.Int(),
                        ParamTypeID = p.Guid(),
                        variableName = p.String(maxLength: 50),
                        intendedUse = p.String(maxLength: 500),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[ParamDefinition]([ID], [ParamVersionID], [ParamSequence], [ParamTypeID], [variableName], [intendedUse], [updateDT], [updateUser])
                      VALUES (@ID, @ParamVersionID, @ParamSequence, @ParamTypeID, @variableName, @intendedUse, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ParamDefinition_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ParamVersionID = p.Guid(),
                        ParamSequence = p.Int(),
                        ParamTypeID = p.Guid(),
                        variableName = p.String(maxLength: 50),
                        intendedUse = p.String(maxLength: 500),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[ParamDefinition]
                      SET [ParamVersionID] = @ParamVersionID, [ParamSequence] = @ParamSequence, [ParamTypeID] = @ParamTypeID, [variableName] = @variableName, [intendedUse] = @intendedUse, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ParamDefinition_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[ParamDefinition]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV2_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [_DEV2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV2_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [_DEV2].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV2_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [_DEV2].[ConfigParam]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamPROD_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [_PROD].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamPROD_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [_PROD].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamPROD_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [_PROD].[ConfigParam]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA1_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [_QA1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA1_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [_QA1].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA1_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [_QA1].[ConfigParam]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA2_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [_QA2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA2_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [_QA2].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA2_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [_QA2].[ConfigParam]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG1_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [_STG1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG1_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [_STG1].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG1_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [_STG1].[ConfigParam]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG2_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [_STG2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG2_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [_STG2].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG2_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [_STG2].[ConfigParam]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ParamType_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        type = p.String(maxLength: 15),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[ParamType]([ID], [type], [updateDT], [updateUser])
                      VALUES (@ID, @type, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ParamType_Update",
                p => new
                    {
                        ID = p.Guid(),
                        type = p.String(maxLength: 15),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[ParamType]
                      SET [type] = @type, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ParamType_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[ParamType]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ParamVersion_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        version = p.Single(),
                        description = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[ParamVersion]([ID], [version], [description], [updateDT], [updateUser])
                      VALUES (@ID, @version, @description, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.ParamVersion_Update",
                p => new
                    {
                        ID = p.Guid(),
                        version = p.Single(),
                        description = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[ParamVersion]
                      SET [version] = @version, [description] = @description, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.ParamVersion_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[ParamVersion]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.Executable_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        AppID = p.Guid(),
                        nameWExtension = p.String(maxLength: 256),
                        description = p.String(maxLength: 100),
                        ParamVersionID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[Executable]([ID], [AppID], [nameWExtension], [description], [ParamVersionID], [updateDT], [updateUser])
                      VALUES (@ID, @AppID, @nameWExtension, @description, @ParamVersionID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.Executable_Update",
                p => new
                    {
                        ID = p.Guid(),
                        AppID = p.Guid(),
                        nameWExtension = p.String(maxLength: 256),
                        description = p.String(maxLength: 100),
                        ParamVersionID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[Executable]
                      SET [AppID] = @AppID, [nameWExtension] = @nameWExtension, [description] = @description, [ParamVersionID] = @ParamVersionID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.Executable_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[Executable]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigExecutable_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        ExecutableID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_Config_Executable]([ID], [ConfigID], [ExecutableID], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @ExecutableID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigExecutable_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        ExecutableID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_Config_Executable]
                      SET [ConfigID] = @ConfigID, [ExecutableID] = @ExecutableID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigExecutable_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[J_Config_Executable]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JExecutablePathServer_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ExecutableID = p.Guid(),
                        PathServerID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_Executable_PathServer]([ID], [ExecutableID], [PathServerID], [updateDT], [updateUser])
                      VALUES (@ID, @ExecutableID, @PathServerID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.JExecutablePathServer_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ExecutableID = p.Guid(),
                        PathServerID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_Executable_PathServer]
                      SET [ExecutableID] = @ExecutableID, [PathServerID] = @PathServerID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JExecutablePathServer_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[J_Executable_PathServer]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.PathServer_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        server = p.String(maxLength: 256),
                        path = p.String(maxLength: 256),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[PathServer]([ID], [server], [path], [updateDT], [updateUser])
                      VALUES (@ID, @server, @path, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.PathServer_Update",
                p => new
                    {
                        ID = p.Guid(),
                        server = p.String(maxLength: 256),
                        path = p.String(maxLength: 256),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[PathServer]
                      SET [server] = @server, [path] = @path, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.PathServer_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[PathServer]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JPathServerPathShare_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        PathServerID = p.Guid(),
                        PathShareID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_PathServer_PathShare]([ID], [PathServerID], [PathShareID], [updateDT], [updateUser])
                      VALUES (@ID, @PathServerID, @PathShareID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.JPathServerPathShare_Update",
                p => new
                    {
                        ID = p.Guid(),
                        PathServerID = p.Guid(),
                        PathShareID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_PathServer_PathShare]
                      SET [PathServerID] = @PathServerID, [PathShareID] = @PathShareID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JPathServerPathShare_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[J_PathServer_PathShare]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.PathShare_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        share = p.String(maxLength: 256),
                        path = p.String(maxLength: 256),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[PathShare]([ID], [share], [path], [updateDT], [updateUser])
                      VALUES (@ID, @share, @path, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.PathShare_Update",
                p => new
                    {
                        ID = p.Guid(),
                        share = p.String(maxLength: 256),
                        path = p.String(maxLength: 256),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[PathShare]
                      SET [share] = @share, [path] = @path, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.PathShare_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[PathShare]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JExecutablePrimaryFunction_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ExecutableID = p.Guid(),
                        PrimaryFunctionID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_Executable_PrimaryFunction]([ID], [ExecutableID], [PrimaryFunctionID], [updateDT], [updateUser])
                      VALUES (@ID, @ExecutableID, @PrimaryFunctionID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.JExecutablePrimaryFunction_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ExecutableID = p.Guid(),
                        PrimaryFunctionID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_Executable_PrimaryFunction]
                      SET [ExecutableID] = @ExecutableID, [PrimaryFunctionID] = @PrimaryFunctionID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JExecutablePrimaryFunction_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[J_Executable_PrimaryFunction]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.PrimaryFunction_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        abbr = p.String(maxLength: 3),
                        description = p.String(maxLength: 50),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[PrimaryFunction]([ID], [abbr], [description], [updateDT], [updateUser])
                      VALUES (@ID, @abbr, @description, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.PrimaryFunction_Update",
                p => new
                    {
                        ID = p.Guid(),
                        abbr = p.String(maxLength: 3),
                        description = p.String(maxLength: 50),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[PrimaryFunction]
                      SET [abbr] = @abbr, [description] = @description, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.PrimaryFunction_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[PrimaryFunction]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigJPlanLOB_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        JPlanLOBID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_Config_JPlanLOB]([ID], [ConfigID], [JPlanLOBID], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @JPlanLOBID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigJPlanLOB_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        JPlanLOBID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_Config_JPlanLOB]
                      SET [ConfigID] = @ConfigID, [JPlanLOBID] = @JPlanLOBID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigJPlanLOB_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[J_Config_JPlanLOB]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JPlanLOB_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        planID = p.Guid(),
                        LineOfBusinessID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_Plan_LOB]([ID], [planID], [LineOfBusinessID], [updateDT], [updateUser])
                      VALUES (@ID, @planID, @LineOfBusinessID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.JPlanLOB_Update",
                p => new
                    {
                        ID = p.Guid(),
                        planID = p.Guid(),
                        LineOfBusinessID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_Plan_LOB]
                      SET [planID] = @planID, [LineOfBusinessID] = @LineOfBusinessID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JPlanLOB_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[J_Plan_LOB]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.LineOfBusiness_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        abbr = p.String(maxLength: 10),
                        descr = p.String(maxLength: 50),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[LineOfBusiness]([ID], [abbr], [descr], [updateDT], [updateUser])
                      VALUES (@ID, @abbr, @descr, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.LineOfBusiness_Update",
                p => new
                    {
                        ID = p.Guid(),
                        abbr = p.String(maxLength: 10),
                        descr = p.String(maxLength: 50),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[LineOfBusiness]
                      SET [abbr] = @abbr, [descr] = @descr, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.LineOfBusiness_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[LineOfBusiness]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.Plan_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        abbr = p.String(maxLength: 4),
                        descr = p.String(maxLength: 50),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[Plan]([ID], [abbr], [descr], [updateDT], [updateUser])
                      VALUES (@ID, @abbr, @descr, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.Plan_Update",
                p => new
                    {
                        ID = p.Guid(),
                        abbr = p.String(maxLength: 4),
                        descr = p.String(maxLength: 50),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[Plan]
                      SET [abbr] = @abbr, [descr] = @descr, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.Plan_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[Plan]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JAppPlan_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        AppID = p.Guid(),
                        PlanID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_App_Plan]([ID], [AppID], [PlanID], [updateDT], [updateUser])
                      VALUES (@ID, @AppID, @PlanID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.JAppPlan_Update",
                p => new
                    {
                        ID = p.Guid(),
                        AppID = p.Guid(),
                        PlanID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_App_Plan]
                      SET [AppID] = @AppID, [PlanID] = @PlanID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JAppPlan_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[J_App_Plan]
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigPlan_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        PlanID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_Config_Plan]([ID], [ConfigID], [PlanID], [updateDT], [updateUser])
                      VALUES (@ID, @ConfigID, @PlanID, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigPlan_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        PlanID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_Config_Plan]
                      SET [ConfigID] = @ConfigID, [PlanID] = @PlanID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
            CreateStoredProcedure(
                "AD.JConfigPlan_Delete",
                p => new
                    {
                        ID = p.Guid(),
                    },
                body:
                    @"DELETE [AD].[J_Config_Plan]
                      WHERE ([ID] = @ID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("AD.JConfigPlan_Delete");
            DropStoredProcedure("AD.JConfigPlan_Update");
            DropStoredProcedure("AD.JConfigPlan_Insert");
            DropStoredProcedure("AD.JAppPlan_Delete");
            DropStoredProcedure("AD.JAppPlan_Update");
            DropStoredProcedure("AD.JAppPlan_Insert");
            DropStoredProcedure("AD.Plan_Delete");
            DropStoredProcedure("AD.Plan_Update");
            DropStoredProcedure("AD.Plan_Insert");
            DropStoredProcedure("AD.LineOfBusiness_Delete");
            DropStoredProcedure("AD.LineOfBusiness_Update");
            DropStoredProcedure("AD.LineOfBusiness_Insert");
            DropStoredProcedure("AD.JPlanLOB_Delete");
            DropStoredProcedure("AD.JPlanLOB_Update");
            DropStoredProcedure("AD.JPlanLOB_Insert");
            DropStoredProcedure("AD.JConfigJPlanLOB_Delete");
            DropStoredProcedure("AD.JConfigJPlanLOB_Update");
            DropStoredProcedure("AD.JConfigJPlanLOB_Insert");
            DropStoredProcedure("AD.PrimaryFunction_Delete");
            DropStoredProcedure("AD.PrimaryFunction_Update");
            DropStoredProcedure("AD.PrimaryFunction_Insert");
            DropStoredProcedure("AD.JExecutablePrimaryFunction_Delete");
            DropStoredProcedure("AD.JExecutablePrimaryFunction_Update");
            DropStoredProcedure("AD.JExecutablePrimaryFunction_Insert");
            DropStoredProcedure("AD.PathShare_Delete");
            DropStoredProcedure("AD.PathShare_Update");
            DropStoredProcedure("AD.PathShare_Insert");
            DropStoredProcedure("AD.JPathServerPathShare_Delete");
            DropStoredProcedure("AD.JPathServerPathShare_Update");
            DropStoredProcedure("AD.JPathServerPathShare_Insert");
            DropStoredProcedure("AD.PathServer_Delete");
            DropStoredProcedure("AD.PathServer_Update");
            DropStoredProcedure("AD.PathServer_Insert");
            DropStoredProcedure("AD.JExecutablePathServer_Delete");
            DropStoredProcedure("AD.JExecutablePathServer_Update");
            DropStoredProcedure("AD.JExecutablePathServer_Insert");
            DropStoredProcedure("AD.JConfigExecutable_Delete");
            DropStoredProcedure("AD.JConfigExecutable_Update");
            DropStoredProcedure("AD.JConfigExecutable_Insert");
            DropStoredProcedure("AD.Executable_Delete");
            DropStoredProcedure("AD.Executable_Update");
            DropStoredProcedure("AD.Executable_Insert");
            DropStoredProcedure("AD.ParamVersion_Delete");
            DropStoredProcedure("AD.ParamVersion_Update");
            DropStoredProcedure("AD.ParamVersion_Insert");
            DropStoredProcedure("AD.ParamType_Delete");
            DropStoredProcedure("AD.ParamType_Update");
            DropStoredProcedure("AD.ParamType_Insert");
            DropStoredProcedure("AD.ConfigParamSTG2_Delete");
            DropStoredProcedure("AD.ConfigParamSTG2_Update");
            DropStoredProcedure("AD.ConfigParamSTG2_Insert");
            DropStoredProcedure("AD.ConfigParamSTG1_Delete");
            DropStoredProcedure("AD.ConfigParamSTG1_Update");
            DropStoredProcedure("AD.ConfigParamSTG1_Insert");
            DropStoredProcedure("AD.ConfigParamQA2_Delete");
            DropStoredProcedure("AD.ConfigParamQA2_Update");
            DropStoredProcedure("AD.ConfigParamQA2_Insert");
            DropStoredProcedure("AD.ConfigParamQA1_Delete");
            DropStoredProcedure("AD.ConfigParamQA1_Update");
            DropStoredProcedure("AD.ConfigParamQA1_Insert");
            DropStoredProcedure("AD.ConfigParamPROD_Delete");
            DropStoredProcedure("AD.ConfigParamPROD_Update");
            DropStoredProcedure("AD.ConfigParamPROD_Insert");
            DropStoredProcedure("AD.ConfigParamDEV2_Delete");
            DropStoredProcedure("AD.ConfigParamDEV2_Update");
            DropStoredProcedure("AD.ConfigParamDEV2_Insert");
            DropStoredProcedure("AD.ParamDefinition_Delete");
            DropStoredProcedure("AD.ParamDefinition_Update");
            DropStoredProcedure("AD.ParamDefinition_Insert");
            DropStoredProcedure("AD.ConfigParamDEV1_Delete");
            DropStoredProcedure("AD.ConfigParamDEV1_Update");
            DropStoredProcedure("AD.ConfigParamDEV1_Insert");
            DropStoredProcedure("AD.Config_Delete");
            DropStoredProcedure("AD.Config_Update");
            DropStoredProcedure("AD.Config_Insert");
            DropStoredProcedure("AD.App_Delete");
            DropStoredProcedure("AD.App_Update");
            DropStoredProcedure("AD.App_Insert");
            DropForeignKey("AD.Config", "ParamVersionID", "AD.ParamVersion");
            DropForeignKey("AD.J_Config_JPlanLOB", "JPlanLOBID", "AD.J_Plan_LOB");
            DropForeignKey("AD.J_Plan_LOB", "planID", "AD.Plan");
            DropForeignKey("AD.J_Config_Plan", "PlanID", "AD.Plan");
            DropForeignKey("AD.J_Config_Plan", "ConfigID", "AD.Config");
            DropForeignKey("AD.J_App_Plan", "PlanID", "AD.Plan");
            DropForeignKey("AD.J_App_Plan", "AppID", "AD.App");
            DropForeignKey("AD.J_Plan_LOB", "LineOfBusinessID", "AD.LineOfBusiness");
            DropForeignKey("AD.J_Config_JPlanLOB", "ConfigID", "AD.Config");
            DropForeignKey("_DEV1.ConfigParam", "ParamDefinitionID", "AD.ParamDefinition");
            DropForeignKey("AD.ParamDefinition", "ParamVersionID", "AD.ParamVersion");
            DropForeignKey("AD.Executable", "ParamVersionID", "AD.ParamVersion");
            DropForeignKey("AD.J_Executable_PrimaryFunction", "PrimaryFunctionID", "AD.PrimaryFunction");
            DropForeignKey("AD.J_Executable_PrimaryFunction", "ExecutableID", "AD.Executable");
            DropForeignKey("AD.J_Executable_PathServer", "PathServerID", "AD.PathServer");
            DropForeignKey("AD.J_PathServer_PathShare", "PathShareID", "AD.PathShare");
            DropForeignKey("AD.J_PathServer_PathShare", "PathServerID", "AD.PathServer");
            DropForeignKey("AD.J_Executable_PathServer", "ExecutableID", "AD.Executable");
            DropForeignKey("AD.J_Config_Executable", "ExecutableID", "AD.Executable");
            DropForeignKey("AD.J_Config_Executable", "ConfigID", "AD.Config");
            DropForeignKey("AD.Executable", "AppID", "AD.App");
            DropForeignKey("AD.ParamDefinition", "ParamTypeID", "AD.ParamType");
            DropForeignKey("_STG2.ConfigParam", "ParamDefinitionID", "AD.ParamDefinition");
            DropForeignKey("_STG2.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_STG1.ConfigParam", "ParamDefinitionID", "AD.ParamDefinition");
            DropForeignKey("_STG1.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_QA2.ConfigParam", "ParamDefinitionID", "AD.ParamDefinition");
            DropForeignKey("_QA2.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_QA1.ConfigParam", "ParamDefinitionID", "AD.ParamDefinition");
            DropForeignKey("_QA1.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_PROD.ConfigParam", "ParamDefinitionID", "AD.ParamDefinition");
            DropForeignKey("_PROD.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_DEV2.ConfigParam", "ParamDefinitionID", "AD.ParamDefinition");
            DropForeignKey("_DEV2.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("_DEV1.ConfigParam", "ConfigID", "AD.Config");
            DropForeignKey("AD.Config", "AppID", "AD.App");
            DropIndex("AD.J_Config_Plan", "NDX_UniqueKey");
            DropIndex("AD.J_App_Plan", "NDX_UniqueKey");
            DropIndex("AD.J_Plan_LOB", "NDX_UniqueKey");
            DropIndex("AD.J_Config_JPlanLOB", "NDX_UniqueKey");
            DropIndex("AD.J_Executable_PrimaryFunction", "NDX_UniqueKey");
            DropIndex("AD.PathShare", "NDX_UNIQUE_share_path");
            DropIndex("AD.J_PathServer_PathShare", "NDX_UniqueKey");
            DropIndex("AD.PathServer", "NDX_UNIQUE_server_path");
            DropIndex("AD.J_Executable_PathServer", "NDX_UniqueKey");
            DropIndex("AD.J_Config_Executable", "NDX_UniqueKey");
            DropIndex("AD.Executable", new[] { "ParamVersionID" });
            DropIndex("AD.Executable", "NDX_AppID_NameWExtension");
            DropIndex("AD.ParamVersion", "NDX_UNIQUE_version");
            DropIndex("_STG2.ConfigParam", new[] { "ParamDefinitionID" });
            DropIndex("_STG2.ConfigParam", new[] { "ConfigID" });
            DropIndex("_STG1.ConfigParam", new[] { "ParamDefinitionID" });
            DropIndex("_STG1.ConfigParam", new[] { "ConfigID" });
            DropIndex("_QA2.ConfigParam", new[] { "ParamDefinitionID" });
            DropIndex("_QA2.ConfigParam", new[] { "ConfigID" });
            DropIndex("_QA1.ConfigParam", new[] { "ParamDefinitionID" });
            DropIndex("_QA1.ConfigParam", new[] { "ConfigID" });
            DropIndex("_PROD.ConfigParam", new[] { "ParamDefinitionID" });
            DropIndex("_PROD.ConfigParam", new[] { "ConfigID" });
            DropIndex("_DEV2.ConfigParam", new[] { "ParamDefinitionID" });
            DropIndex("_DEV2.ConfigParam", new[] { "ConfigID" });
            DropIndex("AD.ParamDefinition", new[] { "ParamTypeID" });
            DropIndex("AD.ParamDefinition", "NDX_UNIQUE_ParamVersionID_ParamSequence");
            DropIndex("_DEV1.ConfigParam", new[] { "ParamDefinitionID" });
            DropIndex("_DEV1.ConfigParam", new[] { "ConfigID" });
            DropIndex("AD.Config", new[] { "ParamVersionID" });
            DropIndex("AD.Config", new[] { "AppID" });
            DropTable("AD.PlanAudit");
            DropTable("AD.PathShareAudit");
            DropTable("AD.PathServerAudit");
            DropTable("AD.ParamVersionAudit");
            DropTable("AD.ParamTypeAudit");
            DropTable("AD.ParamDefinitionAudit");
            DropTable("AD.LineOfBusinessAudit");
            DropTable("AD.J_Plan_LOB_Audit");
            DropTable("AD.J_PathServer_PathShare_Audit");
            DropTable("AD.J_Executable_PrimaryFunction_Audit");
            DropTable("AD.J_Executable_PathServer_Audit");
            DropTable("AD.J_Config_Plan_Audit");
            DropTable("AD.J_Config_JPlanLOB_Audit");
            DropTable("AD.J_Config_Executable_Audit");
            DropTable("AD.J_App_Plan_Audit");
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
            DropTable("AD.J_Config_Plan");
            DropTable("AD.J_App_Plan");
            DropTable("AD.Plan");
            DropTable("AD.LineOfBusiness");
            DropTable("AD.J_Plan_LOB");
            DropTable("AD.J_Config_JPlanLOB");
            DropTable("AD.PrimaryFunction");
            DropTable("AD.J_Executable_PrimaryFunction");
            DropTable("AD.PathShare");
            DropTable("AD.J_PathServer_PathShare");
            DropTable("AD.PathServer");
            DropTable("AD.J_Executable_PathServer");
            DropTable("AD.J_Config_Executable");
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
