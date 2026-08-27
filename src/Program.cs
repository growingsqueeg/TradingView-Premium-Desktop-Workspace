// Build: a64189d30c1f3d75e3e1ba1cb86e22d0
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
