using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int i, j, amount, num;

            Console.Write("Enter amount of numbers: ");
            amount = Convert.ToInt32(Console.ReadLine());

            numbers = new int[amount];
            for(i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number #{0}: ", i+1);
                num = Convert.ToInt32(Console.ReadLine());
                
                numbers[i] = num;
            }

            for (i = 0; i < numbers.Length - 1; i++)
            {
                for (j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {

                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.Write("\nNumbers in ascending order: ");
            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }
    }
}
