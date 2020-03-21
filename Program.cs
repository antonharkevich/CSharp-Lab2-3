using System;

namespace ConsoleAppLaba2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] a = s.Split();
            StringBuilder builder = new StringBuilder();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                builder.Append(a[i]);
                builder.Append(" ");
            }
            Console.WriteLine(builder);
        }
    }
}
