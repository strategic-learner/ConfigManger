IF schema_id('AD') IS NULL
    EXECUTE('CREATE SCHEMA [AD]')
CREATE TABLE [AD].[App] (
    [ID] [uniqueidentifier] NOT NULL,
    [ITIL] [int] NOT NULL,
    [abbr] [nvarchar](3) NOT NULL,
    [description] [nvarchar](100) NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.App] PRIMARY KEY ([ID])
)
CREATE TABLE [AD].[Config] (
    [ID] [uniqueidentifier] NOT NULL,
    [jobID] [int] NOT NULL IDENTITY,
    [AppID] [uniqueidentifier] NOT NULL,
    [ParamVersionID] [uniqueidentifier] NOT NULL,
    [Active] [bit] NOT NULL,
    [DescriptonShort] [nvarchar](25) NOT NULL,
    [DescriptonFull] [nvarchar](100) NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.Config] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_AppID] ON [AD].[Config]([AppID])
CREATE INDEX [IX_ParamVersionID] ON [AD].[Config]([ParamVersionID])
IF schema_id('_DEV1') IS NULL
    EXECUTE('CREATE SCHEMA [_DEV1]')
CREATE TABLE [_DEV1].[ConfigParam] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max) NOT NULL,
    [valueUseageComments] [nvarchar](100),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK__DEV1.ConfigParam] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_ConfigID] ON [_DEV1].[ConfigParam]([ConfigID])
CREATE INDEX [IX_ParamDefinitionID] ON [_DEV1].[ConfigParam]([ParamDefinitionID])


CREATE TABLE [AD].[ParamDefinition] (
    [ID] [uniqueidentifier] NOT NULL,
    [ParamVersionID] [uniqueidentifier] NOT NULL,
    [ParamSequence] [int] NOT NULL,
    [ParamTypeID] [uniqueidentifier] NOT NULL,
    [variableName] [nvarchar](50) NOT NULL,
    [intendedUse] [nvarchar](500) NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.ParamDefinition] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UNIQUE_ParamVersionID_ParamSequence] ON [AD].[ParamDefinition]([ParamVersionID], [ParamSequence])
CREATE INDEX [IX_ParamTypeID] ON [AD].[ParamDefinition]([ParamTypeID])


IF schema_id('_DEV2') IS NULL
    EXECUTE('CREATE SCHEMA [_DEV2]')
CREATE TABLE [_DEV2].[ConfigParam] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max) NOT NULL,
    [valueUseageComments] [nvarchar](100),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK__DEV2.ConfigParam] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_ConfigID] ON [_DEV2].[ConfigParam]([ConfigID])
CREATE INDEX [IX_ParamDefinitionID] ON [_DEV2].[ConfigParam]([ParamDefinitionID])
IF schema_id('_PROD') IS NULL
    EXECUTE('CREATE SCHEMA [_PROD]')
CREATE TABLE [_PROD].[ConfigParam] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max) NOT NULL,
    [valueUseageComments] [nvarchar](100),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK__PROD.ConfigParam] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_ConfigID] ON [_PROD].[ConfigParam]([ConfigID])
CREATE INDEX [IX_ParamDefinitionID] ON [_PROD].[ConfigParam]([ParamDefinitionID])
IF schema_id('_QA1') IS NULL
    EXECUTE('CREATE SCHEMA [_QA1]')
CREATE TABLE [_QA1].[ConfigParam] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max) NOT NULL,
    [valueUseageComments] [nvarchar](100),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK__QA1.ConfigParam] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_ConfigID] ON [_QA1].[ConfigParam]([ConfigID])
CREATE INDEX [IX_ParamDefinitionID] ON [_QA1].[ConfigParam]([ParamDefinitionID])
IF schema_id('_QA2') IS NULL
    EXECUTE('CREATE SCHEMA [_QA2]')
CREATE TABLE [_QA2].[ConfigParam] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max) NOT NULL,
    [valueUseageComments] [nvarchar](100),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK__QA2.ConfigParam] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_ConfigID] ON [_QA2].[ConfigParam]([ConfigID])
CREATE INDEX [IX_ParamDefinitionID] ON [_QA2].[ConfigParam]([ParamDefinitionID])
IF schema_id('_STG1') IS NULL
    EXECUTE('CREATE SCHEMA [_STG1]')
CREATE TABLE [_STG1].[ConfigParam] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max) NOT NULL,
    [valueUseageComments] [nvarchar](100),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK__STG1.ConfigParam] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_ConfigID] ON [_STG1].[ConfigParam]([ConfigID])
CREATE INDEX [IX_ParamDefinitionID] ON [_STG1].[ConfigParam]([ParamDefinitionID])
IF schema_id('_STG2') IS NULL
    EXECUTE('CREATE SCHEMA [_STG2]')
CREATE TABLE [_STG2].[ConfigParam] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max) NOT NULL,
    [valueUseageComments] [nvarchar](100),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK__STG2.ConfigParam] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_ConfigID] ON [_STG2].[ConfigParam]([ConfigID])
CREATE INDEX [IX_ParamDefinitionID] ON [_STG2].[ConfigParam]([ParamDefinitionID])
CREATE TABLE [AD].[ParamType] (
    [ID] [uniqueidentifier] NOT NULL,
    [type] [nvarchar](15) NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.ParamType] PRIMARY KEY ([ID])
)
CREATE TABLE [AD].[ParamVersion] (
    [ID] [uniqueidentifier] NOT NULL,
    [version] [real] NOT NULL,
    [description] [nvarchar](100) NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.ParamVersion] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UNIQUE_version] ON [AD].[ParamVersion]([version])
CREATE TABLE [AD].[Executable] (
    [ID] [uniqueidentifier] NOT NULL,
    [AppID] [uniqueidentifier] NOT NULL,
    [nameWExtension] [nvarchar](256) NOT NULL,
    [description] [nvarchar](100) NOT NULL,
    [ParamVersionID] [uniqueidentifier],
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.Executable] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_AppID_NameWExtension] ON [AD].[Executable]([AppID], [nameWExtension])
CREATE INDEX [IX_ParamVersionID] ON [AD].[Executable]([ParamVersionID])
CREATE TABLE [AD].[J_Config_Executable] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [ExecutableID] [uniqueidentifier] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.J_Config_Executable] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UniqueKey] ON [AD].[J_Config_Executable]([ConfigID], [ExecutableID])
CREATE TABLE [AD].[J_Executable_PathServer] (
    [ID] [uniqueidentifier] NOT NULL,
    [ExecutableID] [uniqueidentifier] NOT NULL,
    [PathServerID] [uniqueidentifier] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.J_Executable_PathServer] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UniqueKey] ON [AD].[J_Executable_PathServer]([ExecutableID], [PathServerID])
CREATE TABLE [AD].[PathServer] (
    [ID] [uniqueidentifier] NOT NULL,
    [server] [nvarchar](256) NOT NULL,
    [path] [nvarchar](256),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.PathServer] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UNIQUE_server_path] ON [AD].[PathServer]([server], [path])
CREATE TABLE [AD].[J_PathServer_PathShare] (
    [ID] [uniqueidentifier] NOT NULL,
    [PathServerID] [uniqueidentifier] NOT NULL,
    [PathShareID] [uniqueidentifier] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.J_PathServer_PathShare] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UniqueKey] ON [AD].[J_PathServer_PathShare]([PathServerID], [PathShareID])
CREATE TABLE [AD].[PathShare] (
    [ID] [uniqueidentifier] NOT NULL,
    [share] [nvarchar](256) NOT NULL,
    [path] [nvarchar](256),
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.PathShare] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UNIQUE_share_path] ON [AD].[PathShare]([share], [path])
CREATE TABLE [AD].[J_Executable_PrimaryFunction] (
    [ID] [uniqueidentifier] NOT NULL,
    [ExecutableID] [uniqueidentifier] NOT NULL,
    [PrimaryFunctionID] [uniqueidentifier] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.J_Executable_PrimaryFunction] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UniqueKey] ON [AD].[J_Executable_PrimaryFunction]([ExecutableID], [PrimaryFunctionID])
CREATE TABLE [AD].[PrimaryFunction] (
    [ID] [uniqueidentifier] NOT NULL,
    [abbr] [nvarchar](3) NOT NULL,
    [description] [nvarchar](50) NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.PrimaryFunction] PRIMARY KEY ([ID])
)
CREATE TABLE [AD].[J_Config_JPlanLOB] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [JPlanLOBID] [uniqueidentifier] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.J_Config_JPlanLOB] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UniqueKey] ON [AD].[J_Config_JPlanLOB]([ConfigID], [JPlanLOBID])
CREATE TABLE [AD].[J_Plan_LOB] (
    [ID] [uniqueidentifier] NOT NULL,
    [planID] [uniqueidentifier] NOT NULL,
    [LineOfBusinessID] [uniqueidentifier] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.J_Plan_LOB] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UniqueKey] ON [AD].[J_Plan_LOB]([planID], [LineOfBusinessID])
CREATE TABLE [AD].[LineOfBusiness] (
    [ID] [uniqueidentifier] NOT NULL,
    [abbr] [nvarchar](10) NOT NULL,
    [descr] [nvarchar](50) NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.LineOfBusiness] PRIMARY KEY ([ID])
)
CREATE TABLE [AD].[Plan] (
    [ID] [uniqueidentifier] NOT NULL,
    [abbr] [nvarchar](4) NOT NULL,
    [descr] [nvarchar](50) NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.Plan] PRIMARY KEY ([ID])
)
CREATE TABLE [AD].[J_App_Plan] (
    [ID] [uniqueidentifier] NOT NULL,
    [AppID] [uniqueidentifier] NOT NULL,
    [PlanID] [uniqueidentifier] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.J_App_Plan] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UniqueKey] ON [AD].[J_App_Plan]([AppID], [PlanID])
