using System;

namespace ข้อสอบข้อ3กล้อง
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode; 
            mode = Console.ReadLine();
            double flimblackwidth;
            flimblackwidth = double.Parse(Console.ReadLine());

            if (flimblackwidth > 0)
            {
                double flenght, fov;
                if (mode == "flenght")
                {
                    flenght = double.Parse(Console.ReadLine());
                    if (flenght > 0)
                    {
                        fov = 2 * Math.Atan(flimblackwidth / (2 * flenght));
                        Console.WriteLine("flenght={0}", flenght,"fov = {1}", fov);
                    }
                    else
                    {
                        Console.WriteLine("Invalid flenght Please input again.");
                    }
                }
                else if (mode == "fov")
                {
                    fov = double.Parse(Console.ReadLine());
                    if (fov > 0.1 && fov < 6.28)
                    {
                        flenght = flimblackwidth / (2 * Math.Tan(fov / 2));
                        Console.WriteLine("flenght = {0}", flenght,"fov = {1}", fov);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid fov Please input again.");
                    }
                }
            }
            else
            { 
            
            }
                
            
        }
    }
}
