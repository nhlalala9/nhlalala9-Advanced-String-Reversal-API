// Services/StringService.cs
using System;

namespace StringManipulationApi.Services
{
    public class StringService
    {
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            string reversed = ReverseString(input);
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
