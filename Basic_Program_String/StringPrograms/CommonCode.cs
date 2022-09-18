using System;
using System.Collections.Generic;
using System.Text;

namespace StringPrograms
{
    public static class CommonCode
    {
        public static char readInput()
        {
            Console.WriteLine("Enter String");
            return Convert.ToChar(Console.ReadLine().ToLower());
        }

        public static int Menu()
        {
            Console.WriteLine("-------------------String Programs----------------------");
            Console.WriteLine("01. Check Vowel or not");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter Choice :: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void performOperation(int userChoice)
        {
            char userInput;
            switch (userChoice)
            {
                case 1:
                    userInput = CommonCode.readInput();
                    Vowels obj1 = new Vowels();
                    Console.WriteLine($"Char {userInput} is {obj1.usingIfCondtion(userInput)}");
                    //Console.WriteLine($"Char {userInput} is {obj1.usingSwitchStatement(userInput)}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        public static string isContinue()
        {
            Console.WriteLine("do youwant to continue ? (Y|N)");
            return Console.ReadLine().ToUpper();
        }

        public static void TheEnd()
        {
            Console.WriteLine("!!! Press Any Key To Exit !!!");
            Console.ReadLine();
        }
    }
}
