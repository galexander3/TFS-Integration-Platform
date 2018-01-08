﻿    // Copyright © Microsoft Corporation.  All Rights Reserved.
    // This code released under the terms of the 
    // Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)

using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace Microsoft.TeamFoundation.Migration.Tfs2010WitAdapter
{
    public static partial class TfsConstants
    {
        public static readonly string DisableAreaPathAutoCreation = "DisableAreaPathAutoCreation";
        public static readonly string DisableIterationPathAutoCreation = "DisableIterationPathAutoCreation";
        public static readonly string EnableBypassRuleDataSubmission = "EnableBypassRuleDataSubmission";
        public static readonly string ReflectedWorkItemIdFieldReferenceName = "ReflectedWorkItemIdFieldReferenceName";
        public static readonly string EnableInsertReflectedWorkItemId = "EnableInsertReflectedWorkItemId";

        public static readonly string MigrationTracingFieldRefName = "TfsMigrationTool.ReflectedWorkItemId";
        public static readonly string MigrationTracingFieldDispName = "Mirrored TFS ID";
        public const FieldType MigrationTracingFieldType = FieldType.String;

        public static readonly string TfsAreaPathsContentTypeRefName = "Microsoft.TeamFoundation.Migration.TfsWitAdapter.AreaPaths";
        public static readonly string TfsAreaPathsContentTypeDispName = "Team Foundation Server Area Paths";

        public static readonly string TfsIterationPathsContentTypeRefName = "Microsoft.TeamFoundation.Migration.TfsWitAdapter.IterationPaths";
        public static readonly string TfsIterationPathsContentTypeDispName = "Team Foundation Server Iteration Paths";

        public static readonly string TfsCSSNodeChangesContentTypeRefName = "Microsoft.TeamFoundation.Migration.TfsWitAdapter.CSSNodeChanges";
        public static readonly string TfsCSSNodeChangesContentTypeDispName = "Team Foundation Server Common Structure node changes";

        public const string HwmDeltaLinkChangeId = "HwmDeltaLinkChangeId";
        public const string HwmSubmittedLinkChangeId = "HwmSubmittedLinkChangeId";

        // These error number are defined in DevDiv\alm\alm\tfs_core\WorkItemTracking\Includes\psdbdal.h
        public const int TfsError_AddLink_Circular = 600270;
        public const int TfsError_AddLink_TooManyParents = 600271;
        public const int TfsError_AddLink_ChildIsAncestor = 600272;
        public const int TfsError_AddLink_LinkExists = 600273;
        public const int TfsError_DeleteLink_LinkNotFound = 600275;
        public const int TfsError_LinkAuthorizationFailed = 600276;
        public const int TfsError_LinkAuthorizationFailedNotServiceAccount = 600277;
        public const int TfsError_LinkAuthorizationFailedLinkLocked = 600280;
    }
}
