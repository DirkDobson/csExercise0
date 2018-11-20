using System;

namespace csExercises0
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("put a number 1 - 10");
            userInput = Console.ReadLine();
            if (userInput <= 10 && >= 1) ;
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("Not 1 - 10");
            }
        }
    }
}
