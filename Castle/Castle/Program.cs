﻿using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var weight = n * 2;
        var spaces = n * 2 - 2;
        var neshto = n * 2 - 4 - 2 * (n / 2);
        if (n >= 5)
        {
            Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', n / 2), new string('_', neshto));

            for (int i = 1; i < n - 2; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', n*2-2));
            }
            Console.WriteLine("|{0}{1}{0}|",new string(' ',(n/2)+1),new string('_', neshto));
            Console.WriteLine(@"\{0}/{1}\{0}/",new string('_',n/2), new string(' ', neshto));
        }
        else
        {
            Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', n / 2), new string('_', 0));

            for (int i = 1; i < n-1; i++)
            {
                Console.WriteLine("|{0}|",new string(' ',spaces));
            }
            Console.WriteLine(@"\{0}/{1}\{0}/", new string('_', n / 2), new string(' ', 0));
        }
        
    }
}
