﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 7);
            Console.WriteLine($"player rolls the dice to get a number = {number}");
            Console.ReadLine();

        }
    }
}