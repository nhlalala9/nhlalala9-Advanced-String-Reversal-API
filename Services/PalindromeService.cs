using System;
using System.Text;

public class PalindromeService
{
    public string ReverseString(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public bool IsPalindrome(string input)
    {
        string reversed = ReverseString(input);
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}