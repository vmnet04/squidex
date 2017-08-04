﻿// ==========================================================================
//  IWebhookEventEntity.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using NodaTime;

namespace Squidex.Domain.Apps.Read.Schemas
{
    public interface IWebhookEventEntity
    {
        WebhookJob Job { get; }

        Instant? NextAttempt { get; }

        WebhookResult Result { get; }

        WebhookJobResult JobResult { get; }

        int NumCalls { get; }

        string LastDump { get; }
    }
}
