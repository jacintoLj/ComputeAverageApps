using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade1, grade2, grade3, grade4, grade5;
            double roundOff, total, average;
            Console.WriteLine("Enter 5 grades seperated by new line: ");
            grade1 = Convert.ToInt32(Console.ReadLine());
            grade2 = Convert.ToInt32(Console.ReadLine());
            grade3 = Convert.ToInt32(Console.ReadLine());
            grade4 = Convert.ToInt32(Console.ReadLine());
            grade5 = Convert.ToInt32(Console.ReadLine());
            total = grade1 + grade2 + grade3 + grade4 + grade5;
            average = total / 5;
            roundOff = Math.Round(average);
            Console.Write("The Average is " + average + " round off to " + roundOff);
            Console.WriteLine("\n Press any key to exit...\n");
           
            }
        }
    }

