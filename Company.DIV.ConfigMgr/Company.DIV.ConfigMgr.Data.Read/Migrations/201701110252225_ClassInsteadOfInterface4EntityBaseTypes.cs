namespace Company.DIV.ConfigMgr.Data.Read.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassInsteadOfInterface4EntityBaseTypes : DbMigration
    {
        public override void Up()
        {
            DropIndex("AD.ParamDefinition", "NDX_PKey");
            AddColumn("AD.AppAudit", "ID", c => c.Guid());
            AddColumn("AD.AppAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.AppAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigAudit", "ID", c => c.Guid());
            AddColumn("AD.ConfigAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.ConfigAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamDEV1Audit", "ID", c => c.Guid());
            AddColumn("AD.ConfigParamDEV1Audit", "updateDT", c => c.DateTime());
            AddColumn("AD.ConfigParamDEV1Audit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamDEV2Audit", "ID", c => c.Guid());
            AddColumn("AD.ConfigParamDEV2Audit", "updateDT", c => c.DateTime());
            AddColumn("AD.ConfigParamDEV2Audit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamPRODAudit", "ID", c => c.Guid());
            AddColumn("AD.ConfigParamPRODAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.ConfigParamPRODAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamQA1Audit", "ID", c => c.Guid());
            AddColumn("AD.ConfigParamQA1Audit", "updateDT", c => c.DateTime());
            AddColumn("AD.ConfigParamQA1Audit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamQA2Audit", "ID", c => c.Guid());
            AddColumn("AD.ConfigParamQA2Audit", "updateDT", c => c.DateTime());
            AddColumn("AD.ConfigParamQA2Audit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamSTG1Audit", "ID", c => c.Guid());
            AddColumn("AD.ConfigParamSTG1Audit", "updateDT", c => c.DateTime());
            AddColumn("AD.ConfigParamSTG1Audit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamSTG2Audit", "ID", c => c.Guid());
            AddColumn("AD.ConfigParamSTG2Audit", "updateDT", c => c.DateTime());
            AddColumn("AD.ConfigParamSTG2Audit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ExecutableAudit", "ID", c => c.Guid());
            AddColumn("AD.ExecutableAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.ExecutableAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.PrimaryFunctionAudit", "ID", c => c.Guid());
            AddColumn("AD.PrimaryFunctionAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.PrimaryFunctionAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.JAppPlanAudit", "ID", c => c.Guid());
            AddColumn("AD.JAppPlanAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.JAppPlanAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.JConfigExecutableAudit", "ID", c => c.Guid());
            AddColumn("AD.JConfigExecutableAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.JConfigExecutableAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.JConfigJPlanLOBAudit", "ID", c => c.Guid());
            AddColumn("AD.JConfigJPlanLOBAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.JConfigJPlanLOBAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.JConfigPlanAudit", "ID", c => c.Guid());
            AddColumn("AD.JConfigPlanAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.JConfigPlanAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.JExecutablePathServerAudit", "ID", c => c.Guid());
            AddColumn("AD.JExecutablePathServerAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.JExecutablePathServerAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.JExecutablePrimaryFunctionAudit", "ID", c => c.Guid());
            AddColumn("AD.JExecutablePrimaryFunctionAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.JExecutablePrimaryFunctionAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.JPathServerPathShareAudit", "ID", c => c.Guid());
            AddColumn("AD.JPathServerPathShareAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.JPathServerPathShareAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.JPlanLOBAudit", "ID", c => c.Guid());
            AddColumn("AD.JPlanLOBAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.JPlanLOBAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.LineOfBusinessAudit", "ID", c => c.Guid());
            AddColumn("AD.LineOfBusinessAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.LineOfBusinessAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ParamDefinitionAudit", "ID", c => c.Guid());
            AddColumn("AD.ParamDefinitionAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.ParamDefinitionAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ParamTypeAudit", "ID", c => c.Guid());
            AddColumn("AD.ParamTypeAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.ParamTypeAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.ParamVersionAudit", "ID", c => c.Guid());
            AddColumn("AD.ParamVersionAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.ParamVersionAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.PathServerAudit", "ID", c => c.Guid());
            AddColumn("AD.PathServerAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.PathServerAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.PathShareAudit", "ID", c => c.Guid());
            AddColumn("AD.PathShareAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.PathShareAudit", "updateUser", c => c.String(maxLength: 20));
            AddColumn("AD.PlanAudit", "ID", c => c.Guid());
            AddColumn("AD.PlanAudit", "updateDT", c => c.DateTime());
            AddColumn("AD.PlanAudit", "updateUser", c => c.String(maxLength: 20));
            AlterColumn("AD.ParamDefinition", "ParamSequence", c => c.Int(nullable: false));
            CreateIndex("AD.ParamDefinition", new[] { "ParamVersionID", "ParamSequence" }, unique: true, name: "NDX_PKey");
            DropColumn("AD.AppAudit", "ID_");
            DropColumn("AD.AppAudit", "updateDT_");
            DropColumn("AD.AppAudit", "updateUser_");
            DropColumn("AD.ConfigAudit", "ID_");
            DropColumn("AD.ConfigAudit", "updateDT_");
            DropColumn("AD.ConfigAudit", "updateUser_");
            DropColumn("AD.ConfigParamDEV1Audit", "ID_");
            DropColumn("AD.ConfigParamDEV1Audit", "updateDT_");
            DropColumn("AD.ConfigParamDEV1Audit", "updateUser_");
            DropColumn("AD.ConfigParamDEV2Audit", "ID_");
            DropColumn("AD.ConfigParamDEV2Audit", "updateDT_");
            DropColumn("AD.ConfigParamDEV2Audit", "updateUser_");
            DropColumn("AD.ConfigParamPRODAudit", "ID_");
            DropColumn("AD.ConfigParamPRODAudit", "updateDT_");
            DropColumn("AD.ConfigParamPRODAudit", "updateUser_");
            DropColumn("AD.ConfigParamQA1Audit", "ID_");
            DropColumn("AD.ConfigParamQA1Audit", "updateDT_");
            DropColumn("AD.ConfigParamQA1Audit", "updateUser_");
            DropColumn("AD.ConfigParamQA2Audit", "ID_");
            DropColumn("AD.ConfigParamQA2Audit", "updateDT_");
            DropColumn("AD.ConfigParamQA2Audit", "updateUser_");
            DropColumn("AD.ConfigParamSTG1Audit", "ID_");
            DropColumn("AD.ConfigParamSTG1Audit", "updateDT_");
            DropColumn("AD.ConfigParamSTG1Audit", "updateUser_");
            DropColumn("AD.ConfigParamSTG2Audit", "ID_");
            DropColumn("AD.ConfigParamSTG2Audit", "updateDT_");
            DropColumn("AD.ConfigParamSTG2Audit", "updateUser_");
            DropColumn("AD.ExecutableAudit", "ID_");
            DropColumn("AD.ExecutableAudit", "updateDT_");
            DropColumn("AD.ExecutableAudit", "updateUser_");
            DropColumn("AD.PrimaryFunctionAudit", "ID_");
            DropColumn("AD.PrimaryFunctionAudit", "updateDT_");
            DropColumn("AD.PrimaryFunctionAudit", "updateUser_");
            DropColumn("AD.JAppPlanAudit", "ID_");
            DropColumn("AD.JAppPlanAudit", "updateDT_");
            DropColumn("AD.JAppPlanAudit", "updateUser_");
            DropColumn("AD.JConfigExecutableAudit", "ID_");
            DropColumn("AD.JConfigExecutableAudit", "updateDT_");
            DropColumn("AD.JConfigExecutableAudit", "updateUser_");
            DropColumn("AD.JConfigJPlanLOBAudit", "ID_");
            DropColumn("AD.JConfigJPlanLOBAudit", "updateDT_");
            DropColumn("AD.JConfigJPlanLOBAudit", "updateUser_");
            DropColumn("AD.JConfigPlanAudit", "ID_");
            DropColumn("AD.JConfigPlanAudit", "updateDT_");
            DropColumn("AD.JConfigPlanAudit", "updateUser_");
            DropColumn("AD.JExecutablePathServerAudit", "ID_");
            DropColumn("AD.JExecutablePathServerAudit", "updateDT_");
            DropColumn("AD.JExecutablePathServerAudit", "updateUser_");
            DropColumn("AD.JExecutablePrimaryFunctionAudit", "ID_");
            DropColumn("AD.JExecutablePrimaryFunctionAudit", "updateDT_");
            DropColumn("AD.JExecutablePrimaryFunctionAudit", "updateUser_");
            DropColumn("AD.JPathServerPathShareAudit", "ID_");
            DropColumn("AD.JPathServerPathShareAudit", "updateDT_");
            DropColumn("AD.JPathServerPathShareAudit", "updateUser_");
            DropColumn("AD.JPlanLOBAudit", "ID_");
            DropColumn("AD.JPlanLOBAudit", "updateDT_");
            DropColumn("AD.JPlanLOBAudit", "updateUser_");
            DropColumn("AD.LineOfBusinessAudit", "ID_");
            DropColumn("AD.LineOfBusinessAudit", "updateDT_");
            DropColumn("AD.LineOfBusinessAudit", "updateUser_");
            DropColumn("AD.ParamDefinitionAudit", "ID_");
            DropColumn("AD.ParamDefinitionAudit", "updateDT_");
            DropColumn("AD.ParamDefinitionAudit", "updateUser_");
            DropColumn("AD.ParamTypeAudit", "ID_");
            DropColumn("AD.ParamTypeAudit", "updateDT_");
            DropColumn("AD.ParamTypeAudit", "updateUser_");
            DropColumn("AD.ParamVersionAudit", "ID_");
            DropColumn("AD.ParamVersionAudit", "updateDT_");
            DropColumn("AD.ParamVersionAudit", "updateUser_");
            DropColumn("AD.PathServerAudit", "ID_");
            DropColumn("AD.PathServerAudit", "updateDT_");
            DropColumn("AD.PathServerAudit", "updateUser_");
            DropColumn("AD.PathShareAudit", "ID_");
            DropColumn("AD.PathShareAudit", "updateDT_");
            DropColumn("AD.PathShareAudit", "updateUser_");
            DropColumn("AD.PlanAudit", "ID_");
            DropColumn("AD.PlanAudit", "updateDT_");
            DropColumn("AD.PlanAudit", "updateUser_");
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
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"INSERT [_DEV1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionsID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser], [ParamDefinition_ID])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionsID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser, @ParamDefinition_ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV1_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"UPDATE [_DEV1].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionsID] = @ParamDefinitionsID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser, [ParamDefinition_ID] = @ParamDefinition_ID
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV1_Delete",
                p => new
                    {
                        ID = p.Guid(),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"DELETE [_DEV1].[ConfigParam]
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
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
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"INSERT [_DEV2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionsID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser], [ParamDefinition_ID])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionsID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser, @ParamDefinition_ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV2_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"UPDATE [_DEV2].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionsID] = @ParamDefinitionsID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser, [ParamDefinition_ID] = @ParamDefinition_ID
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamDEV2_Delete",
                p => new
                    {
                        ID = p.Guid(),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"DELETE [_DEV2].[ConfigParam]
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamPROD_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"INSERT [_PROD].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionsID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser], [ParamDefinition_ID])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionsID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser, @ParamDefinition_ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamPROD_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"UPDATE [_PROD].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionsID] = @ParamDefinitionsID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser, [ParamDefinition_ID] = @ParamDefinition_ID
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamPROD_Delete",
                p => new
                    {
                        ID = p.Guid(),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"DELETE [_PROD].[ConfigParam]
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA1_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"INSERT [_QA1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionsID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser], [ParamDefinition_ID])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionsID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser, @ParamDefinition_ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA1_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"UPDATE [_QA1].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionsID] = @ParamDefinitionsID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser, [ParamDefinition_ID] = @ParamDefinition_ID
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA1_Delete",
                p => new
                    {
                        ID = p.Guid(),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"DELETE [_QA1].[ConfigParam]
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA2_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"INSERT [_QA2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionsID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser], [ParamDefinition_ID])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionsID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser, @ParamDefinition_ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA2_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"UPDATE [_QA2].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionsID] = @ParamDefinitionsID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser, [ParamDefinition_ID] = @ParamDefinition_ID
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamQA2_Delete",
                p => new
                    {
                        ID = p.Guid(),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"DELETE [_QA2].[ConfigParam]
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG1_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"INSERT [_STG1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionsID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser], [ParamDefinition_ID])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionsID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser, @ParamDefinition_ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG1_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"UPDATE [_STG1].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionsID] = @ParamDefinitionsID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser, [ParamDefinition_ID] = @ParamDefinition_ID
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG1_Delete",
                p => new
                    {
                        ID = p.Guid(),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"DELETE [_STG1].[ConfigParam]
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG2_Insert",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"INSERT [_STG2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionsID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser], [ParamDefinition_ID])
                      VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionsID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser, @ParamDefinition_ID)"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG2_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ConfigID = p.Guid(),
                        effDT = p.DateTime(),
                        trmDT = p.DateTime(),
                        ParamDefinitionsID = p.Guid(),
                        isRefOnly = p.Boolean(),
                        value = p.String(),
                        valueUseageComments = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"UPDATE [_STG2].[ConfigParam]
                      SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionsID] = @ParamDefinitionsID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser, [ParamDefinition_ID] = @ParamDefinition_ID
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
            );
            
            CreateStoredProcedure(
                "AD.ConfigParamSTG2_Delete",
                p => new
                    {
                        ID = p.Guid(),
                        ParamDefinition_ID = p.Guid(),
                    },
                body:
                    @"DELETE [_STG2].[ConfigParam]
                      WHERE (([ID] = @ID) AND ([ParamDefinition_ID] = @ParamDefinition_ID))"
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
                        ParamVersionID = p.Guid(),
                        AppID = p.Guid(),
                        nameWExtension = p.String(maxLength: 256),
                        description = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"INSERT [AD].[Executable]([ID], [ParamVersionID], [AppID], [nameWExtension], [description], [updateDT], [updateUser])
                      VALUES (@ID, @ParamVersionID, @AppID, @nameWExtension, @description, @updateDT, @updateUser)"
            );
            
            CreateStoredProcedure(
                "AD.Executable_Update",
                p => new
                    {
                        ID = p.Guid(),
                        ParamVersionID = p.Guid(),
                        AppID = p.Guid(),
                        nameWExtension = p.String(maxLength: 256),
                        description = p.String(maxLength: 100),
                        updateDT = p.DateTime(),
                        updateUser = p.String(maxLength: 20),
                    },
                body:
                    @"UPDATE [AD].[Executable]
                      SET [ParamVersionID] = @ParamVersionID, [AppID] = @AppID, [nameWExtension] = @nameWExtension, [description] = @description, [updateDT] = @updateDT, [updateUser] = @updateUser
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
            AddColumn("AD.PlanAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.PlanAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.PlanAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.PathShareAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.PathShareAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.PathShareAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.PathServerAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.PathServerAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.PathServerAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ParamVersionAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ParamVersionAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ParamVersionAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ParamTypeAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ParamTypeAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ParamTypeAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ParamDefinitionAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ParamDefinitionAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ParamDefinitionAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.LineOfBusinessAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.LineOfBusinessAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.LineOfBusinessAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.JPlanLOBAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.JPlanLOBAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.JPlanLOBAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.JPathServerPathShareAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.JPathServerPathShareAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.JPathServerPathShareAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.JExecutablePrimaryFunctionAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.JExecutablePrimaryFunctionAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.JExecutablePrimaryFunctionAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.JExecutablePathServerAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.JExecutablePathServerAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.JExecutablePathServerAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.JConfigPlanAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.JConfigPlanAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.JConfigPlanAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.JConfigJPlanLOBAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.JConfigJPlanLOBAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.JConfigJPlanLOBAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.JConfigExecutableAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.JConfigExecutableAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.JConfigExecutableAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.JAppPlanAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.JAppPlanAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.JAppPlanAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.PrimaryFunctionAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.PrimaryFunctionAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.PrimaryFunctionAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ExecutableAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ExecutableAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ExecutableAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ConfigParamSTG2Audit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamSTG2Audit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ConfigParamSTG2Audit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ConfigParamSTG1Audit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamSTG1Audit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ConfigParamSTG1Audit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ConfigParamQA2Audit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamQA2Audit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ConfigParamQA2Audit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ConfigParamQA1Audit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamQA1Audit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ConfigParamQA1Audit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ConfigParamPRODAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamPRODAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ConfigParamPRODAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ConfigParamDEV2Audit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamDEV2Audit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ConfigParamDEV2Audit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ConfigParamDEV1Audit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigParamDEV1Audit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ConfigParamDEV1Audit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.ConfigAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.ConfigAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.ConfigAudit", "ID_", c => c.Guid(nullable: false));
            AddColumn("AD.AppAudit", "updateUser_", c => c.String(maxLength: 20));
            AddColumn("AD.AppAudit", "updateDT_", c => c.DateTime(nullable: false));
            AddColumn("AD.AppAudit", "ID_", c => c.Guid(nullable: false));
            DropIndex("AD.ParamDefinition", "NDX_PKey");
            AlterColumn("AD.ParamDefinition", "ParamSequence", c => c.Int(nullable: false, identity: true));
            DropColumn("AD.PlanAudit", "updateUser");
            DropColumn("AD.PlanAudit", "updateDT");
            DropColumn("AD.PlanAudit", "ID");
            DropColumn("AD.PathShareAudit", "updateUser");
            DropColumn("AD.PathShareAudit", "updateDT");
            DropColumn("AD.PathShareAudit", "ID");
            DropColumn("AD.PathServerAudit", "updateUser");
            DropColumn("AD.PathServerAudit", "updateDT");
            DropColumn("AD.PathServerAudit", "ID");
            DropColumn("AD.ParamVersionAudit", "updateUser");
            DropColumn("AD.ParamVersionAudit", "updateDT");
            DropColumn("AD.ParamVersionAudit", "ID");
            DropColumn("AD.ParamTypeAudit", "updateUser");
            DropColumn("AD.ParamTypeAudit", "updateDT");
            DropColumn("AD.ParamTypeAudit", "ID");
            DropColumn("AD.ParamDefinitionAudit", "updateUser");
            DropColumn("AD.ParamDefinitionAudit", "updateDT");
            DropColumn("AD.ParamDefinitionAudit", "ID");
            DropColumn("AD.LineOfBusinessAudit", "updateUser");
            DropColumn("AD.LineOfBusinessAudit", "updateDT");
            DropColumn("AD.LineOfBusinessAudit", "ID");
            DropColumn("AD.JPlanLOBAudit", "updateUser");
            DropColumn("AD.JPlanLOBAudit", "updateDT");
            DropColumn("AD.JPlanLOBAudit", "ID");
            DropColumn("AD.JPathServerPathShareAudit", "updateUser");
            DropColumn("AD.JPathServerPathShareAudit", "updateDT");
            DropColumn("AD.JPathServerPathShareAudit", "ID");
            DropColumn("AD.JExecutablePrimaryFunctionAudit", "updateUser");
            DropColumn("AD.JExecutablePrimaryFunctionAudit", "updateDT");
            DropColumn("AD.JExecutablePrimaryFunctionAudit", "ID");
            DropColumn("AD.JExecutablePathServerAudit", "updateUser");
            DropColumn("AD.JExecutablePathServerAudit", "updateDT");
            DropColumn("AD.JExecutablePathServerAudit", "ID");
            DropColumn("AD.JConfigPlanAudit", "updateUser");
            DropColumn("AD.JConfigPlanAudit", "updateDT");
            DropColumn("AD.JConfigPlanAudit", "ID");
            DropColumn("AD.JConfigJPlanLOBAudit", "updateUser");
            DropColumn("AD.JConfigJPlanLOBAudit", "updateDT");
            DropColumn("AD.JConfigJPlanLOBAudit", "ID");
            DropColumn("AD.JConfigExecutableAudit", "updateUser");
            DropColumn("AD.JConfigExecutableAudit", "updateDT");
            DropColumn("AD.JConfigExecutableAudit", "ID");
            DropColumn("AD.JAppPlanAudit", "updateUser");
            DropColumn("AD.JAppPlanAudit", "updateDT");
            DropColumn("AD.JAppPlanAudit", "ID");
            DropColumn("AD.PrimaryFunctionAudit", "updateUser");
            DropColumn("AD.PrimaryFunctionAudit", "updateDT");
            DropColumn("AD.PrimaryFunctionAudit", "ID");
            DropColumn("AD.ExecutableAudit", "updateUser");
            DropColumn("AD.ExecutableAudit", "updateDT");
            DropColumn("AD.ExecutableAudit", "ID");
            DropColumn("AD.ConfigParamSTG2Audit", "updateUser");
            DropColumn("AD.ConfigParamSTG2Audit", "updateDT");
            DropColumn("AD.ConfigParamSTG2Audit", "ID");
            DropColumn("AD.ConfigParamSTG1Audit", "updateUser");
            DropColumn("AD.ConfigParamSTG1Audit", "updateDT");
            DropColumn("AD.ConfigParamSTG1Audit", "ID");
            DropColumn("AD.ConfigParamQA2Audit", "updateUser");
            DropColumn("AD.ConfigParamQA2Audit", "updateDT");
            DropColumn("AD.ConfigParamQA2Audit", "ID");
            DropColumn("AD.ConfigParamQA1Audit", "updateUser");
            DropColumn("AD.ConfigParamQA1Audit", "updateDT");
            DropColumn("AD.ConfigParamQA1Audit", "ID");
            DropColumn("AD.ConfigParamPRODAudit", "updateUser");
            DropColumn("AD.ConfigParamPRODAudit", "updateDT");
            DropColumn("AD.ConfigParamPRODAudit", "ID");
            DropColumn("AD.ConfigParamDEV2Audit", "updateUser");
            DropColumn("AD.ConfigParamDEV2Audit", "updateDT");
            DropColumn("AD.ConfigParamDEV2Audit", "ID");
            DropColumn("AD.ConfigParamDEV1Audit", "updateUser");
            DropColumn("AD.ConfigParamDEV1Audit", "updateDT");
            DropColumn("AD.ConfigParamDEV1Audit", "ID");
            DropColumn("AD.ConfigAudit", "updateUser");
            DropColumn("AD.ConfigAudit", "updateDT");
            DropColumn("AD.ConfigAudit", "ID");
            DropColumn("AD.AppAudit", "updateUser");
            DropColumn("AD.AppAudit", "updateDT");
            DropColumn("AD.AppAudit", "ID");
            CreateIndex("AD.ParamDefinition", new[] { "ParamVersionID", "ParamSequence" }, unique: true, name: "NDX_PKey");
        }
    }
}
