﻿using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Sayhello(userName, userAge); 
        }

        private static void Sayhello(string someName, int someNumber)
        {
            Console.WriteLine($"Hi there! {someName}");
            Console.WriteLine($"Oled sündinud aastal {2021 - someNumber}");


        }

    }
}
