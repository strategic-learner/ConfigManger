
use ConfigMgr


GO

--INSERT INTO [AD].[App] 
--	([ID], [ITIL], [abbr], [description], [updateDT], [updateUser]) 
--Select * from
-- (select [ID]= null, [ITIL]= null, [abbr]= null, [description]= null, [updateDT]= null, [updateUser]= null
--Union Select NewID(), 1234, 'xyz', 'xyz some description here', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 4321, '123', '123 some description here', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 0987, 'abc', 'abc some description here', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 7890, 'x12', 'x12 some description here', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 456, 'pro', 'pro some description here', getdate(), 'Data4DesignTimeHelp'
-- ) x
-- where x.ID is not null

GO

--INSERT INTO [AD].[Plan] ([ID], [abbr], [descr], [updateDT], [updateUser])
--Select * from
-- (select [ID]= null, [abbr]= null, [descr]= null, [updateDT]= null, [updateUser]= null
--Union Select NewID(), 'p001', 'plan/location 001', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'p002', 'plan/location 002', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'p003', 'plan/location 003', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'p004', 'plan/location 004', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'p005', 'plan/location 005', getdate(), 'Data4DesignTimeHelp'
-- ) x
-- where x.ID is not null

GO

--INSERT INTO [AD].[ParamVersion] ([ID], [version], [description], [updateDT], [updateUser]) 
--Select * from
-- (select [ID]= null, [version]= null, [description]= null, [updateDT]= null, [updateUser]= null
--Union Select NewID(), '1.001', 'version for template xyz', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), '2.001', 'version for template 123', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), '3.001', 'version for template abc', getdate(), 'Data4DesignTimeHelp'
-- ) x
-- where x.ID is not null

GO

--INSERT INTO [AD].[ParamType] ([ID], [type], [updateDT], [updateUser]) 
--Select * from
-- (select [ID]= null, [type]= null, [updateDT]= null, [updateUser]= null
--Union Select NewID(), 'Server', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'Database', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'EmailFrom', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'EmailTo', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'NTFS', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'SqlSelect', getdate(), 'Data4DesignTimeHelp'
--Union Select NewID(), 'Path', getdate(), 'Data4DesignTimeHelp'
--	Union Select NewID(), 'string', getdate(), 'Data4DesignTimeHelp'
--	Union Select NewID(), 'int', getdate(), 'Data4DesignTimeHelp'
--	Union Select NewID(), 'bool', getdate(), 'Data4DesignTimeHelp'
--	Union Select NewID(), 'DateTime', getdate(), 'Data4DesignTimeHelp'
--	Union Select NewID(), 'Date', getdate(), 'Data4DesignTimeHelp'
--	Union Select NewID(), 'Time', getdate(), 'Data4DesignTimeHelp'
--	Union Select NewID(), 'Number', getdate(), 'Data4DesignTimeHelp'
-- ) x
-- where x.ID is not null



GO

--Declare
--@ParamVersionID UniqueIdentifier = (select ID from AD.ParamVersion x where version = '2.001')
--,@ParamTypeID_bool UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'bool')
--,@ParamTypeID_EmailFrom UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'EmailFrom')
--,@ParamTypeID_EmailTo UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'EmailTo')
--,@ParamTypeID_int UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'int')
--,@ParamTypeID_NTFS UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'NTFS')
--,@ParamTypeID_path UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'path')
--,@ParamTypeID_SqlSelect UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'SqlSelect')
--,@ParamTypeID_string UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'string')
--,@ParamTypeID_Server UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'Server')

--if (convert(varchar(50),@ParamVersionID )
--	+convert(varchar(50),@ParamTypeID_bool) +convert(varchar(50),@ParamTypeID_EmailFrom) +convert(varchar(50),@ParamTypeID_EmailTo) +convert(varchar(50),@ParamTypeID_int )
--	+convert(varchar(50),@ParamTypeID_NTFS) +convert(varchar(50),@ParamTypeID_path) +convert(varchar(50),@ParamTypeID_SqlSelect) +convert(varchar(50),@ParamTypeID_string) 
--	+convert(varchar(50),@ParamTypeID_Server)
--) is null
--print 'Failed to set a parameter'

