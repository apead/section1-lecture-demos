using System;

namespace StringHelpers
{
    public class StringUtilities 
    {
        public string ReverseString(string myString)
        {
            var index = myString.Length - 1;
            var result = string.Empty;

            while (index >= 0)
                result += myString[index--];

            return result;
        }
    }


}