namespace Company.DIV.ConfigMgr.Data.Read.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// this migration should have been named "Fix_PropName_JPlanLOB_Insert.PlanID"
    /// </summary>
    public partial class RefactorModelToOneWayNavigations : DbMigration
    {
        public override void Up()
        {
            AlterStoredProcedure(
                "AD.JPlanLOB_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        PlanID = p.Guid(),
                        LineOfBusinessID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[J_Plan_LOB]([ID], [PlanID], [LineOfBusinessID], [updateDT], [updateUser])
                      VALUES (@ID, @PlanID, @LineOfBusinessID, @updateDT, @updateUser)"
            );
            
            AlterStoredProcedure(
                "AD.JPlanLOB_Update",
                p => new
                    {
                        ID = p.Guid(),
                        PlanID = p.Guid(),
                        LineOfBusinessID = p.Guid(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[J_Plan_LOB]
                      SET [PlanID] = @PlanID, [LineOfBusinessID] = @LineOfBusinessID, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
        }
        
        public override void Down()
        {
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
