using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Test
{
    public class UnitTest1
    {
        [Fact]
        public void checkWordReverse()
        {
          var pl = new PalindromeLogic();
          var pl.Phrase = "civic";
          var expected = "civic";
          
          var actual = pl.Phrase.reversePalindrome();

          Assert.True(expected == actual);  
        }

        [Fact]
        public void checkNumbberReverse()
        {
          var pl = new PalindromeLogic();
          var pl.Phrase = "51215";
          var expected = "51215";
          
          var actual = pl.Phrase.reversePalindrome();

          Assert.True(expected == actual);
        }

        [Fact]
        public void checkNonPalindromeWord()
        {
          var pl = new PalindromeLogic();
          var pl.Phrase = "civil";
          var expected = "livic";
          
          var actual = pl.Phrase.reversePalindrome();

          Assert.True(expected == actual);
        }
    }
}
