﻿using System;

namespace TechTalk.SpecFlow.IdeIntegration.Analytics
{
    public interface IAnalyticsEvent
    {
        string EventName { get; }
        string Ide { get; }
        DateTime UtcDate { get; }
        string UserId { get; }
    }
}
