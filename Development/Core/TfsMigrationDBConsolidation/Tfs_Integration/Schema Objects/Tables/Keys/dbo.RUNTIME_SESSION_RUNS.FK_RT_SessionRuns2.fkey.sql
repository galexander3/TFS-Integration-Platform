﻿ALTER TABLE [dbo].[RUNTIME_SESSION_RUNS]
	ADD CONSTRAINT [FK_RT_SessionRuns2] 
	FOREIGN KEY (SessionGroupRunId)
	REFERENCES RUNTIME_SESSION_GROUP_RUNS (Id)	
