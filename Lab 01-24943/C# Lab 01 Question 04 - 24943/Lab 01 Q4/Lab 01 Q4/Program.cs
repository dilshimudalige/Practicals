﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary, tax, new_salary;

            Console.Write("Enter your salary amount: ");
            salary = double.Parse(Console.ReadLine());

            Console.Write("Enter your tax rate amount: ");
            tax = double.Parse(Console.ReadLine());

            new_salary = salary - (salary * tax / 100);
            Console.Write("Your new salary is " + new_salary);
            new_salary = double.Parse(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
