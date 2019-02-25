using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] digits = new int[5];
        Console.WriteLine("Please enter 5 numbers: ");
            for (int i = 0; i < 5; i++){
            digits[i] = Convert.ToInt32(Console.ReadLine());
            }
        Console.WriteLine("User input finished. Processing...");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{digits[i] * 10 + " "}");
            }
        Console.ReadLine();
        }
    }
}
            

