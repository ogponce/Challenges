using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
          PalindromeLogic p = new PalindromeLogic();
          p.Phrase = "civil";
          p.reversePalindrome();
          p.checkPalindrome();
        }
    }
}
