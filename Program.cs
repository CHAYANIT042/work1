using System;

namespace test5
{
    class Program
    {
        struct Item
        {
            public string Name;
            public string Type;

            public Item(string name, string type)
            {
                Name = name;
                Type = type;
            }
        }

        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            Item[] items = new Item[count];
            for (int i = 0; i < items.Length; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                items[i] = new Item(name, type);
            }

            bool isEnd = false;
            while (isEnd == false)
            {
                string search = Console.ReadLine();
                if(search == "ShowAll")
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine(items[i].Name);
                        Console.WriteLine(items[i].Type);
                        Console.WriteLine();
                    }
                }
                else
                {
                    bool isFound = false;
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (search == items[i].Type)
                        {
                            Console.WriteLine(items[i].Name);
                            Console.WriteLine();
                            isFound = true;
                        }
                    }

                    if(isFound == false)
                    {
                        Console.WriteLine("End");
                        isEnd = true;
                    }
                }
            }
        }
    }
}