--ELSE
----print @ParamVersionID 
----	print @ParamTypeID_bool print @ParamTypeID_EmailFrom print @ParamTypeID_EmailTo print @ParamTypeID_int 
----	print @ParamTypeID_NTFS print @ParamTypeID_path print @ParamTypeID_SqlSelect print @ParamTypeID_string 
----  print @ParamTypeID_Server

--BEGIN
--print 'parameters okay'

IF EXISTS (SELECT name FROM sys.indexes WHERE name = N'NDX_PKey' AND object_id = object_id(N'[AD].[ParamDefinition]', N'U'))
    DROP INDEX [NDX_PKey] ON [AD].[ParamDefinition]

ALTER TABLE [AD].[ParamDefinition] ALTER COLUMN [ParamSequence] [char] NOT NULL

--SET IDENTITY_INSERT [AD].[ParamDefinition] OFF
--INSERT INTO [AD].[ParamDefinition] ([ID], [ParamVersionID], [ParamSequence], [ParamTypeID], [variableName], [intendedUse], [updateDT], [updateUser]) 
--Select * from
-- (select [ID]= null, [ParamVersionID]= null, [ParamSequence]= null, [ParamTypeID]= null, [variableName]= null, [intendedUse]= null, [updateDT]= null, [updateUser]= null
--Union Select NewID(),@ParamVersionID,1,@ParamTypeID_bool,'execOpt1','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,2,@ParamTypeID_bool,'execOpt2','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,3,@ParamTypeID_bool,'execOpt3','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,4,@ParamTypeID_bool,'execOpt4','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,5,@ParamTypeID_bool,'execOpt5','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'

--Union Select NewID(),@ParamVersionID,11,@ParamTypeID_Server,'connRW1_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,12,@ParamTypeID_string,'connRW1_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,13,@ParamTypeID_string,'connRW1_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,14,@ParamTypeID_string,'connRW1_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,15,@ParamTypeID_string,'connRW1_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,16,@ParamTypeID_string,'connRW1_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,17,@ParamTypeID_string,'connRW1_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,18,@ParamTypeID_string,'connRW1_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,19,@ParamTypeID_string,'connRW1_5SP1','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,20,@ParamTypeID_string,'connRW1_5SP2','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,21,@ParamTypeID_string,'connRW1_5SP3','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,22,@ParamTypeID_string,'connRW1_5SP4','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,23,@ParamTypeID_string,'connRW1_5SP5','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,24,@ParamTypeID_Server,'connRW2_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,25,@ParamTypeID_string,'connRW2_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,26,@ParamTypeID_string,'connRW2_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,27,@ParamTypeID_string,'connRW2_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,28,@ParamTypeID_string,'connRW2_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,29,@ParamTypeID_string,'connRW2_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,30,@ParamTypeID_string,'connRW2_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,31,@ParamTypeID_string,'connRW2_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,32,@ParamTypeID_string,'connRW2_5SP1','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,33,@ParamTypeID_string,'connRW2_5SP2','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,34,@ParamTypeID_string,'connRW2_5SP3','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,35,@ParamTypeID_string,'connRW2_5SP4','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,36,@ParamTypeID_string,'connRW2_5SP5','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,37,@ParamTypeID_Server,'connRW3_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,38,@ParamTypeID_string,'connRW3_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,39,@ParamTypeID_string,'connRW3_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,40,@ParamTypeID_string,'connRW3_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,41,@ParamTypeID_string,'connRW3_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,42,@ParamTypeID_string,'connRW3_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,43,@ParamTypeID_string,'connRW3_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,44,@ParamTypeID_string,'connRW3_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,45,@ParamTypeID_string,'connRW3_5SP1','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,46,@ParamTypeID_string,'connRW3_5SP2','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,47,@ParamTypeID_string,'connRW3_5SP3','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,48,@ParamTypeID_string,'connRW3_5SP4','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,49,@ParamTypeID_string,'connRW3_5SP5','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,50,@ParamTypeID_Server,'connRO4_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,51,@ParamTypeID_string,'connRO4_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,52,@ParamTypeID_string,'connRO4_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,53,@ParamTypeID_string,'connRO4_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,54,@ParamTypeID_string,'connRO4_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,55,@ParamTypeID_string,'connRO4_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,56,@ParamTypeID_string,'connRO4_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,57,@ParamTypeID_string,'connRO4_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,58,@ParamTypeID_Server,'connRO5_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,59,@ParamTypeID_string,'connRO5_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,60,@ParamTypeID_string,'connRO5_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,61,@ParamTypeID_string,'connRO5_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,62,@ParamTypeID_string,'connRO5_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,63,@ParamTypeID_string,'connRO5_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,64,@ParamTypeID_string,'connRO5_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,65,@ParamTypeID_string,'connRO5_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'

--Union Select NewID(),@ParamVersionID,101,@ParamTypeID_path,'pathGenerating1','Make new files here',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,102,@ParamTypeID_path,'pathGenerating2','Make new files here',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,103,@ParamTypeID_path,'pathGenerating3','Make new files here',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,104,@ParamTypeID_path,'pathProcessMe1','Process existing files here',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,105,@ParamTypeID_path,'pathProcessMe2','Process existing files here',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,106,@ParamTypeID_path,'pathProcessMe3','Process existing files here',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,107,@ParamTypeID_path,'pathExportMe1','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,108,@ParamTypeID_path,'pathExportMe2','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,109,@ParamTypeID_path,'pathExportMe3','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,110,@ParamTypeID_path,'pathExportMe4','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,111,@ParamTypeID_path,'pathExportMe5','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,112,@ParamTypeID_path,'pathExportMe6','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,113,@ParamTypeID_path,'pathExportMe7','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,114,@ParamTypeID_path,'pathExportMe8','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,115,@ParamTypeID_path,'pathExportMe9','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,116,@ParamTypeID_path,'pathArchive1','Move files (from Generating/ProcessMe) to this path for archival',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,117,@ParamTypeID_path,'pathArchive2','Move files (from Generating/ProcessMe) to this path for archival',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,118,@ParamTypeID_path,'pathArchive3','Move files (from Generating/ProcessMe) to this path for archival',GetDate(),'Data4DesignTimeHelp'

--Union Select NewID(),@ParamVersionID,130,@ParamTypeID_NTFS,'fileNamePattern1','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,131,@ParamTypeID_NTFS,'fileNamePattern2','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,132,@ParamTypeID_NTFS,'fileNamePattern3','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,133,@ParamTypeID_NTFS,'fileNamePattern4','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,134,@ParamTypeID_NTFS,'fileNamePattern5','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,135,@ParamTypeID_SqlSelect,'fileNameFormula1','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,136,@ParamTypeID_SqlSelect,'fileNameFormula2','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,137,@ParamTypeID_SqlSelect,'fileNameFormula3','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,138,@ParamTypeID_SqlSelect,'fileNameFormula4','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,139,@ParamTypeID_SqlSelect,'fileNameFormula5','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'

--Union Select NewID(),@ParamVersionID,145,@ParamTypeID_EmailFrom,'emailNotify1From','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,146,@ParamTypeID_EmailTo,'emailNotify1To','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,147,@ParamTypeID_EmailFrom,'emailNotify2From','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,148,@ParamTypeID_EmailTo,'emailNotify2To','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,149,@ParamTypeID_EmailFrom,'emailNotify3From','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,150,@ParamTypeID_EmailTo,'emailNotify3To','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,151,@ParamTypeID_EmailFrom,'emailErrorFrom','Email IT for Unhandled exceptions',GetDate(),'Data4DesignTimeHelp'
--Union Select NewID(),@ParamVersionID,152,@ParamTypeID_EmailTo,'emailErrorTo','Email IT for Unhandled exceptions',GetDate(),'Data4DesignTimeHelp'

--Union Select NewID(),@ParamVersionID,160,@ParamTypeID_int,'PurgeDays','Max Days to keep data - purge older',GetDate(),'Data4DesignTimeHelp'
-- ) x
-- where x.ID is not null

