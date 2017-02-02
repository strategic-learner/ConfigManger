namespace Company.DIV.ConfigMgr.Data.Read.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNavProp_Config_JConfigPlans : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("AD.J_Config_Plan", "ConfigID", "AD.Config");
            DropForeignKey("AD.J_Config_Plan", "PlanID", "AD.Plan");
            DropIndex("AD.J_Config_Plan", "NDX_UniqueKey");
            DropTable("AD.J_Config_Plan");
            DropTable("AD.J_Config_Plan_Audit");
            DropStoredProcedure("AD.JConfigPlan_Insert");
            DropStoredProcedure("AD.JConfigPlan_Update");
            DropStoredProcedure("AD.JConfigPlan_Delete");
        }
        
        public override void Down()
        {
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
                "AD.J_Config_Plan",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ConfigID = c.Guid(nullable: false),
                        PlanID = c.Guid(nullable: false),
                        updateDT = c.DateTime(nullable: false),
                        updateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("AD.J_Config_Plan", new[] { "ConfigID", "PlanID" }, unique: true, name: "NDX_UniqueKey");
            AddForeignKey("AD.J_Config_Plan", "PlanID", "AD.Plan", "ID");
            AddForeignKey("AD.J_Config_Plan", "ConfigID", "AD.Config", "ID");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
