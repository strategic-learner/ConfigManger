
use ConfigMgr


--GO  
--EXEC sp_configure 'show advanced options', 1;  
--GO  
--RECONFIGURE ;  
--GO 
--EXEC sp_configure
--GO
--EXEC sp_configure 'user connections'
--GO
/*settings were:
name	minimum	maximum	config_value	run_value
user connections	0	32767	0	0
*/  
--EXEC sp_configure 'user connections', 500 ;  
--GO  
--RECONFIGURE;  
--GO


GO

INSERT INTO [AD].[App] 
	([ID], [ITIL], [abbr], [description], [updateDT], [updateUser]) 
Select * from
 (select [ID]= null, [ITIL]= null, [abbr]= null, [description]= null, [updateDT]= null, [updateUser]= null
Union Select NewID(), 1234, 'xyz', 'xyz some description here', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 4321, '123', '123 some description here', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 0987, 'abc', 'abc some description here', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 7890, 'x12', 'x12 some description here', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 456, 'pro', 'pro some description here', getdate(), 'Data4DesignTimeHelp'
 ) x
 where x.ID is not null

 --Select * from AD.App
 --Select * from AD.Config
GO

INSERT INTO [AD].[Plan] 
([ID], [abbr], [descr], [updateDT], [updateUser])
Select * from
 (select [ID]= null, [abbr]= null, [descr]= null, [updateDT]= null, [updateUser]= null
Union Select NewID(), 'p001', 'plan/location 001', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'p002', 'plan/location 002', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'p003', 'plan/location 003', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'p004', 'plan/location 004', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'p005', 'plan/location 005', getdate(), 'Data4DesignTimeHelp'
 ) x
 where x.ID is not null

GO

INSERT INTO [AD].[ParamVersion] ([ID], [version], [description], [updateDT], [updateUser]) 
Select * from
 (select [ID]= null, [version]= null, [description]= null, [updateDT]= null, [updateUser]= null
Union Select NewID(), '1.001', 'version for template xyz', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), '2.001', 'version for template 123', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), '3.001', 'version for template abc', getdate(), 'Data4DesignTimeHelp'
 ) x
 where x.ID is not null

GO

INSERT INTO [AD].[ParamType] ([ID], [type], [updateDT], [updateUser]) 
Select * from
 (select [ID]= null, [type]= null, [updateDT]= null, [updateUser]= null
Union Select NewID(), 'Server', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'Database', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'EmailFrom', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'EmailTo', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'NTFS', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'SqlSelect', getdate(), 'Data4DesignTimeHelp'
Union Select NewID(), 'Path', getdate(), 'Data4DesignTimeHelp'
	Union Select NewID(), 'string', getdate(), 'Data4DesignTimeHelp'
	Union Select NewID(), 'int', getdate(), 'Data4DesignTimeHelp'
	Union Select NewID(), 'bool', getdate(), 'Data4DesignTimeHelp'
	Union Select NewID(), 'DateTime', getdate(), 'Data4DesignTimeHelp'
	Union Select NewID(), 'Date', getdate(), 'Data4DesignTimeHelp'
	Union Select NewID(), 'Time', getdate(), 'Data4DesignTimeHelp'
	Union Select NewID(), 'Number', getdate(), 'Data4DesignTimeHelp'
 ) x
 where x.ID is not null



GO



Declare
@ParamVersionID UniqueIdentifier = (select ID from AD.ParamVersion x where version = '2.001')
,@ParamTypeID_bool UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'bool')
,@ParamTypeID_EmailFrom UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'EmailFrom')
,@ParamTypeID_EmailTo UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'EmailTo')
,@ParamTypeID_int UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'int')
,@ParamTypeID_NTFS UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'NTFS')
,@ParamTypeID_path UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'path')
,@ParamTypeID_SqlSelect UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'SqlSelect')
,@ParamTypeID_string UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'string')
,@ParamTypeID_Server UniqueIdentifier = (select ID from AD.ParamType x where x.type = 'Server')

if (convert(varchar(50),@ParamVersionID )
	+convert(varchar(50),@ParamTypeID_bool) +convert(varchar(50),@ParamTypeID_EmailFrom) +convert(varchar(50),@ParamTypeID_EmailTo) +convert(varchar(50),@ParamTypeID_int )
	+convert(varchar(50),@ParamTypeID_NTFS) +convert(varchar(50),@ParamTypeID_path) +convert(varchar(50),@ParamTypeID_SqlSelect) +convert(varchar(50),@ParamTypeID_string) 
	+convert(varchar(50),@ParamTypeID_Server)
) is null
print 'Failed to set a parameter'

