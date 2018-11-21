using System;

namespace csExercises0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("put a number 1 - 10");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput >= 1 && userInput <= 10)
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("bad");
            }
            Console.WriteLine("Put two number and I will tell you which is greater");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            var result = num1 > num2 ? $"{num1} is greater" : $"{num2} is greater";
            Console.WriteLine(result);

            Console.WriteLine("Height and Width landscape or portrait");

        }
    }
}