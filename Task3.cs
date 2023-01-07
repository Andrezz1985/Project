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
            Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");

            int functionAk = Ack(m, n);

            Console.Write($"Функция Аккермана = {functionAk} ");

            int InputNumbers(string input)
            {
                Console.Write(input);
                int output = Convert.ToInt32(Console.ReadLine());
                return output;
            }

            int Ack(int m2, int n2)
            {
                if (m2 == 0) return n2 + 1;
                else if (n2 == 0) return Ack(m2 - 1, 1);
                else return Ack(m2 - 1, Ack(m2, n2 - 1));
            }
        }
    }
}