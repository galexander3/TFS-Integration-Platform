﻿ALTER TABLE [dbo].[LAST_PROCESSED_ITEM_VERSIONS]
	ADD CONSTRAINT [PK_LastProcessedItemVersions]
	PRIMARY KEY (MigrationSourceId, ItemId)