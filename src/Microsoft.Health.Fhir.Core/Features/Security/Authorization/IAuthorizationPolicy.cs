﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Security.Claims;

namespace Microsoft.Health.Fhir.Core.Features.Security.Authorization
{
    public interface IAuthorizationPolicy
    {
        bool HasActionPermission(ClaimsPrincipal user, ResourceAction action);

        IEnumerable<ResourcePermission> GetApplicableResourcePermissions(ClaimsPrincipal user, ResourceAction action);
    }
}