using System;

namespace Pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 0, val = 1, i, j;
            bool isValid = false;
            while (isValid == false)
            {
                rows = Convert.ToInt32(Console.ReadLine());
                if (rows < 0)
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.");
                }
                else
                {
                    isValid = true;
                }
            }
            Console.WriteLine();
            for (i = 0; i <= rows; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
