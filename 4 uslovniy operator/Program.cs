using System;

namespace _4_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNamber = random.Next(0, 101);
            Console.WriteLine(randomNamber);
            int sumOfNumber = 0;

            for (int i = 1; i <= randomNamber; i++)
            {
                if (i % 3 == 0)
                {
                    sumOfNumber += i;
                }
                else if (i % 5 == 0)
                {
                    sumOfNumber += i;
                }
                else
                    continue;
            }
            Console.WriteLine(sumOfNumber);
        }
    }
}
