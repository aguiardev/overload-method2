using System;

namespace OverloadMethod2
{
    public static class ConvertToString
    {
        public static string Get(bool value)
            => $"Boolean -> {value.ToString()}";

        public static string Get(int value)
            => $"Integer -> {value.ToString()}";

        public static string Get(DateTime value)
            => $"Date -> {value.ToString("dd/MM/yyyy")}";
    }
}