ELSE
--print @ParamVersionID 
--	print @ParamTypeID_bool print @ParamTypeID_EmailFrom print @ParamTypeID_EmailTo print @ParamTypeID_int 
--	print @ParamTypeID_NTFS print @ParamTypeID_path print @ParamTypeID_SqlSelect print @ParamTypeID_string 
--  print @ParamTypeID_Server

BEGIN
print 'parameters okay'

INSERT INTO [AD].[ParamDefinition] ([ID], [ParamVersionID], [ParamSequence], [ParamTypeID], [variableName], [intendedUse], [updateDT], [updateUser]) 
Select * from
 (select [ID]= null, [ParamVersionID]= null, [ParamSequence]= null, [ParamTypeID]= null, [variableName]= null, [intendedUse]= null, [updateDT]= null, [updateUser]= null
	Union Select NewID(),@ParamVersionID,1,@ParamTypeID_bool,'execOpt1','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,2,@ParamTypeID_bool,'execOpt2','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,3,@ParamTypeID_bool,'execOpt3','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,4,@ParamTypeID_bool,'execOpt4','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,5,@ParamTypeID_bool,'execOpt5','Enable/Disable processing Features',GetDate(),'Data4DesignTimeHelp'

	Union Select NewID(),@ParamVersionID,11,@ParamTypeID_Server,'connRW1_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,12,@ParamTypeID_string,'connRW1_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,13,@ParamTypeID_string,'connRW1_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,14,@ParamTypeID_string,'connRW1_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,15,@ParamTypeID_string,'connRW1_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,16,@ParamTypeID_string,'connRW1_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,17,@ParamTypeID_string,'connRW1_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,18,@ParamTypeID_string,'connRW1_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,19,@ParamTypeID_string,'connRW1_5SP1','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,20,@ParamTypeID_string,'connRW1_5SP2','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,21,@ParamTypeID_string,'connRW1_5SP3','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,22,@ParamTypeID_string,'connRW1_5SP4','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,23,@ParamTypeID_string,'connRW1_5SP5','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,24,@ParamTypeID_Server,'connRW2_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,25,@ParamTypeID_string,'connRW2_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,26,@ParamTypeID_string,'connRW2_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,27,@ParamTypeID_string,'connRW2_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,28,@ParamTypeID_string,'connRW2_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,29,@ParamTypeID_string,'connRW2_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,30,@ParamTypeID_string,'connRW2_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,31,@ParamTypeID_string,'connRW2_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,32,@ParamTypeID_string,'connRW2_5SP1','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,33,@ParamTypeID_string,'connRW2_5SP2','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,34,@ParamTypeID_string,'connRW2_5SP3','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,35,@ParamTypeID_string,'connRW2_5SP4','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,36,@ParamTypeID_string,'connRW2_5SP5','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,37,@ParamTypeID_Server,'connRW3_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,38,@ParamTypeID_string,'connRW3_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,39,@ParamTypeID_string,'connRW3_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,40,@ParamTypeID_string,'connRW3_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,41,@ParamTypeID_string,'connRW3_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,42,@ParamTypeID_string,'connRW3_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,43,@ParamTypeID_string,'connRW3_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,44,@ParamTypeID_string,'connRW3_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,45,@ParamTypeID_string,'connRW3_5SP1','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,46,@ParamTypeID_string,'connRW3_5SP2','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,47,@ParamTypeID_string,'connRW3_5SP3','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,48,@ParamTypeID_string,'connRW3_5SP4','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,49,@ParamTypeID_string,'connRW3_5SP5','SQL StoredProc',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,50,@ParamTypeID_Server,'connRO4_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,51,@ParamTypeID_string,'connRO4_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,52,@ParamTypeID_string,'connRO4_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,53,@ParamTypeID_string,'connRO4_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,54,@ParamTypeID_string,'connRO4_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,55,@ParamTypeID_string,'connRO4_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,56,@ParamTypeID_string,'connRO4_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,57,@ParamTypeID_string,'connRO4_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,58,@ParamTypeID_Server,'connRO5_1Srvr','SQL Server Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,59,@ParamTypeID_string,'connRO5_2Db','SQL Database Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,60,@ParamTypeID_string,'connRO5_3Sch','SQL Schema Name',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,61,@ParamTypeID_string,'connRO5_4Tbl1','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,62,@ParamTypeID_string,'connRO5_4Tbl2','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,63,@ParamTypeID_string,'connRO5_4Tbl3','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,64,@ParamTypeID_string,'connRO5_4Tbl4','SQL table',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,65,@ParamTypeID_string,'connRO5_4Tbl5','SQL table',GetDate(),'Data4DesignTimeHelp'

	Union Select NewID(),@ParamVersionID,101,@ParamTypeID_path,'pathGenerating1','Make new files here',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,102,@ParamTypeID_path,'pathGenerating2','Make new files here',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,103,@ParamTypeID_path,'pathGenerating3','Make new files here',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,104,@ParamTypeID_path,'pathProcessMe1','Process existing files here',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,105,@ParamTypeID_path,'pathProcessMe2','Process existing files here',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,106,@ParamTypeID_path,'pathProcessMe3','Process existing files here',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,107,@ParamTypeID_path,'pathExportMe1','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,108,@ParamTypeID_path,'pathExportMe2','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,109,@ParamTypeID_path,'pathExportMe3','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,110,@ParamTypeID_path,'pathExportMe4','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,111,@ParamTypeID_path,'pathExportMe5','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,112,@ParamTypeID_path,'pathExportMe6','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,113,@ParamTypeID_path,'pathExportMe7','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,114,@ParamTypeID_path,'pathExportMe8','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,115,@ParamTypeID_path,'pathExportMe9','copy files (from Generating/ProcessMe) to this path for pickup',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,116,@ParamTypeID_path,'pathArchive1','Move files (from Generating/ProcessMe) to this path for archival',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,117,@ParamTypeID_path,'pathArchive2','Move files (from Generating/ProcessMe) to this path for archival',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,118,@ParamTypeID_path,'pathArchive3','Move files (from Generating/ProcessMe) to this path for archival',GetDate(),'Data4DesignTimeHelp'

	Union Select NewID(),@ParamVersionID,130,@ParamTypeID_NTFS,'fileNamePattern1','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,131,@ParamTypeID_NTFS,'fileNamePattern2','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,132,@ParamTypeID_NTFS,'fileNamePattern3','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,133,@ParamTypeID_NTFS,'fileNamePattern4','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,134,@ParamTypeID_NTFS,'fileNamePattern5','pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,135,@ParamTypeID_SqlSelect,'fileNameFormula1','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,136,@ParamTypeID_SqlSelect,'fileNameFormula2','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,137,@ParamTypeID_SqlSelect,'fileNameFormula3','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,138,@ParamTypeID_SqlSelect,'fileNameFormula4','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,139,@ParamTypeID_SqlSelect,'fileNameFormula5','Sql Select statement to create filename string',GetDate(),'Data4DesignTimeHelp'

	Union Select NewID(),@ParamVersionID,145,@ParamTypeID_EmailFrom,'emailNotify1From','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,146,@ParamTypeID_EmailTo,'emailNotify1To','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,147,@ParamTypeID_EmailFrom,'emailNotify2From','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,148,@ParamTypeID_EmailTo,'emailNotify2To','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,149,@ParamTypeID_EmailFrom,'emailNotify3From','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,150,@ParamTypeID_EmailTo,'emailNotify3To','Avoid custom batch-generated emails',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,151,@ParamTypeID_EmailFrom,'emailErrorFrom','Email IT for Unhandled exceptions',GetDate(),'Data4DesignTimeHelp'
	Union Select NewID(),@ParamVersionID,152,@ParamTypeID_EmailTo,'emailErrorTo','Email IT for Unhandled exceptions',GetDate(),'Data4DesignTimeHelp'

	Union Select NewID(),@ParamVersionID,160,@ParamTypeID_int,'PurgeDays','Max Days to keep data - purge older',GetDate(),'Data4DesignTimeHelp'
	 ) x
	 where x.ID is not null
 
