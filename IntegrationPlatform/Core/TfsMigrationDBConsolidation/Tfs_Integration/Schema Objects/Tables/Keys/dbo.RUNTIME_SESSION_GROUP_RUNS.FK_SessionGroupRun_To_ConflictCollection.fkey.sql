﻿ALTER TABLE [dbo].[RUNTIME_SESSION_GROUP_RUNS]
	ADD CONSTRAINT [FK_SessionGroupRun_To_ConflictCollection] 
	FOREIGN KEY (ConflictCollectionId)
	REFERENCES RUNTIME_CONFLICT_COLLECTIONS (Id)	

