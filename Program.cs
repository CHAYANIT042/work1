using System;

namespace test6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] recordFile;

            recordFile = new string[5];

            recordFile[0] = " ";
            recordFile[1] = " ";
            recordFile[2] = " ";
            recordFile[3] = " ";
            recordFile[4] = " ";

            Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
            Console.WriteLine("[0] Show all recent files");
            Console.WriteLine("[1] Open new file");
            Console.WriteLine("[2] Open recent file");
            Console.WriteLine("[3] Exit");

            int number;
            number = int.Parse(Console.ReadLine());
            do
            {
                if (number == 0)
                {

                }
                else if (number == 1)
                {

                }
                else if (number == 2)
                {

                }
                else if (number == 3)
                { 
                
                }


                    Console.WriteLine("Invalid menu number.");
            } while ( );
        }
    }
}