--/*SET IDENTITY_INSERT [AD].[ParamDefinition] OFF  //this should have never been here*/
--END

GO

--Declare
--@ParamVersionID UniqueIdentifier = (select ID from AD.ParamVersion x where version = '2.001')
--,@AppIDxyz UniqueIdentifier = (select ID from AD.App x where x.abbr = 'xyz')
--,@AppID123 UniqueIdentifier = (select ID from AD.App x where x.abbr = '123')

--if (convert(varchar(50),@ParamVersionID ) + convert(varchar(50),@AppIDxyz) + convert(varchar(50),@AppID123) ) is null
--print 'Failed to set a parameter'

--ELSE
--BEGIN
--	print @ParamVersionID 
--	print @AppIDxyz
--	print @AppID123
--	print 'parameters okay'

--	--SET IDENTITY_INSERT [AD].[Config] ON
--	INSERT INTO [AD].[Config]
--	([ID] /*,[jobID]*/ ,[AppID] ,[ParamVersionID] ,[Active] ,[DescriptonShort] ,[DescriptonFull] ,[effDT] ,[trmDT] ,[updateDT] ,[updateUser]) 
--	Select * from
--	 (select [ID]= null /*,[jobID] = null*/ ,[AppID] = null ,[ParamVersionID] = null ,[Active] = null ,[DescriptonShort] = null ,[DescriptonFull] = null ,[effDT] = null ,[trmDT] = null ,[updateDT] = null ,[updateUser]= null
--	Union Select NewID() ,@AppIDxyz ,@ParamVersionID ,1 ,'Desc Short JobID1' ,'Desc Full JobID1' , GetDate()-10, GetDate()+100, GetDate(), 'Data4DesignTimeHelp'
--	Union Select NewID() ,@AppIDxyz ,@ParamVersionID ,1 ,'Desc Short JobID2' ,'Desc Full JobID2' , GetDate()-10, GetDate()+100, GetDate(), 'Data4DesignTimeHelp'
--	Union Select NewID() ,@AppID123 ,@ParamVersionID ,1 ,'Desc Short JobID3' ,'Desc Full JobID3' , GetDate()-10, GetDate()+100, GetDate(), 'Data4DesignTimeHelp'
--	Union Select NewID() ,@AppID123 ,@ParamVersionID ,1 ,'Desc Short JobID4' ,'Desc Full JobID4' , GetDate()-10, GetDate()+100, GetDate(), 'Data4DesignTimeHelp'
--	 ) x
--	where x.ID is not null
--	--SET IDENTITY_INSERT [AD].[Config] OFF
-- END

 GO
 Declare
