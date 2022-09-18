using StringPrograms;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                CommonCode.performOperation(CommonCode.Menu());
            } while (CommonCode.isContinue() != "N");
            CommonCode.TheEnd();
        }
    }
}
