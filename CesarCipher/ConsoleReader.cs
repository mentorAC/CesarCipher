using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCipher
{
    internal class ConsoleReader
    {
        public static string ReadString(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
        public static int ReadNumber(string msg)
        {
            Console.WriteLine(msg);
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
