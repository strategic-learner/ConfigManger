using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DIV.ConfigMgr.Domain.Read;

namespace Company.DIV.ConfigMgr.DataRead
    {
    internal class SeedData
        {
        public void data( ConfigMgrContext context )
            {

            //int null_ = Convert.ToInt16(null);

            //var plan_ = new List<Plan>
            //    {
            //     new Plan() {abbr = "seed", descr = ""}
            //    ,new Plan() {abbr = "S2", descr = "Shop o2"}
            //    ,new Plan() {abbr = "S2", descr = "Shop o2"}
            //    ,new Plan() {abbr = "S3", descr = "Shop o3"}
            //    };

            //context.plan.AddRange(plan_);


            //List<Plan> _plan = context.plan.Where(p => p.abbr.Equals("seed")).ToList() ;

            //var app_ = new List<App>
            //    {
            //     new App() {ITIL = Convert.ToInt16("3330"), abbr = "C01", description = "EDI with Customer 01" ,Plans = _plan}
            //    ,new App() { ITIL = Convert.ToInt16("9843"), abbr = "C02", description = "EDI with Customer 02" ,Plans = _plan}
            //    ,new App() { ITIL = Convert.ToInt16("2593"), abbr = "C03", description = "EDI with Customer 03" ,Plans = _plan}
            //    ,new App() { ITIL = Convert.ToInt16("3247"), abbr = "V01", description = "EDI with Vendor 01" ,Plans = _plan}
            //    ,new App() { ITIL = Convert.ToInt16("6554"), abbr = "V02", description = "EDI with Vendor 02" ,Plans = _plan}
            //    ,new App() { ITIL = Convert.ToInt16("7654"), abbr = "U01", description = "EDI Universal 01" ,Plans = _plan}
            //    ,new App() { ITIL = Convert.ToInt16("6545"), abbr = "U02", description = "EDI Universal 02" ,Plans = _plan}
            //    };

            //context.app.AddRange(app_);



            //var paramVersion_ = new List<ParamVersion>
            //{
            // new ParamVersion() {version = 0.001F, description = "EDI SSIS batch - Legacy"}
            //,new ParamVersion() {version = 0.002F, description = "EDI VB batch - Legacy"}
            //,new ParamVersion() {version = 1.001F, description = "EDI SSIS batch - Version 2017.001"}
            //,new ParamVersion() {version = 1.002F, description = "EDI SSIS batch - Version 2017.002"}
            //,new ParamVersion() {version = 2.001F, description = "App batch xyz Retrofit"}
            //,new ParamVersion() {version = 3.001F, description = "App web 123 Retrofit"}
            //,new ParamVersion() {version = 4.001F, description = "App batch 123 Retrofit"}
            //};

            //context.paramVersion.AddRange(paramVersion_);






            ////var paramDef_ = new List<ParamDefinition>
            ////    {
            //// new ParamDef {paramVersionID = 0.001F , ID = 1 , abbr = "Server" , dataType = "string" , usage = "server name"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 2 , abbr = "db" , dataType = "string" , usage = "database"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 3 , abbr = "sch" , dataType = "string" , usage = "schema"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 4 , abbr = "table1" , dataType = "string" , usage = "table 1"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 5 , abbr = "table2" , dataType = "string" , usage = "table 2"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 6 , abbr = "ImpDir" , dataType = "string" , usage = "import directory"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 7 , abbr = "ExpDir" , dataType = "string" , usage = "export directory"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 8 , abbr = "Postdir" , dataType = "string" , usage = "post processing directory"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 9 , abbr = "filespec" , dataType = "string" , usage = "filename pattern"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 10 , abbr = "copytodir" , dataType = "string" , usage = "copy to directory"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 11 , abbr = "movetodir" , dataType = "string" , usage = "move to directory"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 12 , abbr = "SP1" , dataType = "string" , usage = "stored proc 1"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 13 , abbr = "StgServer" , dataType = "string" , usage = "Staging server name"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 14 , abbr = "StgDb" , dataType = "string" , usage = "Staging database"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 15 , abbr = "StgSch" , dataType = "string" , usage = "Staging schema"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 16 , abbr = "StgTable1" , dataType = "string" , usage = "Staging table 1"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 17 , abbr = "StgTable2" , dataType = "string" , usage = "Staging table 2"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 18 , abbr = "EmailFrom" , dataType = "string" , usage = "Email From Success"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 19 , abbr = "EmailTo" , dataType = "string" , usage = "Email To Success"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 20 , abbr = "EmailFromError" , dataType = "string" , usage = "Email From Error"}
            ////,new ParamDef {paramVersionID = 0.001F , ID = 21 , abbr = "EmailtoError" , dataType = "string" , usage = "Email To Error"}


            ////,new ParamDef {paramVersionID = 2.01F , ID = 1 , abbr = "execOpt1" , dataType = "bool" , usage = "Enable/Disable processing Features"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 2 , abbr = "execOpt2" , dataType = "bool" , usage = "Enable/Disable processing Features"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 3 , abbr = "execOpt3" , dataType = "bool" , usage = "Enable/Disable processing Features"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 4 , abbr = "execOpt4" , dataType = "bool" , usage = "Enable/Disable processing Features"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 5 , abbr = "execOpt5" , dataType = "bool" , usage = "Enable/Disable processing Features"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 11 , abbr = "connRW1_1Srvr" , dataType = "Server" , usage = "SQL Server Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 12 , abbr = "connRW1_2Db" , dataType = "string" , usage = "SQL Database Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 13 , abbr = "connRW1_3Sch" , dataType = "string" , usage = "SQL Schema Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 14 , abbr = "connRW1_4Tbl1" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 15 , abbr = "connRW1_4Tbl2" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 16 , abbr = "connRW1_4Tbl3" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 17 , abbr = "connRW1_4Tbl4" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 18 , abbr = "connRW1_4Tbl5" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 19 , abbr = "connRW1_5SP1" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 20 , abbr = "connRW1_5SP2" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 21 , abbr = "connRW1_5SP3" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 22 , abbr = "connRW1_5SP4" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 23 , abbr = "connRW1_5SP5" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 24 , abbr = "connRW2_1Srvr" , dataType = "Server" , usage = "SQL Server Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 25 , abbr = "connRW2_2Db" , dataType = "string" , usage = "SQL Database Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 26 , abbr = "connRW2_3Sch" , dataType = "string" , usage = "SQL Schema Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 27 , abbr = "connRW2_4Tbl1" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 28 , abbr = "connRW2_4Tbl2" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 29 , abbr = "connRW2_4Tbl3" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 30 , abbr = "connRW2_4Tbl4" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 31 , abbr = "connRW2_4Tbl5" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 32 , abbr = "connRW2_5SP1" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 33 , abbr = "connRW2_5SP2" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 34 , abbr = "connRW2_5SP3" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 35 , abbr = "connRW2_5SP4" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 36 , abbr = "connRW2_5SP5" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 37 , abbr = "connRW3_1Srvr" , dataType = "Server" , usage = "SQL Server Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 38 , abbr = "connRW3_2Db" , dataType = "string" , usage = "SQL Database Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 39 , abbr = "connRW3_3Sch" , dataType = "string" , usage = "SQL Schema Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 40 , abbr = "connRW3_4Tbl1" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 41 , abbr = "connRW3_4Tbl2" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 42 , abbr = "connRW3_4Tbl3" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 43 , abbr = "connRW3_4Tbl4" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 44 , abbr = "connRW3_4Tbl5" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 45 , abbr = "connRW3_5SP1" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 46 , abbr = "connRW3_5SP2" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 47 , abbr = "connRW3_5SP3" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 48 , abbr = "connRW3_5SP4" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 49 , abbr = "connRW3_5SP5" , dataType = "string" , usage = "SQL StoredProc"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 50 , abbr = "connRO4_1Srvr" , dataType = "Server" , usage = "SQL Server Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 51 , abbr = "connRO4_2Db" , dataType = "string" , usage = "SQL Database Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 52 , abbr = "connRO4_3Sch" , dataType = "string" , usage = "SQL Schema Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 53 , abbr = "connRO4_4Tbl1" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 54 , abbr = "connRO4_4Tbl2" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 55 , abbr = "connRO4_4Tbl3" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 56 , abbr = "connRO4_4Tbl4" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 57 , abbr = "connRO4_4Tbl5" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 58 , abbr = "connRO5_1Srvr" , dataType = "Server" , usage = "SQL Server Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 59 , abbr = "connRO5_2Db" , dataType = "string" , usage = "SQL Database Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 60 , abbr = "connRO5_3Sch" , dataType = "string" , usage = "SQL Schema Name"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 61 , abbr = "connRO5_4Tbl1" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 62 , abbr = "connRO5_4Tbl2" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 63 , abbr = "connRO5_4Tbl3" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 64 , abbr = "connRO5_4Tbl4" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 65 , abbr = "connRO5_4Tbl5" , dataType = "string" , usage = "SQL table"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 101 , abbr = "pathGenerating1" , dataType = "path" , usage = "Make new files here"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 102 , abbr = "pathGenerating2" , dataType = "path" , usage = "Make new files here"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 103 , abbr = "pathGenerating3" , dataType = "path" , usage = "Make new files here"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 104 , abbr = "pathProcessMe1" , dataType = "path" , usage = "Process existing files here"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 105 , abbr = "pathProcessMe2" , dataType = "path" , usage = "Process existing files here"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 106 , abbr = "pathProcessMe3" , dataType = "path" , usage = "Process existing files here"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 107 , abbr = "pathExportMe1" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 108 , abbr = "pathExportMe2" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 109 , abbr = "pathExportMe3" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 110 , abbr = "pathExportMe4" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 111 , abbr = "pathExportMe5" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 112 , abbr = "pathExportMe6" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 113 , abbr = "pathExportMe7" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 114 , abbr = "pathExportMe8" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 115 , abbr = "pathExportMe9" , dataType = "path" , usage = "copy files (from Generating/ProcessMe) to this path for pickup"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 116 , abbr = "pathArchive1" , dataType = "path" , usage = "Move files (from Generating/ProcessMe) to this path for archival"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 117 , abbr = "pathArchive2" , dataType = "path" , usage = "Move files (from Generating/ProcessMe) to this path for archival"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 118 , abbr = "pathArchive3" , dataType = "path" , usage = "Move files (from Generating/ProcessMe) to this path for archival"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 130 , abbr = "fileNamePattern1" , dataType = "NTFS" , usage = "pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 131 , abbr = "fileNamePattern2" , dataType = "NTFS" , usage = "pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 132 , abbr = "fileNamePattern3" , dataType = "NTFS" , usage = "pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 133 , abbr = "fileNamePattern4" , dataType = "NTFS" , usage = "pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 134 , abbr = "fileNamePattern5" , dataType = "NTFS" , usage = "pattern to identify file to process (NTFS wildcards) Pipe Delimited for multiple"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 135 , abbr = "fileNameFormula1" , dataType = "SqlSelect" , usage = "Sql Select statement to create filename string"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 136 , abbr = "fileNameFormula2" , dataType = "SqlSelect" , usage = "Sql Select statement to create filename string"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 137 , abbr = "fileNameFormula3" , dataType = "SqlSelect" , usage = "Sql Select statement to create filename string"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 138 , abbr = "fileNameFormula4" , dataType = "SqlSelect" , usage = "Sql Select statement to create filename string"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 139 , abbr = "fileNameFormula5" , dataType = "SqlSelect" , usage = "Sql Select statement to create filename string"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 145 , abbr = "emailNotify1From" , dataType = "EmailFrom" , usage = "Avoid custom batch-generated emails"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 146 , abbr = "emailNotify1To" , dataType = "EmailTo" , usage = "Avoid custom batch-generated emails"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 147 , abbr = "emailNotify2From" , dataType = "EmailFrom" , usage = "Avoid custom batch-generated emails"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 148 , abbr = "emailNotify2To" , dataType = "EmailTo" , usage = "Avoid custom batch-generated emails"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 149 , abbr = "emailNotify3From" , dataType = "EmailFrom" , usage = "Avoid custom batch-generated emails"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 150 , abbr = "emailNotify3To" , dataType = "EmailTo" , usage = "Avoid custom batch-generated emails"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 151 , abbr = "emailErrorFrom" , dataType = "EmailFrom" , usage = "Email IT for Unhandled exceptions"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 152 , abbr = "emailErrorTo" , dataType = "EmailTo" , usage = "Email IT for Unhandled exceptions"}
            ////,new ParamDef {paramVersionID = 2.01F , ID = 160 , abbr = "PurgeDays" , dataType = "int" , usage = "Max Days to keep data - purge older"}
            ////};

            //////foreach (var x in paramDef_)
            //////    {
            //////        context.ME_paramDef.Add(x);
            //////    }
            ////context.ME_paramDef.AddRange(paramDef_);


            //context.SaveChanges();


            }

        }
    }