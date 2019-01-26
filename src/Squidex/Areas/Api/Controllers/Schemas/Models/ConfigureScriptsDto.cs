﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.Collections.Generic;
using Squidex.Domain.Apps.Entities.Schemas.Commands;

namespace Squidex.Areas.Api.Controllers.Schemas.Models
{
    public sealed class ConfigureScriptsDto : Dictionary<string, string>
    {
        public ConfigureScripts ToCommand()
        {
            return new ConfigureScripts { Scripts = this };
        }
    }
}
