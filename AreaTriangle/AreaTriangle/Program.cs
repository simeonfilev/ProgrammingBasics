﻿using System;


class Program
{
    static void Main(string[] args)
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var area = (a * b) / 2;
        Console.WriteLine("Triangle area = "+ Math.Round(area, 2));
    }
}

