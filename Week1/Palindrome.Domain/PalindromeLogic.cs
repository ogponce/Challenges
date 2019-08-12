namespace Palindrome.Domain
{
    public class PalindromeLogic
    {

      public string Phrase { get; set; }
      public string compare = "";
      
      public PalindromeLogic() {

      }

      public void reversePalindrome(){
        for (int i = Phrase.Length-1; i > 0; i--)
        {
            compare += Phrase[i];
            System.Console.WriteLine(compare);   
        }
      }
      
      public void checkPalindrome(){
        int counter = 1;
        for (int i = 0; i < Phrase.Length-1; i++)
        {
          if (compare[i] == Phrase[i]){
            counter += 1;
          }
          else {
          }
          
        }
        System.Console.WriteLine(counter);
        if (counter == Phrase.Length){
          System.Console.WriteLine(Phrase + " is a Palindrome!");
        }
        else
        {
            System.Console.WriteLine(Phrase + " is not a Palindrome");
        }

      }
    }
}