using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[3, 3];
            int row, col;

            row = 0;
            col = 0;
            for(int i = 0; i < 9; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if(row <= 2)
                {
                    if(col <= 2)
                    {
                        nums[row, col] = num;
                        col++;
                    }
                    else
                    {
                        col = 0;
                        row++;
                        nums[row, col] = num;
                        col++;
                    }
                }
            }

            int rowZero = 0, colZero = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(nums[i, j] == 0)
                    {
                        rowZero = i;
                        colZero = j;
                    }
                    Console.Write(nums[i, j]+" ");
                }
                Console.WriteLine();
            }

            int numAdd = Convert.ToInt32(Console.ReadLine());
            bool isValid = false;
            for(col = 0; col < 3; col++)
            {
                if(numAdd == nums[rowZero, col])
                {
                    isValid = true;
                }
            }

            for (row = 0; row < 3; row++)
            {
                if (numAdd == nums[colZero, row])
                {
                    isValid = true;
                }
            }

            if (isValid)
            {
                Console.WriteLine("The number is avalible.");
            }
            else
            {
                nums[rowZero, colZero] = numAdd;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(nums[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
