﻿// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.TeamFoundation.Migration.Toolkit.ErrorManagement
{
    class TraceLogChannel : IErrorRoutingChannel
    {
        public void RouteError(Exception e)
        {
            if (e != null)
            {
                TraceManager.TraceException(e);
            }
        }
    }
}
