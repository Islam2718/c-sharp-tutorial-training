﻿// mathematical operations
/*
    Console.readLine();
*/

using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {
        // 
        string? studentName; 
        int studentAge;
        double studentHeight;
        string? studentAddress;

        Console.Write("Insert Student Name: ");
        studentName = Console.ReadLine();
        Console.Write("Insert Student Age: ");
        studentAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insert Student Height: ");
        studentHeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insert Student Address: ");
        studentAddress = Console.ReadLine();

        Console.WriteLine("----------\nThe Student Information is:\n----------");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age: " + studentAge);
        Console.WriteLine("Height: " + studentHeight);
        Console.WriteLine("Address: " + studentAddress);
    }
}