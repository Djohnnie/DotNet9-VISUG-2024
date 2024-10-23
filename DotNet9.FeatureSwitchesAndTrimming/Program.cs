﻿using System.Diagnostics.CodeAnalysis;



if (Feature.IsSupported)
    Feature.Implementation();



public class Feature
{
    [FeatureSwitchDefinition("Feature.IsSupported")]
    internal static bool IsSupported => AppContext.TryGetSwitch("Feature.IsSupported", out bool isEnabled) ? isEnabled : true;

    internal static void Implementation()
    {
        Console.WriteLine(longString);
    }
}