@ParamVersionID UniqueIdentifier = (select ID from AD.ParamVersion x where version = '2.001')
,@ConfigID1 UniqueIdentifier = (select ID from AD.Config x where x.JobID = 1)
print @ParamVersionID 
print @ConfigID1 

	INSERT INTO  [_PROD].[ConfigParam]
	([ID],[ConfigID],[effDT],[trmDT],[ParamDefinitionID],[isRefOnly],[value],[valueUseageComments],[updateDT],[updateUser]) 
	Select * from
	(select [ID]= null , [ConfigID]=null ,	[effDT]=null ,[trmDT]=null ,[ParamDefinitionID]=null ,[isRefOnly]=null ,[value]=null ,[valueUseageComments]=null ,[updateDT]=null ,[updateUser]=null
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'execOpt1') ,0 ,'1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_1Srvr') ,0 ,'serverPROD' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_2Db') ,0 ,'WhuteverDB' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_3Sch') ,0 ,'AD' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl1') ,0 ,'Table1name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl2') ,0 ,'Table2name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_5SP1') ,0 ,'StoredProcXYZ' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'pathGenerating1') ,0 ,'\\ServerFileShare\path1\pathb' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'fileNamePattern1') ,0 ,'*somefile*.zip' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'PurgeDays') ,0 ,'2555' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null

	INSERT INTO  [_QA1].[ConfigParam]
	([ID],[ConfigID],[effDT],[trmDT],[ParamDefinitionsID],[isRefOnly],[value],[valueUseageComments],[updateDT],[updateUser]) 
	Select * from
	(select [ID]= null , [ConfigID]=null ,	[effDT]=null ,[trmDT]=null ,[ParamDefinitionsID]=null ,[isRefOnly]=null ,[value]=null ,[valueUseageComments]=null ,[updateDT]=null ,[updateUser]=null
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'execOpt1') ,0 ,'1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_1Srvr') ,0 ,'serverQA1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_2Db') ,0 ,'WhuteverDB' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_3Sch') ,0 ,'AD' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl1') ,0 ,'Table1name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl2') ,0 ,'Table2name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_5SP1') ,0 ,'StoredProcXYZ' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'pathGenerating1') ,0 ,'\\ServerFileShare\path1\pathb' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'fileNamePattern1') ,0 ,'*somefile*.zip' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'PurgeDays') ,0 ,'180' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null

	INSERT INTO  [_DEV1].[ConfigParam]
	([ID],[ConfigID],[effDT],[trmDT],[ParamDefinitionsID],[isRefOnly],[value],[valueUseageComments],[updateDT],[updateUser]) 
	Select * from
	(select [ID]= null , [ConfigID]=null ,	[effDT]=null ,[trmDT]=null ,[ParamDefinitionsID]=null ,[isRefOnly]=null ,[value]=null ,[valueUseageComments]=null ,[updateDT]=null ,[updateUser]=null
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'execOpt1') ,0 ,'1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_1Srvr') ,0 ,'serverDEV1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_2Db') ,0 ,'WhuteverDB' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_3Sch') ,0 ,'AD' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl1') ,0 ,'Table1name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl2') ,0 ,'Table2name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_5SP1') ,0 ,'StoredProcXYZ' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'pathGenerating1') ,0 ,'\\ServerFileShare\path1\pathb' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'fileNamePattern1') ,0 ,'*somefile*.zip' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamVersion x where x.ParamVersionID = @ParamVersionID and x.variableName = 'PurgeDays') ,0 ,'180' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null

