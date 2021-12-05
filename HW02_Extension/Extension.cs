using System;
// System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace HW02
{
    public static class Extension
    {
        public static string ToTl(this double value)
        {
            return Convert.ToString(value * 13)+"TL";
        }
    }
}
