// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


namespace HomeWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 7 || number < 1) 
            {
                Console.WriteLine("Это не день недели");
            } 
            else if (number < 6) 
            {
                Console.WriteLine("Нет");
            } 
            else 
            {
                Console.WriteLine("Да");
            }
        
        }
    }
}