END



select * from [AD].[App] x order by x.abbr
select * from [AD].[Plan] x order by x.abbr
select * from [AD].[ParamType] x order by x.type
select * from [AD].[ParamVersion] x order by x.version
select * from [AD].[ParamDefinition] x order by x.ParamVersionID, x.ParamSequence
select * from [AD].[Config] x order by x.updateDT, x.JobID
select x.* ,x2.[ParamSequence] ,x2.[ParamTypeID] ,x2.[variableName] 
	from [_PROD].[ConfigParam] x 
		join [AD].[ParamDefinition] x2 on x.ParamDefinitionID = x2.ID 
	order by x.[ConfigID], x2.[ParamSequence]
select x.* ,x2.[ParamSequence] ,x2.[ParamTypeID] ,x2.[variableName] 
	from [_QA1].[ConfigParam] x 
		join [AD].[ParamDefinition] x2 on x.ParamDefinitionID = x2.ID 
	order by x.[ConfigID], x2.[ParamSequence]
select x.* ,x2.[ParamSequence] ,x2.[ParamTypeID] ,x2.[variableName] 
	from [_DEV1].[ConfigParam] x 
		join [AD].[ParamDefinition] x2 on x.ParamDefinitionID = x2.ID 
	order by x.[ConfigID], x2.[ParamSequence]


--where TJConfigPlan : IJConfigPlan
--where TJConfigExecutable : IJConfigExecutable


