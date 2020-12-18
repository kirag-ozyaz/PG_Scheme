using System;


    internal static class Extensions
    {
        public static string AsString(this decimal value)
        {
            return value.ToString("0.###############");
        }
    }
