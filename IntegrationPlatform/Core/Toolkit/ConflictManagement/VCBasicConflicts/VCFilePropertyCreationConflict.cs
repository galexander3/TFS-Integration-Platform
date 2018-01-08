﻿// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)

namespace Microsoft.TeamFoundation.Migration.Toolkit
{
    class VCFilePropertyCreationConflict : MigrationConflict
    {
        public VCFilePropertyCreationConflict(ConflictType conflictType, string message, string filePropertyName)
            : base(conflictType,
            Status.Unresolved,
            message,
            filePropertyName)
        {
        }
    }
}
