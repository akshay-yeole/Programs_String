using System;

namespace StringPrograms
{
    public class Vowels
    {
        //Convert to lowercase
        //if (ch >= 'A' && ch <= 'Z')
        //    ch = ch+'a'-'A';
        public string usingIfCondtion(char userInput)
        {
            return (userInput == 'a' || userInput == 'e' || userInput == 'i' || userInput == 'o' || userInput == 'u') ? "Vowel" : "Not Vowel";
        }
        public string usingSwitchStatement(char userInput)
        {
            switch (userInput)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return "Vowel";
                default:
                    return "Not Vowel";
            }
        }
    }
}
