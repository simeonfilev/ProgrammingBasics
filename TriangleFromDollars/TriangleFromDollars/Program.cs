﻿using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            Console.Write("$");
            for (int col = 1; col <= row; col++)
            {
                Console.Write(" $");

            }
            Console.WriteLine();
        }
    }
}
