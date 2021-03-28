using System;

namespace ข้อสอบข้อ3
{
    class Program
    {
        static void Main(string[] args)
        {

            int box1, box2, box3;
            int numbucket, pickbox;
            bool gameStart = true;
            Console.Write("input box1 in the bucket : ");
            box1 = int.Parse(Console.ReadLine());
            Console.Write("input box2 in the bucket : ");
            box2 = int.Parse(Console.ReadLine());
            Console.Write("input box3 in the bucket : ");
            box3 = int.Parse(Console.ReadLine());

            while (gameStart == true)
            {
                Console.WriteLine("YOU A");
                Console.WriteLine("Box1 : {0},Box2 : {1},Box 3 : {2}",box1,box2,box3);
                Console.Write("Choose number bucket : ");
                numbucket = int.Parse(Console.ReadLine());
                Console.Write("How much do you want to pick : ");
                pickbox = int.Parse(Console.ReadLine());

                switch (numbucket)
                {
                    case 1:
                        box1 = box1 - pickbox;
                        break;
                    case 2:
                        box2 = box2 - pickbox;
                        break;
                    case 3:
                        box3 = box3 - pickbox;
                        break;
                    default:
                        Console.WriteLine("Not found");
                        break;
                }
                if (box1 == 0 & box2 == 0 & box3 == 0)
                {
                    Console.WriteLine("The Winner is B");
                    gameStart = false;       
                }
                Console.WriteLine("YOU B");
                Console.WriteLine("Box1 : {0},Box2 : {1},Box 3 : {2}", box1, box2, box3);
                Console.Write("Choose number bucket : "); 
                numbucket = int.Parse(Console.ReadLine());
                Console.Write("How much do you want to pick : ");
                pickbox = int.Parse(Console.ReadLine());

                switch (numbucket)
                {
                    case 1:
                        box1 = box1 - pickbox;
                        break;
                    case 2:
                        box2 = box2 - pickbox;
                        break;
                    case 3:
                        box3 = box3 - pickbox;
                        break;
                    default:
                        Console.WriteLine("Not found");
                        break;
                }
                if (box1 == 0 & box2 == 0 & box3 == 0)
                {
                    Console.WriteLine("The Winner is A");
                    gameStart = false;
                }  
            }
            Console.ReadLine();
		}
    }
}