END



GO



Declare
@ParamVersionID UniqueIdentifier = (select ID from AD.ParamVersion x where version = '2.001')
,@AppIDxyz UniqueIdentifier = (select ID from AD.App x where x.abbr = 'xyz')
,@AppID123 UniqueIdentifier = (select ID from AD.App x where x.abbr = '123')

if (convert(varchar(50),@ParamVersionID ) + convert(varchar(50),@AppIDxyz) + convert(varchar(50),@AppID123) ) is null
print 'Failed to set a parameter'

ELSE
BEGIN
	print @ParamVersionID 
	print @AppIDxyz
	print @AppID123
	print 'parameters okay'

	--SET IDENTITY_INSERT [AD].[Config] ON
	INSERT INTO [AD].[Config]
	([ID] /*,[jobID]*/ ,[AppID] ,[ParamVersionID] ,[Active] ,[DescriptionShort] ,[DescriptionFull] ,[effDT] ,[trmDT] ,[updateDT] ,[updateUser]) 
	Select * from
	 (select [ID]= null /*,[jobID] = null*/ ,[AppID] = null ,[ParamVersionID] = null ,[Active] = null ,[DescriptionShort] = null ,[DescriptionFull] = null ,[effDT] = null ,[trmDT] = null ,[updateDT] = null ,[updateUser]= null
	Union Select NewID() ,@AppIDxyz ,@ParamVersionID ,1 ,'Desc Short JobIDX' ,'Desc Full JobIDX' , GetDate()-10, GetDate()+100, GetDate(), 'Data4DesignTimeHelp'
	Union Select NewID() ,@AppIDxyz ,@ParamVersionID ,1 ,'Desc Short JobIDX' ,'Desc Full JobIDX' , GetDate()-10, GetDate()+100, GetDate(), 'Data4DesignTimeHelp'
	Union Select NewID() ,@AppID123 ,@ParamVersionID ,1 ,'Desc Short JobIDX' ,'Desc Full JobIDX' , GetDate()-10, GetDate()+100, GetDate(), 'Data4DesignTimeHelp'
	Union Select NewID() ,@AppID123 ,@ParamVersionID ,1 ,'Desc Short JobIDX' ,'Desc Full JobIDX' , GetDate()-10, GetDate()+100, GetDate(), 'Data4DesignTimeHelp'
	 ) x
	where x.ID is not null
	order by x.DescriptionShort
	--SET IDENTITY_INSERT [AD].[Config] OFF
	 END


