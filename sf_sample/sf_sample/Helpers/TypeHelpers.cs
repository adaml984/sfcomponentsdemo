using System;

namespace sf_sample.Helpers
{
    public static class TypeHelpers
    {
        public static string GetNavigationId(this Type @type) { return @type.FullName; }
    }
}