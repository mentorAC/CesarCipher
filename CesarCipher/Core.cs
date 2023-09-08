using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCipher
{
    internal class Core
    {
        public static void Run()
        { 
            while (true) 
            {
                MenuManager.Show();
                MenuTypes value = MenuManager.Read();

                switch (value)
                {
                    case MenuTypes.EXIT:
                        return;
                    case MenuTypes.CLEAR:
                        Console.Clear();
                        break;
                    case MenuTypes.CODING:
                        CodingLogick();
                        break;
                    case MenuTypes.ENDCODING:
                        DeCodingLogick();
                        break;
                }
            }
        }
        private static void CodingLogick()
        {
            string str = ConsoleReader.ReadString("Enter string:");
            int number = ConsoleReader.ReadNumber("Enter number");
            string resultStr = CeaserCipher.Coding(str, number);
            Console.WriteLine("Coding result -> " + resultStr);
        }
        private static void DeCodingLogick()
        {
            string str1 = ConsoleReader.ReadString("Enter coding string: ");
            int number1 = ConsoleReader.ReadNumber("Enter number");
            string resultStr1 = CeaserCipher.DeCoding(str1, number1);
            Console.WriteLine("Your text -> " + resultStr1);
        }
    }
}
