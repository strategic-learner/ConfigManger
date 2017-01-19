namespace Company.DIV.ConfigMgr.Data.Read.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixPropName_Descripton : DbMigration
    {
        public override void Up()
        {
            AddColumn("AD.Config", "DescriptionShort", c => c.String(nullable: false, maxLength: 25));
            AddColumn("AD.Config", "DescriptionFull", c => c.String(nullable: false, maxLength: 100));
            AddColumn("AD.ConfigAudit", "DescriptionShort", c => c.String(maxLength: 25));
            AddColumn("AD.ConfigAudit", "DescriptionFull", c => c.String(maxLength: 100));
            DropColumn("AD.Config", "DescriptonShort");
            DropColumn("AD.Config", "DescriptonFull");
            DropColumn("AD.ConfigAudit", "DescriptonShort");
            DropColumn("AD.ConfigAudit", "DescriptonFull");
            AlterStoredProcedure(
                "AD.Config_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        AppID = p.Guid(),
                        ParamVersionID = p.Guid(),
                        Active = p.Boolean(),
                        DescriptionShort = p.String(maxLength: 25),
                        DescriptionFull = p.String(maxLength: 100),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[Config]([ID], [AppID], [ParamVersionID], [Active], [DescriptionShort], [DescriptionFull], [effDT], [trmDT], [updateDT], [updateUser])
                      VALUES (@ID, @AppID, @ParamVersionID, @Active, @DescriptionShort, @DescriptionFull, @effDT, @trmDT, @updateDT, @updateUser)
                      
                      SELECT t0.[jobID]
                      FROM [AD].[Config] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ID] = @ID"
            );
            
            AlterStoredProcedure(
                "AD.Config_Update",
                p => new
                    {
                        ID = p.Guid(),
                        jobID = p.Int(),
                        AppID = p.Guid(),
                        ParamVersionID = p.Guid(),
                        Active = p.Boolean(),
                        DescriptionShort = p.String(maxLength: 25),
                        DescriptionFull = p.String(maxLength: 100),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[Config]
                      SET [AppID] = @AppID, [ParamVersionID] = @ParamVersionID, [Active] = @Active, [DescriptionShort] = @DescriptionShort, [DescriptionFull] = @DescriptionFull, [effDT] = @effDT, [trmDT] = @trmDT, [updateDT] = @updateDT, [updateUser] = @updateUser
                      WHERE ([ID] = @ID)"
            );
            
        }
        
        public override void Down()
        {
            AddColumn("AD.ConfigAudit", "DescriptonFull", c => c.String(maxLength: 100));
            AddColumn("AD.ConfigAudit", "DescriptonShort", c => c.String(maxLength: 25));
            AddColumn("AD.Config", "DescriptonFull", c => c.String(nullable: false, maxLength: 100));
            AddColumn("AD.Config", "DescriptonShort", c => c.String(nullable: false, maxLength: 25));
            DropColumn("AD.ConfigAudit", "DescriptionFull");
            DropColumn("AD.ConfigAudit", "DescriptionShort");
            DropColumn("AD.Config", "DescriptionFull");
            DropColumn("AD.Config", "DescriptionShort");
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
