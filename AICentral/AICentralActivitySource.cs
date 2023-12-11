﻿using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace AICentral;

public static class AICentralActivitySource
{
    public static readonly string AICentralTelemetryName = typeof(AICentralPipeline).Assembly.GetName().Name!;

    private static readonly string AICentralMeterVersion = typeof(AICentralPipeline).Assembly.GetName().Version!.ToString();

    static AICentralActivitySource()
    {
        AICentralMeter = new Meter(AICentralTelemetryName, AICentralMeterVersion);
        AICentralRequestActivitySource = new ActivitySource("aicentral");
    }

    public static Meter AICentralMeter { get; set; }

    public static ActivitySource AICentralRequestActivitySource { get; set; }
}