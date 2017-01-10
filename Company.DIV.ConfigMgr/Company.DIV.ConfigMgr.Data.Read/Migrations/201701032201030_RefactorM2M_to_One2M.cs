namespace Company.DIV.ConfigMgr.Data.Read.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorM2M_to_One2M : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("AD.J_PathServer_PathShare", "pathServer", "AD.PathServer");
            DropForeignKey("AD.J_PathServer_PathShare", "pathShare", "AD.PathShare");
            DropForeignKey("AD.J_Executable_PathServer", "pathServer", "AD.Executable");
            DropForeignKey("AD.J_Executable_PathServer", "executable", "AD.PathServer");
            DropForeignKey("AD.J_Executable_PrimaryFunction", "primaryFunction", "AD.Executable");
            DropForeignKey("AD.J_Executable_PrimaryFunction", "executable", "AD.PrimaryFunction");
            DropForeignKey("AD.J_Config_Executable", "executable", "AD.Config");
            DropForeignKey("AD.J_Config_Executable", "config", "AD.Executable");
            DropForeignKey("AD.J_Config_JPlanLOB", "jPlanLOB", "AD.Config");
            DropForeignKey("AD.J_Config_JPlanLOB", "config", "AD.J_Plan_LOB");
            DropForeignKey("AD.J_Config_Plan", "plan", "AD.Config");
            DropForeignKey("AD.J_Config_Plan", "config", "AD.Plan");
            DropForeignKey("AD.J_App_Plan", "app", "AD.App");
            DropForeignKey("AD.J_App_Plan", "plan", "AD.Plan");
            DropIndex("AD.J_PathServer_PathShare", new[] { "pathServer" });
            DropIndex("AD.J_PathServer_PathShare", new[] { "pathShare" });
            DropIndex("AD.J_Executable_PathServer", new[] { "pathServer" });
            DropIndex("AD.J_Executable_PathServer", new[] { "executable" });
            DropIndex("AD.J_Executable_PrimaryFunction", new[] { "primaryFunction" });
            DropIndex("AD.J_Executable_PrimaryFunction", new[] { "executable" });
            DropIndex("AD.J_Config_Executable", new[] { "executable" });
            DropIndex("AD.J_Config_Executable", new[] { "config" });
            DropIndex("AD.J_Config_JPlanLOB", new[] { "jPlanLOB" });
            DropIndex("AD.J_Config_JPlanLOB", new[] { "config" });
            DropIndex("AD.J_Config_Plan", new[] { "plan" });
            DropIndex("AD.J_Config_Plan", new[] { "config" });
            DropIndex("AD.J_App_Plan", new[] { "app" });
            DropIndex("AD.J_App_Plan", new[] { "plan" });
            RenameIndex(table: "AD.J_Plan_LOB", name: "NDX_PK", newName: "NDX_UniqueKey");

            ///Manual override - migrations put this at the bottom!? after trying to create the same table names
            DropTable("AD.J_PathServer_PathShare");
            DropTable("AD.J_Executable_PathServer");
            DropTable("AD.J_Executable_PrimaryFunction");
            DropTable("AD.J_Config_Executable");
            DropTable("AD.J_Config_JPlanLOB");
            DropTable("AD.J_Config_Plan");
            DropTable("AD.J_App_Plan");

            CreateTable(
                "AD.J_Config_Executable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
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
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Executable", t => t.ExecutableID)
                .ForeignKey("AD.PathServer", t => t.PathServerID)
                .Index(t => new { t.ExecutableID, t.PathServerID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.J_PathServer_PathShare",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        PathServerID = c.Guid(nullable: false),
                        PathShareID = c.Guid(nullable: false),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.PathServer", t => t.PathServerID)
                .ForeignKey("AD.PathShare", t => t.PathShareID)
                .Index(t => new { t.PathServerID, t.PathShareID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.J_Executable_PrimaryFunction",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ExecutableID = c.Guid(nullable: false),
                        PrimaryFunctionID = c.Guid(nullable: false),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Executable", t => t.ExecutableID)
                .ForeignKey("AD.PrimaryFunction", t => t.PrimaryFunctionID)
                .Index(t => new { t.ExecutableID, t.PrimaryFunctionID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.J_Config_JPlanLOB",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        JPlanLOBID = c.Guid(nullable: false),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.J_Plan_LOB", t => t.JPlanLOBID)
                .Index(t => new { t.ConfigID, t.JPlanLOBID }, unique: true, name: "NDX_UniqueKey");
            
            CreateTable(
                "AD.J_App_Plan",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AppID = c.Guid(nullable: false),
                        PlanID = c.Guid(nullable: false),
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
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
                        createDT = c.DateTime(nullable: false),
                        createUser = c.String(nullable: false, maxLength: 20),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("AD.Config", t => t.ConfigID)
                .ForeignKey("AD.Plan", t => t.PlanID)
                .Index(t => new { t.ConfigID, t.PlanID }, unique: true, name: "NDX_UniqueKey");
            

        }
        
        public override void Down()
        {
            CreateTable(
                "AD.J_App_Plan",
                c => new
                    {
                        app = c.Guid(nullable: false),
                        plan = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.app, t.plan });
            
            CreateTable(
                "AD.J_Config_Plan",
                c => new
                    {
                        plan = c.Guid(nullable: false),
                        config = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.plan, t.config });
            
            CreateTable(
                "AD.J_Config_JPlanLOB",
                c => new
                    {
                        jPlanLOB = c.Guid(nullable: false),
                        config = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.jPlanLOB, t.config });
            
            CreateTable(
                "AD.J_Config_Executable",
                c => new
                    {
                        executable = c.Guid(nullable: false),
                        config = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.executable, t.config });
            
            CreateTable(
                "AD.J_Executable_PrimaryFunction",
                c => new
                    {
                        primaryFunction = c.Guid(nullable: false),
                        executable = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.primaryFunction, t.executable });
            
            CreateTable(
                "AD.J_Executable_PathServer",
                c => new
                    {
                        pathServer = c.Guid(nullable: false),
                        executable = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.pathServer, t.executable });
            
            CreateTable(
                "AD.J_PathServer_PathShare",
                c => new
                    {
                        pathServer = c.Guid(nullable: false),
                        pathShare = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.pathServer, t.pathShare });
            
            DropForeignKey("AD.J_Config_JPlanLOB", "JPlanLOBID", "AD.J_Plan_LOB");
            DropForeignKey("AD.J_Config_Plan", "PlanID", "AD.Plan");
            DropForeignKey("AD.J_Config_Plan", "ConfigID", "AD.Config");
            DropForeignKey("AD.J_App_Plan", "PlanID", "AD.Plan");
            DropForeignKey("AD.J_App_Plan", "AppID", "AD.App");
            DropForeignKey("AD.J_Config_JPlanLOB", "ConfigID", "AD.Config");
            DropForeignKey("AD.J_Executable_PrimaryFunction", "PrimaryFunctionID", "AD.PrimaryFunction");
            DropForeignKey("AD.J_Executable_PrimaryFunction", "ExecutableID", "AD.Executable");
            DropForeignKey("AD.J_Executable_PathServer", "PathServerID", "AD.PathServer");
            DropForeignKey("AD.J_PathServer_PathShare", "PathShareID", "AD.PathShare");
            DropForeignKey("AD.J_PathServer_PathShare", "PathServerID", "AD.PathServer");
            DropForeignKey("AD.J_Executable_PathServer", "ExecutableID", "AD.Executable");
            DropForeignKey("AD.J_Config_Executable", "ExecutableID", "AD.Executable");
            DropForeignKey("AD.J_Config_Executable", "ConfigID", "AD.Config");
            DropIndex("AD.J_Config_Plan", "NDX_UniqueKey");
            DropIndex("AD.J_App_Plan", "NDX_UniqueKey");
            DropIndex("AD.J_Config_JPlanLOB", "NDX_UniqueKey");
            DropIndex("AD.J_Executable_PrimaryFunction", "NDX_UniqueKey");
            DropIndex("AD.J_PathServer_PathShare", "NDX_UniqueKey");
            DropIndex("AD.J_Executable_PathServer", "NDX_UniqueKey");
            DropIndex("AD.J_Config_Executable", "NDX_UniqueKey");
            DropTable("AD.J_Config_Plan");
            DropTable("AD.J_App_Plan");
            DropTable("AD.J_Config_JPlanLOB");
            DropTable("AD.J_Executable_PrimaryFunction");
            DropTable("AD.J_PathServer_PathShare");
            DropTable("AD.J_Executable_PathServer");
            DropTable("AD.J_Config_Executable");
            RenameIndex(table: "AD.J_Plan_LOB", name: "NDX_UniqueKey", newName: "NDX_PK");
            CreateIndex("AD.J_App_Plan", "plan");
            CreateIndex("AD.J_App_Plan", "app");
            CreateIndex("AD.J_Config_Plan", "config");
            CreateIndex("AD.J_Config_Plan", "plan");
            CreateIndex("AD.J_Config_JPlanLOB", "config");
            CreateIndex("AD.J_Config_JPlanLOB", "jPlanLOB");
            CreateIndex("AD.J_Config_Executable", "config");
            CreateIndex("AD.J_Config_Executable", "executable");
            CreateIndex("AD.J_Executable_PrimaryFunction", "executable");
            CreateIndex("AD.J_Executable_PrimaryFunction", "primaryFunction");
            CreateIndex("AD.J_Executable_PathServer", "executable");
            CreateIndex("AD.J_Executable_PathServer", "pathServer");
            CreateIndex("AD.J_PathServer_PathShare", "pathShare");
            CreateIndex("AD.J_PathServer_PathShare", "pathServer");
            AddForeignKey("AD.J_App_Plan", "plan", "AD.Plan", "ID");
            AddForeignKey("AD.J_App_Plan", "app", "AD.App", "ID");
            AddForeignKey("AD.J_Config_Plan", "config", "AD.Plan", "ID");
            AddForeignKey("AD.J_Config_Plan", "plan", "AD.Config", "ID");
            AddForeignKey("AD.J_Config_JPlanLOB", "config", "AD.J_Plan_LOB", "ID");
            AddForeignKey("AD.J_Config_JPlanLOB", "jPlanLOB", "AD.Config", "ID");
            AddForeignKey("AD.J_Config_Executable", "config", "AD.Executable", "ID");
            AddForeignKey("AD.J_Config_Executable", "executable", "AD.Config", "ID");
            AddForeignKey("AD.J_Executable_PrimaryFunction", "executable", "AD.PrimaryFunction", "ID");
            AddForeignKey("AD.J_Executable_PrimaryFunction", "primaryFunction", "AD.Executable", "ID");
            AddForeignKey("AD.J_Executable_PathServer", "executable", "AD.PathServer", "ID");
            AddForeignKey("AD.J_Executable_PathServer", "pathServer", "AD.Executable", "ID");
            AddForeignKey("AD.J_PathServer_PathShare", "pathShare", "AD.PathShare", "ID");
            AddForeignKey("AD.J_PathServer_PathShare", "pathServer", "AD.PathServer", "ID");
        }
    }
}
