using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[count];
            int[] arr2 = new int[count];
            int[] arr3 = new int[count];
            int[] arr4 = new int[count];

            for (i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            arr2 = arr1;
            arr3 = arr1;
            arr4 = arr1;

            for (i = 0; i < arr1.Length; i++)
            {
                for (j = i; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        int temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            Console.Write("Compare's sort: ");
            for (i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            Array.Sort(arr2);
            Console.Write("Com's sort: ");
            for (i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            for (i = 0; i < arr3.Length; i++)
            {
                int temp = arr3[i];
                int currentIndex = i;

                while (currentIndex > 0 && arr3[currentIndex - 1] > temp)
                {
                    arr3[currentIndex] = arr3[currentIndex - 1];
                    currentIndex--;
                }

                arr3[currentIndex] = temp;
            }
            Console.Write("May's sort: ");
            for (i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();

            for (i = 0; i < arr4.Length; i++)
            {
                int min = i;
                for (j = i + 1; j < arr4.Length; j++)
                {
                    if (arr4[min] > arr4[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int lowerValue = arr4[min];
                    arr4[min] = arr4[i];
                    arr4[i] = lowerValue;
                }
            }
            Console.Write("Sea's sort: ");
            for (i = 0; i < arr4.Length; i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
