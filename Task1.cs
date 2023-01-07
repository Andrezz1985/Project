using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args){
             Console.Clear();
            Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
            int n = InputNumbers("Введите n: ");
            int x = 2;
            PrintNumber(n, x);
            Console.Write(1);

            int InputNumbers(string input)
            {
                Console.Write(input);
                int output = Convert.ToInt32(Console.ReadLine());
                return output;
            }

            void PrintNumber(int n1, int x2)
            {
                if (x2 > n1) return;
                PrintNumber(n1, x2 + 1);
                Console.Write(x2 + ", ");
            }

            
        }
    }
}