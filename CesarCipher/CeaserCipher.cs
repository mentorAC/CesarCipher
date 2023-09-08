using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace CesarCipher
{
    internal class CeaserCipher
    {
        public static string Coding(string msg, int number)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < msg.Length; i++)
            {
                if (!char.IsLetter(msg[i]))
                {
                    continue;
                }
                char new_char = (char)(msg[i] + number);
                if (new_char > 'z')
                {
                    int x_char = new_char - 'z';
                    new_char = (char)('a' + (x_char - 1));
                }
                sb.Append(new_char);
            }
            return sb.ToString();

        }

        public static string DeCoding(string msg, int number)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < msg.Length; i++)
            {
                if (!char.IsLetter(msg[i]))
                {
                    continue;
                }
                char new_char = (char)(msg[i] - number);
                if (new_char < 'a')
                {
                    int x_char = 'a' - new_char;
                    new_char = (char)('z' - (x_char) + 1);
                }

                builder.Append(new_char);

            }
            return builder.ToString();

        }
    
    }
}
