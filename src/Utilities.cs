// Build: 97f1e8ce317656f11014c6b4aa2c3de4
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
