﻿ALTER TABLE [dbo].[RELATED_ARTIFACTS_RECORDS]
	ADD CONSTRAINT [FK_RelatedRecord_to_MigrationSource] 
	FOREIGN KEY (MigrationSourceId)
	REFERENCES [dbo].[MIGRATION_SOURCES] (Id)	

