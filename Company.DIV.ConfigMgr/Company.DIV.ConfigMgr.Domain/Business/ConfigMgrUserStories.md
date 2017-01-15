Going with these definitions:

"User Stories" 
 -are promises to have a conversation...

"Use Cases" 
 -are the granular enumerations resulting from the conversation...



```
As an **>Executable SSIS package<**
	I want 
		{my Parameters to come to me as a Sql Recordset}
	so that 
		{I execute as-needed over the years, with low maintenance by avoiding hardcoding}


As **>Any Interested User<**
	I want 
		{to be able to Flag any data element as inaccurate}
	so that 
		{it will be added to knowledge-base, reviewed and addressed}


As a **>Developer<**
	I want 
		{to Create New Configurations }
	so that 
		{My new code will execute as-needed over the years, with low maintenance by avoiding hardcoding}
		{My existing code can be extended (D.R.Y.)}





As a **>Developer<**
	I want 
		{to Create New Configurations in Batches}
	so that 
		{related configurations can have sequential JobIDs}


As a **>Developer<**
	I want 
		{to import parameters from existing configurations}
	so that 
		{I can save time when making similar code/configurations}



As a **>Developer<**
	I want 
		{an option to Synchronize existing parameters, or Propagate new parameters across environs 
		Sync(All incl PROD); Sync(Path1); Sync(Path2)}
	so that 
		{I can reduce my development effort, ensure deployment consistency, and gain peace of mind by eliminating a manual process}


As a **>Developer<**
	I want 
		{instant feedback about how my configurations & parameters fit into our dept standards}
	so that 
		{I can avoid problems early, avoid rework, learn faster, keep up to speed with the latest standards}



As a **>Developer<** OR **ProdSupporter**
	I want 
		{to view and/or edit multiple Configurations with parameters, by a list of JobIDs, by Environment}
	so that 
		{I can compare, and check for and correct errors in any phase of the SDLC}



As a **ProdSupporter**
	I want 
		{to be able to see the relations between Executables and Configurations and Parameters}
	so that 
		{I can more quickly research issues and perform RCCA}


As a **Developer**
	I want 
		{to be able to see the relations between Executables and Configurations and Parameters and Applications}
	so that 
		{I can more quickly research and leverage existing code, troubleshoot issues during warranty period.}



As a **>SuperUser/TSL<**
	I want 
		{to control/limit the creation of new sets of ParameterDefinitions}
	so that 
		{I can steer the team to use existing templates and codebase without re-inventing the wheel}


As a **>SuperUser/TSL<**
	I want 
		{to be able to edit the mappings of new sets of ParameterDefinitions to Informatics extracts}
	so that 
		{the knowledge in ConfigMge is not silo'd}



As **>Any Interested User<**
	I want 
		{to Query a Config Aggregate (Config/Job, ParamValues, RelatedExecutables, Parent Application)
			by ID
			by ParamValues
			by Job Desc
			by Application
			by Application.Abbr
			by Current User has Recently Inquired
			by Current User has Recently Updated
			and view data asof a certain datetime
		}
	so that 
		{I can research issues using just a small fragment of information}




As **>Any Interested User<**
	I want 
		{	Query recent changes
			by Date Range
			by User
			by ParamValues
			by Config JobID
			by Application
		}
	so that 
		{I can research issues when all I know is the timing the issues}




As a **>Developer<**
	I want 
		{	Query recent changes
			by Date Range
			by User
			by ParamValues
			by Config JobID
			by Application
		}
	so that 
		{I can research recent and or conflicting changes made by a teammate}



As **>Any Interested User<**
	I want 
		{To Query Configurations and relations
			by Date Range
			by User who updated
			by ParamValues
			by Job Desc
			by Application}
	so that 
		{I can research and troubleshoot the batch job Portfolio as needed}


As a **>TSL/Mentor<**
	I want 
		{to view Validation Overrides}
	so that 
		{So that I can guide others, and/or learn more about our challenges}



As a **>Developer who supports ConfigMgr<**
	I want 
		{to Query Internal Application Errors
			by Date Range
			by User
			by Entity
			by Error Type
		}
	so that 
		{I can troubeshoot and maintain the wonderful ConfigMgr system}


As a **>Developer who supports ConfigMgr<**
	I want 
		{to be alerted of Errors and Overrides}
	so that 
		{address issues timely}

```



~~##Dev Portal
**{Dev}** prepares checkoff List (CRQ-Specific)
**{Dev}** prepares checkoff Sub-List (CRQ-Specific, by release, by component)
**{SuperUser/TSL}** prepares checkoff List (CRQ-Specific)
**{SuperUser/TSL}** prepares checkoff Sub-List (CRQ-Specific, by release, by component)~~

~~**{Dev}** updates checkoff List~~

