using System;

namespace myfirsttemplateNamespace
{
    public static class myfirsttemplate
    {
        public static string Reverse(this string value)
        {
            var tempArray = value.ToCharArray();
            Array.Reverse(tempArray);
            return new string(tempArray);
        }
    }
}