using System;

namespace CalculateLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandom = 0;
            int Sum = 0;
            for (int i = 0; i < 10; i++)
            {
                myRandom = rnd.Next(1, 11);
                Sum = Sum + myRandom;
                Console.WriteLine($"My random number:{ myRandom}");

            }

            Console.WriteLine($"Sum={Sum}", Sum);

        }
    }
}
