using System;

namespace _4_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimumRabdomNumber = 0;
            int maximumRabdomNumber = 101;
            Random random = new Random();
            int randomNamber = random.Next(minimumRabdomNumber, maximumRabdomNumber);
            Console.WriteLine(randomNamber);
            int sumOfNumber = 0;
            int multipleNumber1 = 3;
            int multipleNumber2 = 5;

            for (int i = 1; i <= randomNamber; i++)
            {
                if (i % multipleNumber1 == 0 || i % multipleNumber2 == 0)
                {
                    sumOfNumber += i;
                }
            }
            Console.WriteLine(sumOfNumber);
        }
    }
}