--Update AD.Config Set 
-- DescriptionShort = SUBSTRING(DescriptionShort,0,len(DescriptionShort) )+convert(varchar(10),Jobid)
--,DescriptionFull = SUBSTRING(DescriptionFull,0,len(DescriptionFull) )+convert(varchar(10),Jobid)

--select * from AD.Config


 GO



 Declare
@ParamVersionID UniqueIdentifier = (select ID from AD.ParamVersion x where version = '2.001')
,@ConfigID1 UniqueIdentifier = (select ID from AD.Config x where x.JobID = 5)
print @ParamVersionID 
print @ConfigID1 

BEGIN
	INSERT INTO  [_PROD].[ConfigParam]
	([ID],[ConfigID],[effDT],[trmDT],[ParamDefinitionID],[isRefOnly],[value],[valueUseageComments],[updateDT],[updateUser]) 
	Select * from
	(select [ID]= null , [ConfigID]=null ,	[effDT]=null ,[trmDT]=null ,[ParamDefinitionID]=null ,[isRefOnly]=null ,[value]=null ,[valueUseageComments]=null ,[updateDT]=null ,[updateUser]=null
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'execOpt1') ,0 ,'1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_1Srvr') ,0 ,'serverPROD' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_2Db') ,0 ,'WhuteverDB' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_3Sch') ,0 ,'AD' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl1') ,0 ,'Table1name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl2') ,0 ,'Table2name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_5SP1') ,0 ,'StoredProcXYZ' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'pathGenerating1') ,0 ,'\\ServerFileShare\path1\pathb' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'fileNamePattern1') ,0 ,'*somefile*.zip' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'PurgeDays') ,0 ,'2555' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null

	INSERT INTO  [_QA1].[ConfigParam]
	([ID],[ConfigID],[effDT],[trmDT],[ParamDefinitionID],[isRefOnly],[value],[valueUseageComments],[updateDT],[updateUser]) 
	Select * from
	(select [ID]= null , [ConfigID]=null ,	[effDT]=null ,[trmDT]=null ,[ParamDefinitionID]=null ,[isRefOnly]=null ,[value]=null ,[valueUseageComments]=null ,[updateDT]=null ,[updateUser]=null
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'execOpt1') ,0 ,'1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_1Srvr') ,0 ,'serverQA1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_2Db') ,0 ,'WhuteverDB' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_3Sch') ,0 ,'AD' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl1') ,0 ,'Table1name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl2') ,0 ,'Table2name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_5SP1') ,0 ,'StoredProcXYZ' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'pathGenerating1') ,0 ,'\\ServerFileShare\path1\pathb' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'fileNamePattern1') ,0 ,'*somefile*.zip' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'PurgeDays') ,0 ,'180' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null

	INSERT INTO  [_DEV1].[ConfigParam]
	([ID],[ConfigID],[effDT],[trmDT],[ParamDefinitionID],[isRefOnly],[value],[valueUseageComments],[updateDT],[updateUser]) 
	Select * from
	(select [ID]= null , [ConfigID]=null ,	[effDT]=null ,[trmDT]=null ,[ParamDefinitionID]=null ,[isRefOnly]=null ,[value]=null ,[valueUseageComments]=null ,[updateDT]=null ,[updateUser]=null
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'execOpt1') ,0 ,'1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_1Srvr') ,0 ,'serverDEV1' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_2Db') ,0 ,'WhuteverDB' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_3Sch') ,0 ,'AD' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl1') ,0 ,'Table1name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_4Tbl2') ,0 ,'Table2name' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'connRW1_5SP1') ,0 ,'StoredProcXYZ' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'pathGenerating1') ,0 ,'\\ServerFileShare\path1\pathb' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'fileNamePattern1') ,0 ,'*somefile*.zip' ,'' ,GetDate() ,'Data4DesignTimeHelp'
		Union Select NewID() ,@ConfigID1 ,GetDate()-100 ,GetDate()+100 ,(Select ID From AD.ParamDefinition x where x.ParamVersionID = @ParamVersionID and x.variableName = 'PurgeDays') ,0 ,'180' ,'' ,GetDate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null