CREATE TABLE [AD].[J_Config_Plan] (
    [ID] [uniqueidentifier] NOT NULL,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [PlanID] [uniqueidentifier] NOT NULL,
    [updateDT] [datetime] NOT NULL,
    [updateUser] [nvarchar](20) NOT NULL,
    CONSTRAINT [PK_AD.J_Config_Plan] PRIMARY KEY ([ID])
)
CREATE UNIQUE INDEX [NDX_UniqueKey] ON [AD].[J_Config_Plan]([ConfigID], [PlanID])
CREATE TABLE [AD].[AppAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ITIL] [int] NOT NULL,
    [abbr] [nvarchar](3),
    [description] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.AppAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ConfigAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [jobID] [int] NOT NULL,
    [AppID] [uniqueidentifier] NOT NULL,
    [ParamVersionID] [uniqueidentifier] NOT NULL,
    [Active] [bit] NOT NULL,
    [DescriptonShort] [nvarchar](25),
    [DescriptonFull] [nvarchar](100),
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ConfigAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ConfigParamDEV1Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max),
    [valueUseageComments] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ConfigParamDEV1Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ConfigParamDEV2Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max),
    [valueUseageComments] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ConfigParamDEV2Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ConfigParamPRODAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max),
    [valueUseageComments] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ConfigParamPRODAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ConfigParamQA1Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max),
    [valueUseageComments] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ConfigParamQA1Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ConfigParamQA2Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max),
    [valueUseageComments] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ConfigParamQA2Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ConfigParamSTG1Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max),
    [valueUseageComments] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ConfigParamSTG1Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ConfigParamSTG2Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [effDT] [datetime] NOT NULL,
    [trmDT] [datetime] NOT NULL,
    [ParamDefinitionID] [uniqueidentifier] NOT NULL,
    [isRefOnly] [bit] NOT NULL,
    [value] [nvarchar](max),
    [valueUseageComments] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ConfigParamSTG2Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ExecutableAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [AppID] [uniqueidentifier] NOT NULL,
    [nameWExtension] [nvarchar](256),
    [description] [nvarchar](100),
    [ParamVersionID] [uniqueidentifier],
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ExecutableAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[PrimaryFunctionAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [abbr] [nvarchar](3),
    [description] [nvarchar](50),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.PrimaryFunctionAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[J_App_Plan_Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [AppID] [uniqueidentifier] NOT NULL,
    [PlanID] [uniqueidentifier] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.J_App_Plan_Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[J_Config_Executable_Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [ExecutableID] [uniqueidentifier] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.J_Config_Executable_Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[J_Config_JPlanLOB_Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [JPlanLOBID] [uniqueidentifier] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.J_Config_JPlanLOB_Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[J_Config_Plan_Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ConfigID] [uniqueidentifier] NOT NULL,
    [PlanID] [uniqueidentifier] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.J_Config_Plan_Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[J_Executable_PathServer_Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ExecutableID] [uniqueidentifier] NOT NULL,
    [PathServerID] [uniqueidentifier] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.J_Executable_PathServer_Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[J_Executable_PrimaryFunction_Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ExecutableID] [uniqueidentifier] NOT NULL,
    [PrimaryFunctionID] [uniqueidentifier] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.J_Executable_PrimaryFunction_Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[J_PathServer_PathShare_Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [PathServerID] [uniqueidentifier] NOT NULL,
    [PathShareID] [uniqueidentifier] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.J_PathServer_PathShare_Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[J_Plan_LOB_Audit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [planID] [uniqueidentifier] NOT NULL,
    [LineOfBusinessID] [uniqueidentifier] NOT NULL,
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.J_Plan_LOB_Audit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[LineOfBusinessAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [abbr] [nvarchar](10),
    [descr] [nvarchar](50),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.LineOfBusinessAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ParamDefinitionAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [ParamVersionID] [uniqueidentifier] NOT NULL,
    [ParamSequence] [int] NOT NULL,
    [ParamTypeID] [uniqueidentifier] NOT NULL,
    [variableName] [nvarchar](50),
    [intendedUse] [nvarchar](500),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ParamDefinitionAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ParamTypeAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [type] [nvarchar](15),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ParamTypeAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[ParamVersionAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [version] [real] NOT NULL,
    [description] [nvarchar](100),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.ParamVersionAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[PathServerAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [server] [nvarchar](256),
    [path] [nvarchar](256),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.PathServerAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[PathShareAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [share] [nvarchar](256),
    [path] [nvarchar](256),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.PathShareAudit] PRIMARY KEY ([AuditID])
)
CREATE TABLE [AD].[PlanAudit] (
    [AuditID] [int] NOT NULL IDENTITY,
    [abbr] [nvarchar](4),
    [descr] [nvarchar](50),
    [AuditDT] [datetime] NOT NULL,
    [AuditType] [tinyint] NOT NULL,
    [AuditSUserSName] [nvarchar](20) NOT NULL,
    [ID] [uniqueidentifier],
    [updateDT] [datetime],
    [updateUser] [nvarchar](20),
    CONSTRAINT [PK_AD.PlanAudit] PRIMARY KEY ([AuditID])
)
GO

CREATE PROCEDURE [AD].[App_Insert]
    @ID [uniqueidentifier],
    @ITIL [int],
    @abbr [nvarchar](3),
    @description [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[App]([ID], [ITIL], [abbr], [description], [updateDT], [updateUser])
    VALUES (@ID, @ITIL, @abbr, @description, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[App_Update]
    @ID [uniqueidentifier],
    @ITIL [int],
    @abbr [nvarchar](3),
    @description [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[App]
    SET [ITIL] = @ITIL, [abbr] = @abbr, [description] = @description, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[App_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[App]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[Config_Insert]
    @ID [uniqueidentifier],
    @AppID [uniqueidentifier],
    @ParamVersionID [uniqueidentifier],
    @Active [bit],
    @DescriptonShort [nvarchar](25),
    @DescriptonFull [nvarchar](100),
    @effDT [datetime],
    @trmDT [datetime],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[Config]([ID], [AppID], [ParamVersionID], [Active], [DescriptonShort], [DescriptonFull], [effDT], [trmDT], [updateDT], [updateUser])
    VALUES (@ID, @AppID, @ParamVersionID, @Active, @DescriptonShort, @DescriptonFull, @effDT, @trmDT, @updateDT, @updateUser)
    
    SELECT t0.[jobID]
    FROM [AD].[Config] AS t0
    WHERE @@ROWCOUNT > 0 AND t0.[ID] = @ID
END
GO

CREATE PROCEDURE [AD].[Config_Update]
    @ID [uniqueidentifier],
    @jobID [int],
    @AppID [uniqueidentifier],
    @ParamVersionID [uniqueidentifier],
    @Active [bit],
    @DescriptonShort [nvarchar](25),
    @DescriptonFull [nvarchar](100),
    @effDT [datetime],
    @trmDT [datetime],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[Config]
    SET [AppID] = @AppID, [ParamVersionID] = @ParamVersionID, [Active] = @Active, [DescriptonShort] = @DescriptonShort, [DescriptonFull] = @DescriptonFull, [effDT] = @effDT, [trmDT] = @trmDT, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[Config_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[Config]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamDEV1_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [_DEV1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ConfigParamDEV1_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [_DEV1].[ConfigParam]
    SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamDEV1_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [_DEV1].[ConfigParam]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ParamDefinition_Insert]
    @ID [uniqueidentifier],
    @ParamVersionID [uniqueidentifier],
    @ParamSequence [int],
    @ParamTypeID [uniqueidentifier],
    @variableName [nvarchar](50),
    @intendedUse [nvarchar](500),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[ParamDefinition]([ID], [ParamVersionID], [ParamSequence], [ParamTypeID], [variableName], [intendedUse], [updateDT], [updateUser])
    VALUES (@ID, @ParamVersionID, @ParamSequence, @ParamTypeID, @variableName, @intendedUse, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ParamDefinition_Update]
    @ID [uniqueidentifier],
    @ParamVersionID [uniqueidentifier],
    @ParamSequence [int],
    @ParamTypeID [uniqueidentifier],
    @variableName [nvarchar](50),
    @intendedUse [nvarchar](500),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[ParamDefinition]
    SET [ParamVersionID] = @ParamVersionID, [ParamSequence] = @ParamSequence, [ParamTypeID] = @ParamTypeID, [variableName] = @variableName, [intendedUse] = @intendedUse, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ParamDefinition_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[ParamDefinition]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamDEV2_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [_DEV2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ConfigParamDEV2_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [_DEV2].[ConfigParam]
    SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamDEV2_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [_DEV2].[ConfigParam]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamPROD_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [_PROD].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ConfigParamPROD_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [_PROD].[ConfigParam]
    SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamPROD_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [_PROD].[ConfigParam]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamQA1_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [_QA1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ConfigParamQA1_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [_QA1].[ConfigParam]
    SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamQA1_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [_QA1].[ConfigParam]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamQA2_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [_QA2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ConfigParamQA2_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [_QA2].[ConfigParam]
    SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamQA2_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [_QA2].[ConfigParam]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamSTG1_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [_STG1].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ConfigParamSTG1_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [_STG1].[ConfigParam]
    SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamSTG1_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [_STG1].[ConfigParam]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamSTG2_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [_STG2].[ConfigParam]([ID], [ConfigID], [effDT], [trmDT], [ParamDefinitionID], [isRefOnly], [value], [valueUseageComments], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @effDT, @trmDT, @ParamDefinitionID, @isRefOnly, @value, @valueUseageComments, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ConfigParamSTG2_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @effDT [datetime],
    @trmDT [datetime],
    @ParamDefinitionID [uniqueidentifier],
    @isRefOnly [bit],
    @value [nvarchar](max),
    @valueUseageComments [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [_STG2].[ConfigParam]
    SET [ConfigID] = @ConfigID, [effDT] = @effDT, [trmDT] = @trmDT, [ParamDefinitionID] = @ParamDefinitionID, [isRefOnly] = @isRefOnly, [value] = @value, [valueUseageComments] = @valueUseageComments, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ConfigParamSTG2_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [_STG2].[ConfigParam]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ParamType_Insert]
    @ID [uniqueidentifier],
    @type [nvarchar](15),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[ParamType]([ID], [type], [updateDT], [updateUser])
    VALUES (@ID, @type, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ParamType_Update]
    @ID [uniqueidentifier],
    @type [nvarchar](15),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[ParamType]
    SET [type] = @type, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ParamType_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[ParamType]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ParamVersion_Insert]
    @ID [uniqueidentifier],
    @version [real],
    @description [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[ParamVersion]([ID], [version], [description], [updateDT], [updateUser])
    VALUES (@ID, @version, @description, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[ParamVersion_Update]
    @ID [uniqueidentifier],
    @version [real],
    @description [nvarchar](100),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[ParamVersion]
    SET [version] = @version, [description] = @description, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[ParamVersion_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[ParamVersion]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[Executable_Insert]
    @ID [uniqueidentifier],
    @AppID [uniqueidentifier],
    @nameWExtension [nvarchar](256),
    @description [nvarchar](100),
    @ParamVersionID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[Executable]([ID], [AppID], [nameWExtension], [description], [ParamVersionID], [updateDT], [updateUser])
    VALUES (@ID, @AppID, @nameWExtension, @description, @ParamVersionID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[Executable_Update]
    @ID [uniqueidentifier],
    @AppID [uniqueidentifier],
    @nameWExtension [nvarchar](256),
    @description [nvarchar](100),
    @ParamVersionID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[Executable]
    SET [AppID] = @AppID, [nameWExtension] = @nameWExtension, [description] = @description, [ParamVersionID] = @ParamVersionID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[Executable_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[Executable]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JConfigExecutable_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @ExecutableID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[J_Config_Executable]([ID], [ConfigID], [ExecutableID], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @ExecutableID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[JConfigExecutable_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @ExecutableID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[J_Config_Executable]
    SET [ConfigID] = @ConfigID, [ExecutableID] = @ExecutableID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JConfigExecutable_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[J_Config_Executable]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JExecutablePathServer_Insert]
    @ID [uniqueidentifier],
    @ExecutableID [uniqueidentifier],
    @PathServerID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[J_Executable_PathServer]([ID], [ExecutableID], [PathServerID], [updateDT], [updateUser])
    VALUES (@ID, @ExecutableID, @PathServerID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[JExecutablePathServer_Update]
    @ID [uniqueidentifier],
    @ExecutableID [uniqueidentifier],
    @PathServerID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[J_Executable_PathServer]
    SET [ExecutableID] = @ExecutableID, [PathServerID] = @PathServerID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JExecutablePathServer_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[J_Executable_PathServer]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[PathServer_Insert]
    @ID [uniqueidentifier],
    @server [nvarchar](256),
    @path [nvarchar](256),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[PathServer]([ID], [server], [path], [updateDT], [updateUser])
    VALUES (@ID, @server, @path, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[PathServer_Update]
    @ID [uniqueidentifier],
    @server [nvarchar](256),
    @path [nvarchar](256),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[PathServer]
    SET [server] = @server, [path] = @path, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[PathServer_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[PathServer]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JPathServerPathShare_Insert]
    @ID [uniqueidentifier],
    @PathServerID [uniqueidentifier],
    @PathShareID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[J_PathServer_PathShare]([ID], [PathServerID], [PathShareID], [updateDT], [updateUser])
    VALUES (@ID, @PathServerID, @PathShareID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[JPathServerPathShare_Update]
    @ID [uniqueidentifier],
    @PathServerID [uniqueidentifier],
    @PathShareID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[J_PathServer_PathShare]
    SET [PathServerID] = @PathServerID, [PathShareID] = @PathShareID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JPathServerPathShare_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[J_PathServer_PathShare]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[PathShare_Insert]
    @ID [uniqueidentifier],
    @share [nvarchar](256),
    @path [nvarchar](256),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[PathShare]([ID], [share], [path], [updateDT], [updateUser])
    VALUES (@ID, @share, @path, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[PathShare_Update]
    @ID [uniqueidentifier],
    @share [nvarchar](256),
    @path [nvarchar](256),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[PathShare]
    SET [share] = @share, [path] = @path, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[PathShare_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[PathShare]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JExecutablePrimaryFunction_Insert]
    @ID [uniqueidentifier],
    @ExecutableID [uniqueidentifier],
    @PrimaryFunctionID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[J_Executable_PrimaryFunction]([ID], [ExecutableID], [PrimaryFunctionID], [updateDT], [updateUser])
    VALUES (@ID, @ExecutableID, @PrimaryFunctionID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[JExecutablePrimaryFunction_Update]
    @ID [uniqueidentifier],
    @ExecutableID [uniqueidentifier],
    @PrimaryFunctionID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[J_Executable_PrimaryFunction]
    SET [ExecutableID] = @ExecutableID, [PrimaryFunctionID] = @PrimaryFunctionID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JExecutablePrimaryFunction_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[J_Executable_PrimaryFunction]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[PrimaryFunction_Insert]
    @ID [uniqueidentifier],
    @abbr [nvarchar](3),
    @description [nvarchar](50),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[PrimaryFunction]([ID], [abbr], [description], [updateDT], [updateUser])
    VALUES (@ID, @abbr, @description, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[PrimaryFunction_Update]
    @ID [uniqueidentifier],
    @abbr [nvarchar](3),
    @description [nvarchar](50),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[PrimaryFunction]
    SET [abbr] = @abbr, [description] = @description, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[PrimaryFunction_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[PrimaryFunction]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JConfigJPlanLOB_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @JPlanLOBID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[J_Config_JPlanLOB]([ID], [ConfigID], [JPlanLOBID], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @JPlanLOBID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[JConfigJPlanLOB_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @JPlanLOBID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[J_Config_JPlanLOB]
    SET [ConfigID] = @ConfigID, [JPlanLOBID] = @JPlanLOBID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JConfigJPlanLOB_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[J_Config_JPlanLOB]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JPlanLOB_Insert]
    @ID [uniqueidentifier],
    @planID [uniqueidentifier],
    @LineOfBusinessID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[J_Plan_LOB]([ID], [planID], [LineOfBusinessID], [updateDT], [updateUser])
    VALUES (@ID, @planID, @LineOfBusinessID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[JPlanLOB_Update]
    @ID [uniqueidentifier],
    @planID [uniqueidentifier],
    @LineOfBusinessID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[J_Plan_LOB]
    SET [planID] = @planID, [LineOfBusinessID] = @LineOfBusinessID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JPlanLOB_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[J_Plan_LOB]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[LineOfBusiness_Insert]
    @ID [uniqueidentifier],
    @abbr [nvarchar](10),
    @descr [nvarchar](50),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[LineOfBusiness]([ID], [abbr], [descr], [updateDT], [updateUser])
    VALUES (@ID, @abbr, @descr, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[LineOfBusiness_Update]
    @ID [uniqueidentifier],
    @abbr [nvarchar](10),
    @descr [nvarchar](50),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[LineOfBusiness]
    SET [abbr] = @abbr, [descr] = @descr, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[LineOfBusiness_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[LineOfBusiness]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[Plan_Insert]
    @ID [uniqueidentifier],
    @abbr [nvarchar](4),
    @descr [nvarchar](50),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[Plan]([ID], [abbr], [descr], [updateDT], [updateUser])
    VALUES (@ID, @abbr, @descr, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[Plan_Update]
    @ID [uniqueidentifier],
    @abbr [nvarchar](4),
    @descr [nvarchar](50),
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[Plan]
    SET [abbr] = @abbr, [descr] = @descr, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[Plan_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[Plan]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JAppPlan_Insert]
    @ID [uniqueidentifier],
    @AppID [uniqueidentifier],
    @PlanID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[J_App_Plan]([ID], [AppID], [PlanID], [updateDT], [updateUser])
    VALUES (@ID, @AppID, @PlanID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[JAppPlan_Update]
    @ID [uniqueidentifier],
    @AppID [uniqueidentifier],
    @PlanID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[J_App_Plan]
    SET [AppID] = @AppID, [PlanID] = @PlanID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JAppPlan_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[J_App_Plan]
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JConfigPlan_Insert]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @PlanID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    INSERT [AD].[J_Config_Plan]([ID], [ConfigID], [PlanID], [updateDT], [updateUser])
    VALUES (@ID, @ConfigID, @PlanID, @updateDT, @updateUser)
END
GO

CREATE PROCEDURE [AD].[JConfigPlan_Update]
    @ID [uniqueidentifier],
    @ConfigID [uniqueidentifier],
    @PlanID [uniqueidentifier],
    @updateDT [datetime],
    @updateUser [nvarchar](20)
AS
BEGIN
    UPDATE [AD].[J_Config_Plan]
    SET [ConfigID] = @ConfigID, [PlanID] = @PlanID, [updateDT] = @updateDT, [updateUser] = @updateUser
    WHERE ([ID] = @ID)
END
GO

CREATE PROCEDURE [AD].[JConfigPlan_Delete]
    @ID [uniqueidentifier]
AS
BEGIN
    DELETE [AD].[J_Config_Plan]
    WHERE ([ID] = @ID)
END
ALTER TABLE [AD].[Config] ADD CONSTRAINT [FK_AD.Config_AD.App_AppID] FOREIGN KEY ([AppID]) REFERENCES [AD].[App] ([ID])
ALTER TABLE [AD].[Config] ADD CONSTRAINT [FK_AD.Config_AD.ParamVersion_ParamVersionID] FOREIGN KEY ([ParamVersionID]) REFERENCES [AD].[ParamVersion] ([ID])
ALTER TABLE [_DEV1].[ConfigParam] ADD CONSTRAINT [FK__DEV1.ConfigParam_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [_DEV1].[ConfigParam] ADD CONSTRAINT [FK__DEV1.ConfigParam_AD.ParamDefinition_ParamDefinitionID] FOREIGN KEY ([ParamDefinitionID]) REFERENCES [AD].[ParamDefinition] ([ID])
ALTER TABLE [AD].[ParamDefinition] ADD CONSTRAINT [FK_AD.ParamDefinition_AD.ParamType_ParamTypeID] FOREIGN KEY ([ParamTypeID]) REFERENCES [AD].[ParamType] ([ID])
ALTER TABLE [AD].[ParamDefinition] ADD CONSTRAINT [FK_AD.ParamDefinition_AD.ParamVersion_ParamVersionID] FOREIGN KEY ([ParamVersionID]) REFERENCES [AD].[ParamVersion] ([ID])
ALTER TABLE [_DEV2].[ConfigParam] ADD CONSTRAINT [FK__DEV2.ConfigParam_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [_DEV2].[ConfigParam] ADD CONSTRAINT [FK__DEV2.ConfigParam_AD.ParamDefinition_ParamDefinitionID] FOREIGN KEY ([ParamDefinitionID]) REFERENCES [AD].[ParamDefinition] ([ID])
ALTER TABLE [_PROD].[ConfigParam] ADD CONSTRAINT [FK__PROD.ConfigParam_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [_PROD].[ConfigParam] ADD CONSTRAINT [FK__PROD.ConfigParam_AD.ParamDefinition_ParamDefinitionID] FOREIGN KEY ([ParamDefinitionID]) REFERENCES [AD].[ParamDefinition] ([ID])
ALTER TABLE [_QA1].[ConfigParam] ADD CONSTRAINT [FK__QA1.ConfigParam_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [_QA1].[ConfigParam] ADD CONSTRAINT [FK__QA1.ConfigParam_AD.ParamDefinition_ParamDefinitionID] FOREIGN KEY ([ParamDefinitionID]) REFERENCES [AD].[ParamDefinition] ([ID])
ALTER TABLE [_QA2].[ConfigParam] ADD CONSTRAINT [FK__QA2.ConfigParam_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [_QA2].[ConfigParam] ADD CONSTRAINT [FK__QA2.ConfigParam_AD.ParamDefinition_ParamDefinitionID] FOREIGN KEY ([ParamDefinitionID]) REFERENCES [AD].[ParamDefinition] ([ID])
ALTER TABLE [_STG1].[ConfigParam] ADD CONSTRAINT [FK__STG1.ConfigParam_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [_STG1].[ConfigParam] ADD CONSTRAINT [FK__STG1.ConfigParam_AD.ParamDefinition_ParamDefinitionID] FOREIGN KEY ([ParamDefinitionID]) REFERENCES [AD].[ParamDefinition] ([ID])
ALTER TABLE [_STG2].[ConfigParam] ADD CONSTRAINT [FK__STG2.ConfigParam_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [_STG2].[ConfigParam] ADD CONSTRAINT [FK__STG2.ConfigParam_AD.ParamDefinition_ParamDefinitionID] FOREIGN KEY ([ParamDefinitionID]) REFERENCES [AD].[ParamDefinition] ([ID])
ALTER TABLE [AD].[Executable] ADD CONSTRAINT [FK_AD.Executable_AD.App_AppID] FOREIGN KEY ([AppID]) REFERENCES [AD].[App] ([ID])
ALTER TABLE [AD].[Executable] ADD CONSTRAINT [FK_AD.Executable_AD.ParamVersion_ParamVersionID] FOREIGN KEY ([ParamVersionID]) REFERENCES [AD].[ParamVersion] ([ID])
ALTER TABLE [AD].[J_Config_Executable] ADD CONSTRAINT [FK_AD.J_Config_Executable_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [AD].[J_Config_Executable] ADD CONSTRAINT [FK_AD.J_Config_Executable_AD.Executable_ExecutableID] FOREIGN KEY ([ExecutableID]) REFERENCES [AD].[Executable] ([ID])
ALTER TABLE [AD].[J_Executable_PathServer] ADD CONSTRAINT [FK_AD.J_Executable_PathServer_AD.Executable_ExecutableID] FOREIGN KEY ([ExecutableID]) REFERENCES [AD].[Executable] ([ID])
ALTER TABLE [AD].[J_Executable_PathServer] ADD CONSTRAINT [FK_AD.J_Executable_PathServer_AD.PathServer_PathServerID] FOREIGN KEY ([PathServerID]) REFERENCES [AD].[PathServer] ([ID])
ALTER TABLE [AD].[J_PathServer_PathShare] ADD CONSTRAINT [FK_AD.J_PathServer_PathShare_AD.PathServer_PathServerID] FOREIGN KEY ([PathServerID]) REFERENCES [AD].[PathServer] ([ID])
ALTER TABLE [AD].[J_PathServer_PathShare] ADD CONSTRAINT [FK_AD.J_PathServer_PathShare_AD.PathShare_PathShareID] FOREIGN KEY ([PathShareID]) REFERENCES [AD].[PathShare] ([ID])
ALTER TABLE [AD].[J_Executable_PrimaryFunction] ADD CONSTRAINT [FK_AD.J_Executable_PrimaryFunction_AD.Executable_ExecutableID] FOREIGN KEY ([ExecutableID]) REFERENCES [AD].[Executable] ([ID])
ALTER TABLE [AD].[J_Executable_PrimaryFunction] ADD CONSTRAINT [FK_AD.J_Executable_PrimaryFunction_AD.PrimaryFunction_PrimaryFunctionID] FOREIGN KEY ([PrimaryFunctionID]) REFERENCES [AD].[PrimaryFunction] ([ID])
ALTER TABLE [AD].[J_Config_JPlanLOB] ADD CONSTRAINT [FK_AD.J_Config_JPlanLOB_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [AD].[J_Config_JPlanLOB] ADD CONSTRAINT [FK_AD.J_Config_JPlanLOB_AD.J_Plan_LOB_JPlanLOBID] FOREIGN KEY ([JPlanLOBID]) REFERENCES [AD].[J_Plan_LOB] ([ID])
ALTER TABLE [AD].[J_Plan_LOB] ADD CONSTRAINT [FK_AD.J_Plan_LOB_AD.LineOfBusiness_LineOfBusinessID] FOREIGN KEY ([LineOfBusinessID]) REFERENCES [AD].[LineOfBusiness] ([ID])
ALTER TABLE [AD].[J_Plan_LOB] ADD CONSTRAINT [FK_AD.J_Plan_LOB_AD.Plan_planID] FOREIGN KEY ([planID]) REFERENCES [AD].[Plan] ([ID])
ALTER TABLE [AD].[J_App_Plan] ADD CONSTRAINT [FK_AD.J_App_Plan_AD.App_AppID] FOREIGN KEY ([AppID]) REFERENCES [AD].[App] ([ID])
ALTER TABLE [AD].[J_App_Plan] ADD CONSTRAINT [FK_AD.J_App_Plan_AD.Plan_PlanID] FOREIGN KEY ([PlanID]) REFERENCES [AD].[Plan] ([ID])
ALTER TABLE [AD].[J_Config_Plan] ADD CONSTRAINT [FK_AD.J_Config_Plan_AD.Config_ConfigID] FOREIGN KEY ([ConfigID]) REFERENCES [AD].[Config] ([ID])
ALTER TABLE [AD].[J_Config_Plan] ADD CONSTRAINT [FK_AD.J_Config_Plan_AD.Plan_PlanID] FOREIGN KEY ([PlanID]) REFERENCES [AD].[Plan] ([ID])
CREATE TABLE [AD].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_AD.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [AD].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201701180225518_Initial', N'MainModel',  0x1F8B0800000000000400ED7D5B73DCB892E6FB46EC7F50E86966E28CCAAA3E7D628F439E09B56577A8C76ECB96ED336F0AAA0A92D853C5AA26595A2B36F697EDC3FEA4FD0BCB3B415C1324C04B31A323DA2A024824C02F3F242E4CFCBFFFF37F2FFEFDC77673F24CC2C8DF056F4ECFCF5E9D9E9060B55BFBC1E39BD343FCF0AFFFE3F4DFFFEDBFFFB78B77EBED8F93EF65BE9FD27C49C9207A73FA14C7FBD78B45B47A225B2F3ADBFAAB7017ED1EE2B3D56EBBF0D6BBC5F2D5ABBF2FCECF172411719AC83A39B9F87208627F4BB21FC9CFB7BB6045F6F1C1DB7CDCADC9262A9E2729B799D493DFBD2D89F6DE8ABC397DBBDBEEBDE0E5ECEAFAFB5952EEC17FFCF8189E5D79B177F68578EBD393CB8DEF256ADD92CDC3E9891704BBD88B13A55F7F8BC86D1CEE82C7DB7DF2C0DB7C7DD99324DF83B78948D198D7757668BB5E2DD3762DEA82A5A8D5218A775B4381E73F151DB5608BB7EAEED3AA2393AE7C977479FC92B63AEBCE37A797FBFDE9095BCFEBB79B30CD23EDE824B31F645D7D9608F8CB892ADB5F2AC424C04AFF4BB21F36F121246F027288436FF397939BC3FDC65FFD0779F9BAFB2F12BC090E9B0DAD76A27892D678903CBA09777B12C62F5FC843D198EBABD39345B3DC822D5815A3CAE46DFDF5E027C8F93DA9DBBBDF900A140B75F1AFD71F4A01D741FCD3D25882777F1F9612126C2636777AF2D1FBF181048FF1536265A727EFFD1F645DFE2E647E0BFCC4409322717820C675AE49B40AFD7D8E2969D5E7AF5EB9A8FCB05F7B31B9FA5AD69C982DF99A10414B418949ABFA6F69A70DBF7BCFFE63661C8C1239DCA3D3932F6493A5474FFE3E679EC214EE321B7B1FEEB65F769BAA44FAF4EEAB173E9238D17EC725DDEE0EE1CA408F773FC8EA10A74D10EB52A7B3FA3453389D986453BD7E4B0ADD6CBC40AC5599CAEA443FE7346A248AF4B958D43CA764BFBCBFBB1160FE74CE1CF8C7EEBE96202341AA736FE35D487E25010913F35DDF78714CC26468BC5E93ECFDE8AA4BDE7A47856FBCD0DB166FA4A3A8CB55EC3F9352C42FBB04A05E602CE5AAE0E35D70FBB40B63159DFDEC8292EBFADFA7B0EB7D48200F0F16C68338DC5A1B558E6578CA78B5CDD054F2AA60682AF9D86C88CC8CEEEADDF773853E559EBB929959DDD81C922194CB663A6C35C52C013A2FB53A2F613A2F2DE87CF3E5D3954EE7348F5A672A874A673A5B079D3F5F6AA19164516B5C6750294CE5EAA4AF161649169DBE105050B93AE87BFBF5576D07A779D41A5339542AD3D9BAE9ACEDE4348F56674837D3D98CDDDCBC9CCE0BE7B2091497E5E1FD6059C696CAFF963AD51F3EFDA254BDCC24579CC921539BCDD65269C5DCA2CE2057964A95294A67315592F63455E370331F3720D3C9B291B9914734441BCE8AA8F1BAFBF4A81236E77952DEDA8E42C6E42AE76F953CF8811F779F4AF951F2763E059B97AEB3A9676F7320EE7D6E51AD89B7EF3D9204E2DB642E1B599848CD69AE5292B4CDE981982CA5B308235EAF910FD2992B23579EC9AA6D059BBF13FD737A76A17F46D89CE9DFE2AA53EEAE923F0F2458554CD76EFB2113950AE8A8D2B317FA69F6F49782437E76C2BD7E1093604DD6DF2275DDB89F012461B3C59A0ECCA65BBE9131A1CB751C7073B8ACDA951D8BCD012FF1C09A23CAAA5DF4B1D81CE0EA0FAC31829CBAF520AB4D012D0C419B62843251F63ED68C608D1165D5AE22D96D0E6C3909DC1CA39723CCDF6A49211D1E840D61A553B9EB264833718EA63C672B8F59B51222AC4AB024A2CA07D3DFC122C9D2E622C972CE5E322E92E022092E9258582431D88F542F2F705B27EE16493AF9DEBA56585D24E11C714BF49F0A43FA47FA974843FA47FA07D0BFD9D10E05718A4E8038A2FFAE6B15BA56B8A2FF6CE1C212FB27B290FC91FC25D290FC91FC01E46F72484E419A82A3748E98BFDBBAAEA609EE68DFDE9A4F220B691F695F220D691F691F44FBF0B3C64ACEEC6BBDA7DB1E98A609AE683FDF10B3C4FBA930247E247E8934247E247E00F19B7DB3A1E04DD1A71D8EB8BFEB99015D2B1CD2BF3DB73F1586F48FF42F9186F48FF40FA37F83CFDFD4C4D997EBDFF58C95AE1556E99F3A42D5F9247C9A79CE941F67DD28670127D10D8E8B15186C8BBF7DEC780C903DC3A83F30D8DEB2AA237E9D8DAB903467FB7A2E3BB3806702CE8D39CE313C549FE1A164075D05C9B28051C233B050150D2247C954956451C592EAA4727B0E343D500C62425533C06458F74D372AACE5CC9908BB07890A92FFFFE3DD8F9804919A07973FFFEDE862F4D1B066FB714EF42D0B9F048EA6C7CE5424C1F6A0FAB40E3342B38B2AD408F5A73EDC08F5A771F48EBAEC8D173FDD9230755DC48D116595354893976F94AE40978685FED60B5FDE1F82957C9492E70734515A40D94E7929EBE14D3AF80E0ACBB1F7150F87E96E632F276ECE43B095E5DDBA2B3B0A3AAE7149B134D829C4146B74DA5854E6930C7703965E790141B6A30DD1A8D1913A4422E74C1FD62CBFEE4EA410038BB4E97571960975D3E08E486D85E0C6D085748DA1FE843586FAB3E3EE831D7E4152498B47454FF63D99DF27BD6FA1D639F153E719624BF386CD10057C006E585D36FBEBC90B65D378414E59B3D459F95669F2775ACA1409EFE81D0924CE99C7ACF934556FA26F64E04ED8B34BCE9900DAB1514B72FB336A485E04D28EEC2F7833B2BFBA7B44DD29057924F587F27E447768F49464C36B30346AB8CFD0E080CE2B2ACDF5697BCB2A4DB973367B7B6B2BCD3E4527A2DD028BC58D1FD5EA847EBB08EC56B0366AD640AE38A895EC6F83A6B2BFBB392036090A59A92A3EDE9B10DD442D3E2EBAB3B8F16D871E0CB6C065CCD2654FB9BCDFC4CA8E72296CCEF460653FB9EC48F4548C7693CD6FFD916CC6CA2E07824F834AAB02285B6796AB5BFDA153B8FAA3DBCEB11D56403A38DD275DD051C4073F209F1E7E3944C9BF518494C01F3434BB12CCC8DE74D78271860955BDF956254B24856C362FBD3622CC2258E914E7339E51C9EF312B6B28B20874CC52E4AAE5C99D788BEDA82EECD59435670ED3CC78CE9D4C3BB2290F4E763AAEC6AADC90F6ECC22FB9AA59A8DDFAC5C6EBBA68914840BB95A2EFAF68B62335DBCBFD5E31D016A977B98150D64A27F036DA48757A8D29A71893A6BCC2B49D7A20A2D37926525A6B3A2EED665445F7779C511552E6CC6ADDBF99BBE93E273B2EC2917D3F567106F3F518FD9CF7E7E9C436F38B2EAC2755A6C13B5D164C2D18712D68CE766C65A1144DD97891147ED3B864AD5174197977FB36F11F548A7537F484322E0F6B3FEE66E5A594D19878A64D1B3BAF0AE64D975DE04A75D36DBC0BC9AF2420616210EB1B2F8E49182425D724EB6B9D215D7FBDFEA0ABAD873DDA3E3F7CD7B83CE91BB0C050999C544615ABED256E29E536E5B9DBF441EF21DB6C7DE9DF1F9BB7A2A19C2A2C30112508C9C8988CFED8DDEBAB733E635104BA30556615FBCF3501B40CD67855B0DF2EB87DDA85B1F294AC0502ACAB7B9F02CE35DF8E295A2772FF6CB9BFBC14F0DCDA20D09488A381F16880C18095D2C6160C185049CFB17F91CE674FE74BEB74BE443A473A473A473A473AEF99CED33B5BEDD2792511E91CE91CE91CE91CE9BC3F3AFF7C6979ADA51488648E648E648E648E64DE27995B5E69290522992399239923992399F747E6E97DA976D9BC9288748E748E748E748E74DE2B9D5B76CE2B8948E748E748E748E748E78EE9BC0E546681C9196148E2C6243EC2BB24D5D5F5F9054DFB9B2291DA66486D4CA4450BFC26928824674C72A3F9B00F18C704B905B9451209C402A93444219B0CE03259883F8024304712602FFDB4C1064299480BC32C8759BBBC02F961BEFC504620B3C70E0D89C80DC37083A5F0EEC80CF365065B3308461A32C2308C80F3086483566C20BAF6D7062F48E52243183384BD7BEC6CDDA78B5C3173AEB0BEBFA1118EAC31206B58BDFD12A9638ED421B853D70669C8C4225D18D38535DFA07A1348144814E644616FC112572A3B11C2D86E9E433E98211F34116481150402911B6C1FA302DEE80638478527A89054EC9FCE6C7EDD61E374A64022D24A8B3988B530E5F9375DE4CF03095644D70280A8544047959EBDD04FB36B4CDB0AAFF9414C8235597F8BD45521872287B6E7D0F4B72DF6AC64216F1AF3664C198DC81DB37185025AF95CADBC30385B864E8B435B37B6F5E7BC4B2A402470D898E3176F9F42E670CC1C164F93E01192AEAC1165BDA7C282954F72F7C98B725E09F2C95CF9C4D2B631EE15776593B4F3904C904CA64A26760EBFE3A977673B487FC50D24E48FB1F0C76514ED567E06FB4283E2F6F2CBFD9EB1D277C1FA24BF53BCCE525F379EEB9A5E575EDE9FFE3121027F9F987E52ED9BD37FE15A2E9457DE4E4EC94B3561849D73C2129E20616A9EDE26911625CCE307314F2A7EB0F2F7DE465A2F534248443C07A5DD5BC96653AEC83EDDAE086269E7412A2D3EC7E7EBADC433ACA8EB908B05F5EA2188A8EEC72CEEB7D7A083CD2E474A95D31C325C2502F888E168154132357A4393ACB3210AD4DF688D005C4B33702DC1E05AB607D7721CE062D5E81D5C6C674F105CCC590630CA98728EE1C6D626C01DDB907E0028516C00244A5E08441341FCD3A1B199DE6B67407C54760D12D39C2D9148573220F109D4E8176E82CE9E16F1650D68417CA2728EE13646E253293600128F8BF83E5F9ACC26EADC1A1C26195BC290AA6240D2E3B5E817697C474F8BF252FD5B309EA09853A08D91EE147AF58FC163233B93D96D9D5B8BC1B6930DAA8A41C96ED8992DDFD15323BB56F35A4131A7401B27D98D644EAB78191325BBF4063103B6A3B26B5098E66C0943BA9201094FA046BF681374F6B4282F6B400BCE1395730CB731D29E4AB101907874C467E2E651D9F5486C3BFED2950C4B7CC3BA7A82CE9E1CF1B572F644E51CC36DA4C43712874FF542A6447C6C13AACFDDA4A8949610E1518310151EE5F5C890989F50728241AD323DA04FDBF160DC95DF0B0F82B83AF49BF28852339B085B750E135831727B3DAE24AEBB07E8883B1352F190C796B83B1F746E99AC80083D5C5E1310492BEADB39D329D203B6749D3E01078D6F02050B3806A83FDD038EFA53003A792DCE80C72B3408F8F8970051A3198F7418108AA2528380A8292804A3A88C112075950E024AA0527D0013F852A6024E4130D33B0A395298A8CB09A1292862844C4D95C2D983CC046C0113A6531FB884BD10D854820ECA3A325866A8318748F657AFA0CCFE926152548D7348D21A0D8A48FA6580015906F71DD1180EE1494DC11EC7F0A1A912A8D46063F874C9527A8B81A997292DAD8369B3605BACCAAB1FDAE9D46AD6336AB52F6A2AEEA7BC4D2CA65A0088FD3D0488D9DF22EA5557EC1ECE121D87C5B4E4E5813899BF3B64E815F16C79BEF8221FB2344EE777B246DEA840B6F1522ACC54F1EAECCCFEC2B948A17E57D0457D0EDE7AA102C88E67BF4F073855A13E76FD5AE2CFE5DE5FFF0884BC84C9C090DA49CFBE7A6E71244254CEF137EA633C12A152AC0754025F081898233812C15C260DDC7464B22B7680CA9C2DF67FD84A06DA6E94A8D1DF7E8FA4B3210A0CBDD5586ADEBCEB43B15429CC2F5EA36C812B897801B018855DAD4A2AF5E9653952D9E1100DF89B858681DAE57E9F364679CC86CE240455916E042A5A66AF076C4435F78119412742AA1DF4704DA973F676B5AF32FB9F6D7C64FF1339510281B61142D7DD2744E88E047945C54D6743BA4299CE303788CAAA70818C11C30B1FC8F511A8D09FDB23E8DC29B83C94F26AB261323A02D010AC23A9BE67E84C8B7B4A472CFD17E02067D9ACFBC5B9D49ED122ACBC4FDFB7D197908AF78322859914562F1C3A9BAEFE703B69AFFE10C04926DFD1C49D556580A93BDBE91015CA3203AF5BC256CD0579AD465B1DC1D2B84293DED61EA7B410FE2E0BE19B94899312246C80EAE3639806EE4E13C90F51F0EF6F1129E27F474580601620A9F05B129751ACD369F6BB2A68303DF9E6A0D52CB92A20C9152EB10A2A5FACE73E9F4B05518BF21A897B76599D93C82DBC1BE9B8D4EAB8349198C7515349CC73C02566818A5402B30C26F2344DCE32C0E5E59FD9AB04E6398C246A54CC734090937F1928C64C9E06915271A9585095AC9145A83D794E12BD61AF91F307FF4109274EF0D1894EAAF854212F599C4FDB8F0A910672FE109EC7E595146683E828110897F287E2C490B233D9CC603429E49B0AFD83757A65C0AA73685F985C1454C686D981E024B15B14BA179D4DE1F8CECA1EEBDA53AD7BF2EDA99260BD2C1343A76A2425437D71658868BC2F9240D42B13F3964E351BFED5222B1FA08DEC254CF6D258763A3C036453D98C867280E83A97D1A00E926CDE1FE9E00D104D65331BE861B2817AD7942813FB8ECD614CB232C90CD3C2C497642213FA5B33DDD42F908A9564341B1C34D2996C704AD4C835E80F91A72295AEC8DC7AC48754D60A3702F7465A973C2F70E8964B3679C3CD415C26F3832897D91C516AA1C26CD05984522A95C1603EA114D9CC03F6AEE532CD30BDD7C1CA104B7B8561CB2D9A5A4DA94515AB3FD97A0695A13170F0471F440B69F4D1874AE17A15845B17120A2817E028019E60A965D16C0BB89DF509BB720D46D6662EA74E7DB680BC2FA8151D6DA77052051D24EEE1CE7DB404F79138D09BA2355CA837691F712B1310A97DF611B760A6EF2CE5295D65FB64E7742D759FEC602E259E5B41B4D9A1F4FD1FEA7E94DE14226B9FE8AE1071AF89961421527B029DF01A0B4067B5029DF2EE0B4BDD3734E8A8BB17D4DD28BBA441D63AC1350DE22E13AC390364F68437D11D02FA7E6A8536D5BD03567A6E78A801C75459887C79E38023AA603B0220B337A8990EA7DA98EFAAC69942CDA8E786861A1D775CDD87D208E5B2E68962948BFB4CB4570591DA13DE84E1B3019DD50A71CA98DB96BA6F04A003129C343AB4A27D408A136D6742A4F6073A5396D3473B56B6CF187466DD3708E8D84AA92D68BE2BE599E5AD949611759FA67D40C1B28E13EEAC9B7719133056D04FAA90B28D364882CA528A13E94EB94A90B3C51F690854412FC0C2A5369AA10D984A354870DC40D141DA08A92ED84A19C713D463B240389AB60922E058EC3941801B1062DBF4A02E08A5A8178D025736DB0A0D5D49F726E4E089592DCE7B55133D51D4A92601179BAD05865CA4BB14704CC6A80EE188203DDC63B34373D54DFA938F14086C6A2356A09BDE6C0407643B53780CC996C96BD06914E70E608C1A7C5A32F93E110A0AB6A6E95A60943669CBF571DA249DAC3E2ED6A2BE3EC72D4D8030B33E5786178376842CC098D3DE97451413BE02E9C9C04EEE7AF358ACD26F6F6405F9DD74093B9E7C43A26C52233BE56B692AA8E82D657EC3799BA2DF3ACF09FBEB4176A7D9784BB3E5929832F490A55DF341562724A16FE4532765901CD1B4461626879F2EC98E0543A43A9D644A22B8089D4E40B017C61554877B69B89990FED1C477A1E4B1A7ABBB77141D7F44D43BD2F824CD26882294D0FD20396E2D17E26EB5A6115343D564FE3B78B1BA8DCFE05B37BAF1C53B4D20A2B3E5AD59838E1221670C692C09915D8BA249F04CA1EF085E5A0FCB506A24B07960DA4BF1D0A2275CA3A2F9FDBE8A1E055FF88B59ACF98D7F6B326C7ED4EFCC20F80FD20103A9F8E375E5A0C77DBE6E6930E5BE570774786B2F4EEBFE8AB2E9DC29ADB32BB679AD247BAEEDC52297F1B6FC26B84ABB58DCAE9EC8D62B1E5C2C922C2BB28F0FDEE6E36E4D365199F03119BCFCE031AA4B164F4E6EF7DE2A6DC1BFDE9E9EFCD86E82E8CDE9531CEF5F2F1651263A3ADBFAAB7017ED1EE2B3D56EBBF0D6BBC5F2D5ABBF2FCECF17DB5CC662D5304CF60BE6AAA678177A8F84494D3B6F4DDEFB61145F79C91CCB8B92DE7FBBDE0AB2A57DCC7C01DDECC2AAABCB2AEB8F9CF977579E2C2EF3A67F9760DBEEBDE0E5ECEAFAFB5955EB59AADD595AF799C017A93BF47DD2C62D09E2ACB9847AF9C25249B9DB95B7F1C2F2D373EAABF7B7BBCD611BC8BF825794FE7AFD81299F3D814BF0EEEFC3A684FC095CC29A44ABD0DFE7930E5A5023012EEFB05F7B31B9FADA14563F3595F42D22A14856FE9C9776B1605E308BA80507A91E30B75BFB0FFE2AE38C7279465C7996FD3A481A1797194FCA3F4A0D1833CCA925ADF92E2F2882AF0AC0191D929884F5A382FC92DA0E611A1D41FCDED4B866C5660FBB09CEC1CD08CE1F7613DC003B23BF91D6AD9ADA0C983AEA041B15E4B621AC224F825572B168025194E55B26B50554F382085584AA1DA8368128CA724536A41554F38236A1FA29F41FFDC0DBC81AD3545534C6810714DD7857A6D7DE18C8575BC966FDED874EF14202C063931574E3B4FDB1BB6705148FE0328A60B1B40C49FC58B90C7A12C30A63D30C344BA0F44C18D58A67702957050F2533A4A75DE29034C471896DE4BE3F6C3632B1791A5C2A797860FDD5E2115C461C6E5919C523749D3BDB7F0FDE73B132301207BA2003466EF1B49B68961A983AD8E48EED2898836D48F1B89B708E47985AB8745BD5E5FC22AD2D4FEE5659C13F4C1DC5D36EA20B5A6244174FE7E4339EA48112A3C326FEC50FD6B5676338BEBB9A23158434926952D1038CDCE229721D721D72DDA8B9CED9FCB8A0299C22CBA6C8F58921FBBE7275C2A8F5A45921C1CDEC39AF9695513F9DDEAC8D39DC259C8AAB6F4293CBF6A32FE4E153B07969CAA41EC3653D7B9B0333B12F1E19CA4878C77B240942535C4502896C069C01DBB3EADEA6C2F5E9C591CC896B8E6044D70973F44304FC2272739B39BA5549D10F531595D2AD8A829918F1C5530BA2598A1255C4E69997BFE8745A5B93CB48E6B7482E482E482EBA0AA63119ADC90567A5FCAC94FDD0C4A6FFAAF90007302BD54A70332B75B3979A8727217F1E48B02202A17592A1CCF48D08D52C134C6674A19F7E3097FE62A772748AC19C3588D38B76D6DF2246602301E784F66CAA873921FB05DB48E684BD2EF033362BAAAB4EB5505569CCA28ACAB4AEDE0A6DE29C9B42277674EA68D367DD3A3A6D5E6E90A339166BAC239963A1B1A2B14ED8581DCD595863C5398B6E276DE970278D936DBC932690803B693019B893863B69540EC756DDFB4EDA722CB3265CECC6C56E5CECD65530F6591E4B2E2399E521B920B920B9E82A18FBAC9425179C952A67A5D97D438EFC57916CB359A95802CE4A613270568AB3522A8763ABEE77569ADD7D86B352741CD1719C9BE3E87E569A910BCE4A915C905CE6462EEE67A519B9E0AC54392B4D2F2675E4BE0A449BCD498502704A0A938153529C925239DCDA74BF33D2F486649C90A2CF883EE3DC7C46F713D2945B703E8ADC82DC32376E713F1F4DB905A7A39AE9A8B393BB02D1A6D3513CB78BD351A80C9C8EF6321D1DC1B1DD44099C8EA2CB882EE3EC5CC63EA6A3786817B905B9657EDCD2C77414CFEC6AA6A3B75F7F75B63D2A926D3621154BC019294C06CE4871464AE5706CD5FD4E49532D704E8A7E23FA8DB3F31BDDCF493372C14929920B92CBDCC8C5FDA43423179C95EA66A5CE764945B28D67A5B84F8AB352A80C9C95F6332B1DC14669AA05CE4AD17144C771768E632FB352DC2A45724172991FB9F4322BC5BD52E94D21A94CFB778488A40266A28AB26EE6A0715A5773D2973DC1798A8DB7DDD7BD1569FD63999BE4F86147E0ECE1BC88DDE5DD07D90B1F89BF882FBC78E12EE3E7672F1CC770C9185EB4C7FE302E110C1DC9A5C5DD0CE6CF4575CD65C8F2215CCE9A44ABD0DFC79CAC4602BA089690D4979750A8301647A102263B272C9F7713DFC02A5345236D5E83944BAFA404D8481C1304D8100073E90595004347887784C80FB23AC4E9155956DDA07752B100274855D88D0B74B9DFB3028A47701941F2FF7FBCFB119380F7A6D8B4E19C2ADA20841BED541ABA6A56D0DE83A3562B301637AD301F466EF1B49B68D698983AD8E4490CD7ACE989F688A8E479F9068E9C4FCA6846E27AA2D1A0D18CDCA1A68C06DD69DE9DFE23770FE40E41273FE3379D7480730D90E1C6C7B6776EB5D69D95D64C41FFD526AE7A7063393DC6E2CD3A3FDCD4042E534933715EC39823DF8F47DA485C4044DA91394C3CD2D06F12F84D75FFDC78F1D32D099F937767758C83D400F19F6072DCF850F63D9FBA0DFC6A209D82BE946D9CF5E14F8974198B4FD5DB40D40432B7484027CE6BC473E55B09513712FF0A513734EA5CF95942D4A1AF253AFBE6C4C1EAE455F5EF4A45796D0D09E533B894B42F9B32F227E82E59414D2F67DCC6E61895286404978FBB09CFE1C988CE1FCE6B187276A26D6C1E0FC269C25E0DBA3279B26CD9A8EE9FECAF272FB4BCE306A800B2680412E3C6D1B1BFC253354128B04C4017C832C6FA583012A83216B7A8B7097503C5A27ACAB4798D70AE568B44901B89EB84903B4AA74A083974AF242B45D67DAA2E8E54EFDE539455D65C25CA1FE122118F2F978B4403BA45A3F3850A08B253FAFC29CEE8C7ECEF8CCEC9412C4DD69141EF254B069C290AFDAD17BE946A383B58A4AEC6F074914ED8648E18351BC22D1AF1C9E81839C15ECF278E9A0A8DC575EAEF00088F6B7666CFE798D7B0D8C30124068423F1B91084E301610FE7911810A2B3A68A43E1C449EBEE990DE48E79F7F78C43923F192E82C4CC5DAE71F8592375AE726C3262F38793F8A27C6A6397AB35AA717A4D88AE7ED1E56AD50ADDA13A59B676950F3DBFDD6CBCE0C3A75F5C441190C986AC52E924B8F185EC451028356765D1CFD123B287A7FE6207945A8CC52372FE3D370D59A60A3A695E2397DBA80115C646E21721C686C098DB780115C6D03B121DFB76E11675F0877A7684F64975AC84F2195CCA073F209F1E7E3944C9BF51C4CAE353D121B280A45E0E718FCB052A91C99E03291E7713CEC394A986CF30AF61CAD9B1ED71F94008B263F485D009923B419B06E6ACBA421F94A2010E914EC0A8F7CA04BB64E8FC58C44E0F2E505389B138426EF72FC43B17731B891CB93B0CA046E2F420A026EBDA3080420747F0F559E2FCD93D0424100839F9232C862E0C5CD2C45C18194EFA38D793548DEECA7C46175707785218A193321B18B93AA993C2085D13C106D4E57E2F1A25BA6D1B48844236A0A445DDB8299716EECBBB116C62DD186F62CDDC555161A68FADA6A2FAB1B82C97EE2ED0BA116F30DC58D96098DA78E36A53A984D3485C1784D3A4DD970A4EE8C2484F18DBF762E472218E8CAAB41B5FC6DEA962F468DCE3A7BF93C463F26B9C9FF0C4E1A8AEC2F1E9E131393888AB3E71E5F6C4307A3A124F27F9717958FB1C8B771AA62E2542013E8EBCA8741E9266E7165CCA877087E0FAEBF507C655CA9E4CF973F4AC1B586FA97A6828277DFF0249F9634359B72939DCA60F0412E94483F7D7C9D19DBA63D9D2FC5799F5DA6780B772B90012509676CD037FECEE5929C5A39E9780D371A71869B889139366A05932C43CB346573C834BB92AE86817DC3EED922940431C97D846EEFBC36623139BA7C1A5928707D6B08B47701971B86565148F908D918DADB27166DC57E4F9DC152DE715BCFB2EAE00CCCF3A31AE89DADEDAD45808A278F30F7EE0C732D66F26C365FBD117F2F029D8BC3465528FE1B29EBDCD81A18AE291A18CC4FEBC4792A03685592490C86640B245B27542B64BD7642BAEC0986C6562906C916C3532906C916C4740B6375F3E5D39255B69056664AB1083648B64AB9181648B643B02B2FD7CE976154126DF8C6AE5529069916935329069916947C1B46E971064F24D9916171090699169C1B2906947C7B4B75F7F75EBD44A2B30E35A8518245B245B8D0C245B24DB7190AD5BBF565A8131D9A2678B648B640B9685643B0EB2AD2F77B3CFB3EFD4B20114AB95E09A5D6D1CA50D92FFFFE3DD8F98041177B29E4D1BEEB0BEA303BFC83FC83F59B2967FCA0F90ECF31073AB555B32828971CD48F8990F5816DAF8386CBC0CC964DFB27F53490698B4A6FC14BC0B3B910DD086D186F364754C128D436E23BC44F7590354D07496669AF7CED3D29A2968F068F0760DBEBCE7C399B92B2B801BBB46CC744CDDEEFDA768E668E679B2DACC1DB9E71AE170F31ED0491F5B1032346934E93C5966D2B54F78E3C54FB7247C26A103E306570331730361AE0DDEBEB35D37895F59A753900490041C900060DDDA1A13D8596A379638414E68B68B23063E19D901D9C1163BD4E34EF6D79317BA58D083D6026104B82CD75C607F34AF5A24145826A0FDA3FD5BB37F67AB7A5D97F3865DC7DB0BA6E87BE3293A7FE7342D8F4F45CB46CBB664D9CDABA7EDDBF707BD7C809583A4B8B6F5715CE888168D169D274B2C7ADF3CEFEEE0781CA002804DC3C4B877CE5D1C63CD3FF2207F1E48B02202A17592A1CCF42D09D52C134C3E2508FD741982B7D8668AC1C712414C8235592706C17C2E412720D521D5D9A4BA54A62392938A86D29B42806B628B39BCC76DA08EE607283D67F32BC6474716A8920E3542B50CD776F89CD7CE8CB0E5433C858FD63D5AEB767716A0FB0180C177FDA3ACF2A698F299C1FA61D20C66F5307B82768C766CD38EDD6CD875DEA51B7A6B2E4AEB666C387F84268C263C1E137672DAB6CB31DB01CFD7E2323CDAEC686CB64C4CEC2BF6FC80846C96AAF6E249F53B2A1FA4A6E53D928FBB35D94475B9FC46D0ACE5D1DE5B11E9A5A1A72749373DFB6B12BE39BD7D8962B2CD6DFCF6CFCDDB8D4FD23B4CCB0C1FBDC07F2051FC75F75F247873BA7C75BE3C3DB9DCF85E9414259B87D3931FDB4D10BD5E1DA278B7F582601767777DBE397D8AE3FDEBC522CA6A8CCEB6FE2ADC45BB87F86CB5DB2EBCF56E91C8FA69717EBE20EBED822D5E88054979F5F7524A14AD3734BB505C57E27DBF6FD2CFC57F9017F6ED9618FA421E4E64F0BD58B0052F042690D69C802DF0FF3C90A437136D1EFC1472BF1F369B74B9FCCDE983B7E157B83951D93D9DB9303F7D3B86E573B6CBCB07CF5EB84A1C96D3938FDE8F0F24788C9FDE9CFE642CB2B184A0907CFEEA95B1ECDAD073C1E9AFD84F09A895A0DCCA153A2E752AD2F6AE84573E664E1061C5059014C4B2E1FB5792F053D285EBC4EB8E499858F5755647FC625C43F1D5B94C5F96005E5F076BF2E3CDE9FFCA8ABF3EB9FECFBB4CC25F4E3E85092DBD3E7975F2BF8D756077E73A28D314D549ABF276CA5C9B7BDFDCBEB90B295560FFB983F8FC624ACBE65E4480EB68EB450C382B8C315DEAA9AE2C9C2007D5DFBB75B0CB5248278B1C132205B108BBD2162DAD533F51310DDB935711D0B06924FFB4F57EFC733B516C2443385BC5211F59F178088279F51324085BC3F7EF57FF79F7EDF7EBCFDFDE31C3F85DE3A44D651AE77F39B98EDE6E12A92424EBD727EF5365D367DFB2AA5F9F7C4D80D3D61DA9CFF550CE97ED162C5DB6A03C47D4959672399D08A9790C4961563F9BBB298D13494AD1F39BF15497774E9055D0ED905A36BA1DE876582488F4C249240824082408240821417CBEC4750BE407E407E407193FE00403F901F901F941CC0FE9857448104810481048103282400F02090209020982DD19CD4ECE4E8F1AE2ECC0AFEA4D9A9FF799F89B2C364327F832AB6F3C737921F136467BC14579E71BD778F85304BE3A4CE704A1D7F178660AC24CC45DFABBBE6ED0391403AF79BB21FBA63B2B0E3E3AD13863F9B751D954EFE75E8FDB5FE02EFF99A0BD779F5264E34E562A51DBB99D376320DBD5D9D5E9A809235C142B7F822877891A77A702E908BF8874D7338609C3BB0C1ED1C6E929A60CB988BBF4FB737364777479F28FDE2D2B6FC15F3B72EF4510E67C82D87749934EA9BD8CB58ECCDE03B34F14DC4544912ED4984A982AADF3BA23AB1B78ECCD7B5D2608FF49BAEDFC6D3AC8F08E197EF2401F3030438B2FA0A68B14E606DF0922656AEB75F45DC2C883AE677493857579F1CD3440CD5FAB83D0760BED668F4F10E0DA11FEDC7C1C2E22CFE1E05EB88109871C2332FE8AC0E8382E5EEEF713058785E3183D4E7D9D0CE238184A66311385F4D4663088EA7E509D509D202C300CD29258C07A5C5705F3263A8978D86FD44EC8F276CB336610D1551CE38EF0A3A218E792623F7869D37B5CF0E22E606E4B8CB6F61CE0720C0D97176CF859CD719A2E1F0ED5AEFFE6E8FCA6A99203061E8520BA7DDC5188F4317DCA84EC394FF6ACC2B51E278DEA5DFE797C7E38DE8F0721A6D1C3B783C87FF3E6BF25F21FF21FF21FF2DF1CF92F0D8B89FC87FC87FC87FC3747FEFB7C89D35FA43FA43FA4BF99D21FCE7E91FE90FE90FE66497F69CC56E43FE43FE43FE4BF99F21FFA7FC87FC87FC87FF3E1BFFA03FFE3A43EBBC7FF024F1DE3B25BCC0B878782CDCF2D225D205D68033D1C27670C77DCFF671CB1D10481DF521EA7ED593EAEAFF9720C0F87A3B1A98D8D0D307D9C56677D810016370CCD0FCD0F627E65581D343E904048C427343D343D88E91DAFA769DDECD0D94493EB6672A2BB1E8ED3F89CF887B040E46886688660339CC372A71B5B84076146834483541BA4E09E8CE33445272318E8AE0B344234428D111EF31A8C2EFAB1A138787862B43BB43BA5DD35A1749CD667189A19BCE38E7BED687CDD8EBB34CF961EA7F5398A69979FA926899060451A0D6823282D6E51B904357E9A5D6B36E62C913491046BB2FE16E92423012101410828FD7D9CD4135318140FFCC6A12AD146666923C5F8759C66F29C37AEAC2324DEC65806469C4693B36872C7BD3D29BBCEBBDBF71DE2EB58BBC944DB9BA5ED1DEF1688E4C265B43CB4BCC12DEF68CFC299DD8086EBAF68714E2CEE328A762B3FBBC3A9A8303FA47977B9DF3336F72E589F7CD9A5E2D3B442995BB27938CB7E7F3C6C627FBFF157492DC99C866B575D3CAFA121A17CD414F22F9C90C4B84998BE126F931489E2D04B40C433811FACFCBDB7A1D465F208F982A78AB4DF2A696CCA15D9A7AB8E41DC6C16A4A6E2932BBEB24A26C358BA765F2CA8170979BFD5E50B7722B5DBBC2CFD1BAFEA1448A3D29C60C0E0E5588141DD1E4895F5C1E8114062390024960A482C8F0C12CB294282D996936283CD47BF562E6D4A685176C078602308CD33347ED210EF7D534A5AA70C2479DAF1504AD69E69514A0689F150CA4068199652C0B01921A57CBEECDD6F4DAA9441244B3A1E3E499B332D3A49E1301E36190429C372091432A3A492DEE73B499572801CD56C276DCED4A8644C739D41903234954C76A29346F3EE9B4BD23A6510C9D38E874DB2F64C8B4E32488C874F0642CBB08C0286CD3829A577F724AD530192A37250B2F64C8E52C6E4A20C8496C129655A5E0AA3C75D75C85D8D1C7AC7BEC64CFE148E960E20B48916BEB96E70D2069A8D0F6E0641481D92C2E5D67F5D4B430AFD78CA4700A876406A1BF218001766B3173783ABB5214F903A7157836FD1049C0D1E1A32FDBB58F6F86162F8D606814A3392D0307011C550EB1F32222D9AB011E73806E8085B3615F808420DDDC99AD1F02A856F59FE6A95E81128D1048F30832367D5E81576C58EA8613097950E9C3432E8F0AD6091C3BD61E96B9D146EC0AF6F50D894A1B146345EF5CE38A31AAF7AE69CD6E3D51848471AAB72509FA7A98A14486CB623F37E98E64DC50592434AD9229A9B14EF5FF3D2A788B0362F7A589809A2B30EBDCE47477150AF037F6F4643A8576EAB84E65B7E757636C655407983DD40C69007D9A850E3D929700292096C19F48895D6BB064303A6F995C2984E3B0CF4A9D9E05F8A4CEBB40373E1509FDB10659DA2D5E53AED38B620AAF640AA1C7A03A2C4423312AB14134C36FA6DB249264B3B2270B84585AABD8ED061020B3EC6F230F028AEE374B9515DD6D17CFBD5C3296F5257AD80D435E81675F99E796D693F827D4BA23734B6570DEEFF3EDF75799BD6906E40F6BE7B7401F8174F3F3F8EA11F0C80A1877D0A028E4D7EB097DF9BE11BBEFA616DBFF4F7D27FE56E5EF7D73E804BD7DB0B3771E4F62360FAEAA58B356FFBDAC63DED337A4B034CFCE87B6C075C4D1A68D511EC584C748DD1C0F3186069B1DC1AA9671E77D74194A8757A72F9F81892472F265518B75F0EFE26BE0EAADFBFFB1B6FEDAF4A19D5F3EBE8ED6EBBDF458D187059E3484CC2F445DF92AD9768BB8A922A379BDDFFBCDEE6AF3951BE0A027DBB7A4A72251998880917952440FCB88FBB759A23E0B0C309F97AFDA1117B105C521254B02A4E058CFB492B4C1DBE5A24330B64AD912A8F8B076EA532249E48AF25A3D6C5A2C489067FDFB29A107F88BF61F0774536E4C8F107EA8BC22B98E770502CC17596C30EE9DD154BFAF6B9DAC2BFF74D98E2AA30EE5D70FBB44BDF29CC907E3610FCFEB0D958240EF2F0D08935E2706B817526405C85B1CE73ECFC6377CF048E463B473B3F663B471F457C0E669ECE4ABD85D059D4D086283820D3B94D7EF4853C7C0A362FEDD8F4D9DB1CB898F7FFB4F57EFCB3A990841CBC4792E06B9BB422B2489F13A3AFDA5EE7E9AFA0BDA2BD4ED35ED1EF101FD89EA7DF617DD293C7F911DDA56C26A20CEAD25921CDFDC9223BFB596FFEEAAB93C5428F885458E399A71380C683C663C178704416792ACB998EC838B3C099C534788CB5D7793A0168AF68AFD3B457F43BB87EC92E5842BF03790C796C123C96D92BFA1D68AF68AFD3B157F43BB87E496F6243B703690C696C1234969A2B7A1D68AE68AE933157743A04DD827B2CC862C862936131DC62417345739D90B9A2D3C1754B76B32B7A1D4863486393A0B1CC5ED1ED407B457B9D8EBDA2DF21EA175CED401E431E9B0E8FE17207DA2BDAEB94EC15FD0E0AF6A9DC997A1C7122006A0FFA9035933187FAB5CF73E09AFD6B47FEA37AA4F83076A61458559B4B0A89B731283DF3189E0DFCCC934B113FB6F083A49C8BA56E309D2725DB0A141924FFFFC7BB1F310922B87D2D7FFEDB40564B1B8395F64F860628C4CF731041C4CF17F138ECE5628BEB5C663FFA595C55AEFB725ED6C543699EC30A42C9019490AF8B9EA9FBE4C68B9F6E4998A83653CEB66C1D757FCECCD884909A277723A41C420A399C45C54C893BCA1A6F71A2BC4F7AD4A2B8C9D8D9ECF91A91641F4948D3C52056F749F657D2E3735D1DB1ECC754DD3933AF4804A879F23602CA19A090BE194CCC94B3A3B4EDE819D9F18C664CD58823DB384286E65789427FEB852F65869952B6EDD5C766A7CECC3792836B9E3C8EE0EA055C48EE427CCC94D1BDFB7B28107F72701C0C70DBD4646C0E591C01E51450C8DC8DC337BFDD6CBCE0C3A75F66CADC164F71953D39331F8981D13CF91A61641946C8D24D34CC949EF749EBAD08FAE007E4D3C32F8728F9378A66665BF3E666C4904D0C21318BC030537A3698A69EEBA794D93C75863354064AF36469849203282159176B40C9E08514AD43DC5FD1AC54F8415E46FC74C10F92713195B8DCEF674CC8B6C251DCD89AD64EC68A2AE0CC938911389D818314DC586D9F310B5BDCB099A13D51F0992717237C2CC167B68CFC2E2915BF242AC49E1F50B85A93F77E18C5575EECDD7B49539ADAE4A56E495CFB04A727F9C35CA95BB27938CB9E522D3AF99A774EF67CA19698BF1B81D0324120B74C0289CE3AF4EADDF773691D548EB2B2BBFC67A3BE2C9BB6D25C58157C5F50299743D0422E8F515397DAA62E9B4D5DB66A2A95F7E6CBA72B75A5798EAAD2FC67B74A3F5F6ADE6996A1AA32FBD5B5464DD76619A81A3B776C7AB390BACA3C475567FEB373A59A76E639E84ADBB534CB955621B3933C4D6621792AA48EEF25F18AABF92EE0E5464D55064D65F5096E415574A2A0223A59530D17C94A509B208FA0D2DFEEF26C7726B58BE2B0883410E7136A4105E5A2F36ADFADA27A4D9D06D588BE8815B557984DD85C2A30029515D25A49DDEA0AE175C8BF41D0BC6036B3F62DB305748DD76A0351C1B456E69C98DCCCEA1C2A23AB73691127AF505D53E6E642AA68EEDD092A623308AA63B3E8DE61A29BE8C5658F456F2B4BD07555B1DA22EAAA2A49D85549EA1DAC8A7A06214780A2A2E2ED83EA4A94BA3CACD3DB95447E76912476B68B44D0402FABA3912AF5BD4D6AAADC6B75956C3669DD6C4633D718A6C412AAC4D25889D4F305284165532B416534729D013AD4B9D42AD4F98C5C699006B03751E73373AD012A50D9D43A5019CD5C6D9812B08EA032823D5559FD5C0EA5CF0AAB95197F65558BB3E9C7739812E5B020AB9D49578E1D77C02A59675C5AB72423CC7537D3A6F42434BA30D920FE8D991ECA77C165D18DB0D0BA459313A9168ACCF0E94C0BCD60E6A22D61E88C431515CC77A42ACAF382274860B534B006E0B9F4A2815536FD6059C5C25C5AAF1A48ACCD154329B10AB3E957200D94486B53564F65502DEC185459ACCE286B6DE6D1ACF340EBD6F106842CB83CD0550065A56AFB62B300E66DD2DA94CC4CA532755C46D16EE57B29B858CFE82EDB38A032341CA22CB5212BD3787DF265576D3A540D106E4234F2373720B22292FD854553657073AA09CB5D2958D6342EA705B505A5B82D11AA389566B9F94B70F397FD347FA968FED241F3B94D1D7D3FB045E44D93EC3B654DD3EC268DA38BD2792C0C21744E8708A1F7B4D8E6E769D69B6F861061915E11D26F177DBE04322895D1213EA8ED47B6ED5992EDA69B814354A2576CF4DB3DC0C185CAE8141952DECC926C37DD1419038F2B7D764FBA280783069DD32136E80D7DB6F5799AF5E69BC14358A4577CF4DE4540F2A073BA4588D43EF234EBCD3746C8C00CD24317319ADD51E74DF8CE9167D6740B7DF4A5EE10D1B1165B5DDAA22BE8E565F1C49CC9616F72CE1F70C98A29CEAA98378FBF154ECE06D2BCB6F9407AC02713204875D00DB478485750F92DBED1A1BB4578E794A66B74659C758FEA6056DE45E21CDDBB497467005D83A097344554F4276C9BBC41CD4E521CE6CAFB4898C16117E51598F4505642D3415CBBA48D1947F7088D4603215D1967181ACED0E43182E1A4242FD80733890FF271BDA639A967B5EBB8CA8CFA8F2DAD409DA2ED9A068FAE3B1B5BDCF41169A57FD8C8AAF1709943DBB57B2B398DDDBBEB28F4FB15FDA0CCEFB233FA9D30B09B59C61B1F032F40F4B035C6C69FD44E39D89C8E261CECB963DAAF961E5E6EE30B15AD610F108B9C2071567953C4079BB396A8CF2B337E90A8272C7641F991B8644EDD48B737A3664F4BE7CDAA1EDA6B562E4FD1AE2C83C2AE5925450AF6DBB4FA289ADE5EE95C8E6C956F2BFDDC6A73A52F93CD63F57DF6D3CC925FD27FD50C94E7B0DA44D724C30C1EB568FD4053E5B5A4FE80C34D793A54E39E89B2B9F4CA6C1C3DBA58E4A5DF965F765769178BFC3C56F120F919EF42EF91A45F8D6FA2ECE9C5E2CB2148BFD9CF7F5D91C87FAC455C243203D2FC92BCCA731D3CEC6EC2DD9E8499E6B446659632B978091F49ECADBDD8BB0C63FFC15BC549F22A1984FD2069EE776F73487DF6ED3D595F079F0EF1FE10274D26DBFBCD0BDD19170B75FD170B4EE78B4FD94D14918D26246AFA69C4824F411A2D605DE9FD3E8F02B0008848BFB8FF9524CFF3771927FF92C7974AD2EFBB0028A8E8BE2BB227411A13E02BD9EE3789B0E85370EB3D9336BA7D8BC807F2E8AD5E92E7CFFE3A5DAF9009D1BF8866B75F5CF9DE6362165121A32E9FFC4C30BCDEFEF8B7FF0F1BC465077C280500 , N'6.1.3-40302')

