﻿// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.TeamFoundation.Migration.BusinessModel.BusinessRuleEvaluation
{
    /// <summary>
    /// The interface that all business rule should implement.
    /// </summary>
    interface IEvaluationRule
    {
        EvaluationResultItem Evaluate(Configuration configuration);
    }
}
