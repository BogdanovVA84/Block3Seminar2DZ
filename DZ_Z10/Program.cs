// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

namespace HomeWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 999 || number < 100) 
            {
                Console.WriteLine("We cannot");
            } 
            else 
            {
                Console.WriteLine((number / 10) % 10);
            }
            
        
        }
    }
}