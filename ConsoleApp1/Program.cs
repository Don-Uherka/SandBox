using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static string Compress(string str)
        {
            if (str == null || str == "")
            {
                return str;
            }
            StringBuilder sb = new StringBuilder();
            char prevChar = str[0];
            int count = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == prevChar)
                {
                    count++;
                }
                else
                {
                    sb.Append(prevChar);
                    sb.Append(count);
                    prevChar = str[i];
                    count = 1;
                }
            }

            sb.Append(prevChar);
            sb.Append(count);
            string result = sb.ToString();

            if (result.Length >= str.Length)
            {
                return str;
            }
            return result;
        }
        static void Main(string[] args)
        {
            CondenseString CondenseString = new CondenseString();
            string example = "aaadddvvggffff";
            string result = Compress(example);
            Console.WriteLine(result);
        }
    }
}