END



GO


Declare
 @ParamVersionID UniqueIdentifier = (select ID from AD.ParamVersion x where version = '2.001')
,@AppIDxyz UniqueIdentifier = (select ID from AD.App x where x.abbr = 'xyz')
,@AppID123 UniqueIdentifier = (select ID from AD.App x where x.abbr = '123')


	INSERT INTO  [AD].[Executable]
	([ID]	,[AppID]	,[nameWExtension]	,[description]	,[ParamVersionID]	,[updateDT]	,[updateUser]) 
	Select * from
	(select [ID]=null	,[AppID]=null	,[nameWExtension]=null	,[description]=null	,[ParamVersionID]=null	,[updateDT]=null	,[updateUser]=null
		union select NewID() ,@AppIDxyz ,'JobID1.vbs' ,'some desc' ,@ParamVersionID ,GetDate() ,'Data4DesignTimeHelp'
		union select NewID() ,@AppIDxyz ,'JobID1.bat' ,'Some Desc' ,@ParamVersionID ,GetDate() ,'Data4DesignTimeHelp'
		union select NewID() ,@AppIDxyz ,'JobID1_.bat' ,'' ,@ParamVersionID ,GetDate() ,'Data4DesignTimeHelp'
		union select NewID() ,@AppIDxyz ,'JobID1.dtsx' ,'' ,@ParamVersionID ,GetDate() ,'Data4DesignTimeHelp'

		union select NewID() ,@AppID123 ,'JobID3.vbs' ,'some desc' ,NULL ,GetDate() ,'Data4DesignTimeHelp'
		union select NewID() ,@AppID123 ,'JobID3.bat' ,'Some Desc' ,NULL ,GetDate() ,'Data4DesignTimeHelp'
		union select NewID() ,@AppID123 ,'JobID3_.bat' ,'' ,NULL ,GetDate() ,'Data4DesignTimeHelp'
		union select NewID() ,@AppID123 ,'JobID3.dtsx' ,'' ,NULL ,GetDate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null



GO



	INSERT INTO  [AD].[LineOfBusiness]
	([ID],	[abbr],	[descr],	[updateDT],	[updateUser])
	Select * from
	(select [ID]=null	,[abbr]=null	,[descr]=null	,[updateDT]=null	,[updateUser]=null
		union select NewID() ,'LOBabc' ,'LOB abc Description' ,GetDate() ,'Data4DesignTimeHelp'
		union select NewID() ,'LOB123' ,'LOB 123 Description' ,GetDate() ,'Data4DesignTimeHelp'
		union select NewID() ,'LOBxyz' ,'LOB xyz Description' ,GetDate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null



GO



Declare
 @PlanID1 UniqueIdentifier = (select ID from AD.[Plan] x where x.abbr = 'p001')
,@PlanID3 UniqueIdentifier = (select ID from AD.[Plan] x where x.abbr = 'p003')
,@PlanID5 UniqueIdentifier = (select ID from AD.[Plan] x where x.abbr = 'p005')
,@LOBIDabc UniqueIdentifier = (select ID from AD.LineOfBusiness x where x.abbr = 'LOBabc')
,@LOBID123 UniqueIdentifier = (select ID from AD.LineOfBusiness x where x.abbr = 'LOB123')
,@LOBIDxyz UniqueIdentifier = (select ID from AD.LineOfBusiness x where x.abbr = 'LOBxyz')

INSERT INTO  [AD].[J_Plan_LOB]
	([ID] ,[PlanID] ,[LineOfBusinessID] ,[updateDT] ,[updateUser])
	Select * from
	(select [ID]=null ,[PlanId]=null ,[LineOfBusinessID]=null ,[updateDT]=null ,[updateUser]=null
		union select NewID() ,@PlanID1 ,@LOBIDabc ,Getdate() ,'Data4DesignTimeHelp'
		union select NewID() ,@PlanID1 ,@LOBIDxyz ,Getdate() ,'Data4DesignTimeHelp'

		union select NewID() ,@PlanID3 ,@LOBIDabc ,Getdate() ,'Data4DesignTimeHelp'
		union select NewID() ,@PlanID3 ,@LOBID123 ,Getdate() ,'Data4DesignTimeHelp'
		union select NewID() ,@PlanID3 ,@LOBIDxyz ,Getdate() ,'Data4DesignTimeHelp'

		union select NewID() ,@PlanID5 ,@LOBID123 ,Getdate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null


GO


Declare

 @ConfigID5 UniqueIdentifier = (select ID from AD.Config x where x.jobID = '5')
,@ConfigID7 UniqueIdentifier = (select ID from AD.Config x where x.jobID = '7')
,@ConfigID8 UniqueIdentifier = (select ID from AD.Config x where x.jobID = '8')
,@Plan1_LOBabc UniqueIdentifier = (
	Select x.ID From [AD].[J_Plan_LOB] x	join [AD].[Plan] p on x.planID = p.id	join [AD].[LineOfBusiness] lob on x.LineOfBusinessID = lob.ID
	Where p.abbr = 'p001' and lob.abbr = 'LOBabc')
,@Plan3_LOB123 UniqueIdentifier = (
	Select x.ID From [AD].[J_Plan_LOB] x	join [AD].[Plan] p on x.planID = p.id	join [AD].[LineOfBusiness] lob on x.LineOfBusinessID = lob.ID
	Where p.abbr = 'p003' and lob.abbr = 'LOB123')
,@Plan3_LOBxyz UniqueIdentifier = (
	Select x.ID From [AD].[J_Plan_LOB] x	join [AD].[Plan] p on x.planID = p.id	join [AD].[LineOfBusiness] lob on x.LineOfBusinessID = lob.ID
	Where p.abbr = 'p003' and lob.abbr = 'LOBxyz')
,@Plan5_LOB123 UniqueIdentifier = (
	Select x.ID From [AD].[J_Plan_LOB] x	join [AD].[Plan] p on x.planID = p.id	join [AD].[LineOfBusiness] lob on x.LineOfBusinessID = lob.ID
	Where p.abbr = 'p005' and lob.abbr = 'LOB123')

INSERT INTO  [AD].[J_Config_JPlanLOB]
	([ID] ,[ConfigID] ,[JPlanLOBID] ,[updateDT] ,[updateUser])
	Select * from
	(select [ID]=null ,[ConfigID]=null ,[JPlanLOBID]=null ,[updateDT]=null ,[updateUser]=null
		union select NewID() ,@ConfigID5 ,@Plan3_LOB123 ,Getdate() ,'Data4DesignTimeHelp'
		union select NewID() ,@ConfigID5 ,@Plan3_LOBxyz ,Getdate() ,'Data4DesignTimeHelp'
		union select NewID() ,@ConfigID7 ,@Plan1_LOBabc ,Getdate() ,'Data4DesignTimeHelp'
		union select NewID() ,@ConfigID8 ,@Plan5_LOB123 ,Getdate() ,'Data4DesignTimeHelp'
	) x
	where x.ID is not null



GO


--DEPRICATE THIS TABLE

--Declare
-- @ConfigIDxyz UniqueIdentifier = (select ID from AD.Config x where x.jobID = '5')
--,@ConfigID123 UniqueIdentifier = (select ID from AD.Config x where x.jobID = '7')
--,@PlanIDxyz UniqueIdentifier = (select ID from AD.[Plan] x where x.abbr = 'p001')
--,@PlanID123 UniqueIdentifier = (select ID from AD.[Plan] x where x.abbr = 'p003')


--INSERT INTO  [AD].[J_Config_Plan]
--	([ID] ,[ConfigID] ,[PlanID] ,[updateDT] ,[updateUser])
--	Select * from
--	(select [ID]=null ,[ConfigID]=null ,[PlanID]=null ,[updateDT]=null ,[updateUser]=null
--		union select NewID() ,@ConfigIDxyz ,@PlanIDxyz ,Getdate() ,'Data4DesignTimeHelp'
--		union select NewID() ,@ConfigID123 ,@PlanID123 ,Getdate() ,'Data4DesignTimeHelp'
--	) x
--	where x.ID is not null



GO



Declare
 @ConfigIDxyz UniqueIdentifier = (select ID from AD.Config x where x.jobID = '5')
,@ConfigID123 UniqueIdentifier = (select ID from AD.Config x where x.jobID = '7')

INSERT INTO  [AD].[J_Config_Executable]
	([ID] ,[ConfigID] ,[ExecutableID] ,[updateDT] ,[updateUser])
	Select * from
	(select [ID]=null ,[ConfigID]=null ,[ExecutableID]=null ,[updateDT]=null ,[updateUser]=null
		
		union select NewID() ,@ConfigIDxyz ,x.ID ,Getdate() ,'Data4DesignTimeHelp'
			From AD.[Executable] x where x.nameWExtension like '%JobID1%'

		union select NewID() ,@ConfigID123 ,x.ID ,Getdate() ,'Data4DesignTimeHelp'
			From AD.[Executable] x where x.nameWExtension like '%JobID3%'
	) x
	where x.ID is not null

GO

Select DescriptionShort ,* from  [AD].[ConfigAudit]

/*  when Triggers aren't setup/Active  */
--Insert [AD].[ConfigAudit]
--(/*AuditID,*/ AuditDT, AuditType, AuditSUserSName, [ID] ,[jobID] ,[AppID] ,[ParamVersionID] ,[Active] ,[DescriptionShort] ,[DescriptionFull] ,[effDT] ,[trmDT] ,[updateDT] ,[updateUser])
--Select getdate(),1,SUSER_SNAME(),
--[ID] ,[jobID] ,[AppID] ,[ParamVersionID] ,[Active] ,[DescriptionShort] ,[DescriptionFull] ,[effDT] ,[trmDT] ,[updateDT] ,[updateUser]
--From  [AD].[Config]
	

GO

select * from [AD].[Config] x order by x.JobID
select * from [AD].[App] x order by x.abbr
select * from [AD].[J_Config_Executable] x order by x.ConfigID
					select * from [AD].[Executable] x order by x.AppID, x.nameWExtension
select * from  [AD].[J_Config_JPlanLOB] x order by x.ID
	select * from [AD].[J_Plan_LOB] x order by x.ID
		select * from [AD].[Plan] x order by x.abbr
		select * from [AD].[LineOfBusiness] x order by x.abbr


--select * from [AD].[J_Config_Plan] x order by x.ConfigID
					
select * from [AD].[ParamVersion] x order by x.version
	select * from [AD].[ParamType] x order by x.type
	select * from [AD].[ParamDefinition] x order by x.ParamVersionID, x.ParamSequence



/* Config Params */
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


/*
Truncate table [_PROD].[ConfigParam]
Truncate table [_QA1].[ConfigParam]
Truncate table [_DEV1].[ConfigParam]
Truncate table [AD].[J_Config_Executable]
Truncate table [AD].[J_Config_Plan]
delete from [AD].[ParamDefinition]
delete from[AD].[Config]
delete from [AD].[Executable]
delete from [AD].[Plan]
delete from [AD].[App]
delete from [AD].[ParamVersion]
delete from [AD].[ParamType]
*/




